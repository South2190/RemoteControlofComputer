﻿using Microsoft.Win32;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Remopii.Classes;
using Remopii.FunctionSetup;

namespace Remopii
{
    public partial class MainWindow : Form
    {
        private readonly int UseThemeNumber;

        private readonly Bitmap IconOk;
        private readonly Bitmap IconWarning;
        private readonly Bitmap IconError;

        private string phpPath;

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public MainWindow()
        {
            InitializeComponent();

            AppVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            processMonitoring_Tick();
            // php.exeが動いているかを毎秒確認し、ボタンを切り替える
            processMonitoring.Tick += (s, e) => processMonitoring_Tick();
            processMonitoring.Start();

            // Windows10、Windows11のどちらかを判定し、OSに合ったインデックス番号を格納する
            const string IMAGERESDLL = @"C:\Windows\System32\imageres.dll";

            int indexOk = 0;
            int indexWarning = 0;
            int indexError = 0;

            ManagementClass mc = new("Win32_OperatingSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject managementObject in moc)
            {
                if (managementObject["Version"].ToString().Substring(0, 2) == "10")
                {
                    // Windows11
                    if (int.Parse(managementObject["BuildNumber"].ToString()) >= 22000)
                    {
                        indexOk = 233;
                        indexWarning = 231;
                        indexError = 230;
                    }
                    // Windows10
                    else
                    {
                        indexOk = 232;
                        indexWarning = 230;
                        indexError = 229;
                    }
                }
                // その他のOS
                else
                {
                    MessageBox.Show("このOSはサポートされていないため、アプリケーションが正しく動作しない可能性があります。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // それぞれの変数にアイコンを格納
            IconOk = GetIcon.GetBitmapFromEXEDLL(IMAGERESDLL, indexOk, true);
            IconWarning = GetIcon.GetBitmapFromEXEDLL(IMAGERESDLL, indexWarning, true);
            IconError = GetIcon.GetBitmapFromEXEDLL(IMAGERESDLL, indexError, true);

            CheckStatus();

            // テーマの設定
            switch (Properties.Settings.Default.UseTheme)
            {
                case "Dark":
                    UseThemeNumber = 0;
                    ThemesItemDark.CheckState = CheckState.Indeterminate;
                    break;
                case "Light":
                    UseThemeNumber = 1;
                    ThemesItemLight.CheckState = CheckState.Indeterminate;
                    break;
                case "SystemSettings":
                default:
                    // レジストリから現在のシステムのテーマ設定を取得
                    using (RegistryKey k = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                    {
                        UseThemeNumber = (int)k.GetValue("AppsUseLightTheme");
                    }
                    ThemesItemSystemSettings.CheckState = CheckState.Indeterminate;
                    break;
            }
            ChangeTheme(UseThemeNumber);
        }

        /// <summary>
        /// ウインドウのテーマを設定します
        /// </summary>
        /// <param name="themeNumber">設定したいテーマの番号</param>
        private void ChangeTheme(int themeNumber)
        {
            switch (themeNumber)
            {
                // ダーク
                case 0:
                    BackColor = Color.FromArgb(32, 32, 32);
                    ForeColor = Color.FromArgb(255, 255, 255);
                    SetupGroup.ForeColor = Color.FromArgb(255, 255, 255);
                    ShowPHP.BackColor = Color.FromArgb(56, 56, 56);
                    ShowKeyConfig.BackColor = Color.FromArgb(56, 56, 56);
                    ServerIO.BackColor = Color.FromArgb(56, 56, 56);
                    VersionInfoLink.LinkColor = Color.FromArgb(126, 170, 255);
                    break;
                // デフォルト
                case 1:
                default:
                    return;
            }
        }

        /// <summary>
        /// php.exeの動作状況に応じてスタート/ストップボタンの表示を切り替えます
        /// </summary>
        private void processMonitoring_Tick()
        {
            Process[] p = Process.GetProcessesByName("php");
            // php.exeが動いていない場合
            if (p.Length <= 0)
            {
                ServerIO.Text = "スタート";
                ShowQRWindow.Enabled = false;
            }
            // php.exeが動いている場合
            else
            {
                ServerIO.Text = "ストップ";
                ShowQRWindow.Enabled = true;
            }
        }

        #region *** 各フォームを呼び出す処理 ***
        private void ShowPHP_Click(object sender, EventArgs e)
        {
            PHP php = new(UseThemeNumber)
            {
                Owner = this
            };
            php.ShowDialog();
            CheckStatus();
        }

        private void ShowKeyConfig_Click(object sender, EventArgs e)
        {
            KeyConfigWindow keyConfigWindow = new(UseThemeNumber)
            {
                Owner = this
            };
            keyConfigWindow.ShowDialog();
            CheckStatus();
        }

        private void ShowVersionInfo_Click(object sender, EventArgs e)
        {
            VersionInfo versionInfo = new(UseThemeNumber)
            {
                Owner = this
            };
            versionInfo.ShowDialog();
        }

        private void ShowQRWindow_Click(object sender, EventArgs e)
        {
            ShowQRCode showQRCode = new(UseThemeNumber)
            {
                Owner = this
            };
            showQRCode.ShowDialog();
        }
        #endregion

        private void ServerIO_Click(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("php");
            // php.exeが動いていない場合起動
            if (p.Length <= 0)
            {
                ProcessStartInfo pInfo = new(phpPath)
                {
                    Arguments = $"-S {Properties.Settings.Default.IPAddress}:{Properties.Settings.Default.PortNumber} -t {Properties.Settings.Default.DocumentRoot}",
                    WindowStyle = ProcessWindowStyle.Minimized
                };
                Process.Start(pInfo);
                ShowQRCode showQRCode = new(UseThemeNumber)
                {
                    Owner = this
                };
                showQRCode.ShowDialog();
            }
            // php.exeが動いている場合終了
            else
            {
                foreach (Process pKill in p)
                {
                    // php.exeをアクティブにし、Ctrl+Cを送信
                    SetForegroundWindow(pKill.MainWindowHandle);
                    SendKeys.SendWait("^(C)");
                }
            }
        }

        /// <summary>
        /// ステータスを確認する関数を呼び出し、結果に応じてボタンの横にアイコンを表示します
        /// ステータスに応じてスタート・ストップボタンのEnabledを制御します
        /// </summary>
        private void CheckStatus()
        {
            int PHPStatusResult = CheckPHPStatus();
            int KeyConfigStatusResult = CheckKeyConfigStatus();
            PHPStatus.Image = PHPStatusResult switch
            {
                0 => IconOk,
                1 => IconWarning,
                -1 => IconError,
                _ => IconError
            };
            KeyConfigStatus.Image = KeyConfigStatusResult switch
            {
                0 => IconOk,
                -1 => IconError,
                _ => IconError
            };
            //ステータスが両方ともOKでない場合はボタンを無効化
            ServerIO.Enabled = PHPStatusResult == 0 && KeyConfigStatusResult == 0;
        }

        /// <summary>
        /// PHPのインストール状況とドキュメントルートのファイルを確認します
        /// </summary>
        /// <returns>ドキュメントルートは正しく設定されているが、PHPを使用しない設定の場合(1)、すべて正しく設定されている場合(0)、それ以外(-1)</returns>
        private int CheckPHPStatus()
        {
            int statusNum = 0;

            // PHPを使用する設定の場合はPHPの実行ファイルを確認する
            if (Properties.Settings.Default.WebServerSoftware == "PHP")
            {
                phpPath = Properties.Settings.Default.UsePATHValue ? "php" : Properties.Settings.Default.PHPExeFilePath;
                ProcessStartInfo processStartInfo = new(phpPath)
                {
                    Arguments = "--version",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                try
                {
                    using Process process = Process.Start(processStartInfo);
                    process.WaitForExit(1000);
                    if (process.ExitCode != 0) { return -1; }
                }
                catch
                {
                    return -1;
                }
            }
            else
            {
                statusNum = 1;
            }

            // ドキュメントルートのファイルチェック
            string indexPath = Path.Combine(Properties.Settings.Default.DocumentRoot, Program.phpFileName);
            if (!File.Exists(indexPath)) { return -1; }
            
            return statusNum;
        }

        /// <summary>
        /// キーコンフィグが正しく設定されているかを確認します
        /// </summary>
        /// <returns>正しく設定されている場合(0)、それ以外(-1)</returns>
        private int CheckKeyConfigStatus()
        {
            ShowKeyConfig.Enabled = Directory.Exists(Properties.Settings.Default.DocumentRoot);
            string csvPath = Path.Combine(Properties.Settings.Default.DocumentRoot, Program.csvFileName);
            if (!File.Exists(csvPath)) { return -1; }

            return 0;
        }

        /// <summary>
        /// テーマ設定のラジオボタンの制御と設定の保存を行います
        /// </summary>
        private void ThemesItem_Click(object sender, EventArgs e)
        {
            ThemesItemSystemSettings.CheckState = CheckState.Unchecked;
            ThemesItemLight.CheckState = CheckState.Unchecked;
            ThemesItemDark.CheckState = CheckState.Unchecked;
            ((ToolStripMenuItem)sender).CheckState = CheckState.Indeterminate;

            switch (((ToolStripMenuItem)sender).Name)
            {
                case "ThemesItemSystemSettings":
                default:
                    Properties.Settings.Default.UseTheme = "SystemSettings";
                    break;
                case "ThemesItemLight":
                    Properties.Settings.Default.UseTheme = "Light";
                    break;
                case "ThemesItemDark":
                    Properties.Settings.Default.UseTheme = "Dark";
                    break;
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("テーマの変更はソフトウェアの再起動後に有効となります。", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
