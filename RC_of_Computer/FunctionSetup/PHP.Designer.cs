﻿namespace RC_of_Computer.FunctionSetup
{
    partial class PHP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsItem1 = new System.Windows.Forms.Label();
            this.RunPHPSetup = new System.Windows.Forms.Button();
            this.UsePATHValue = new System.Windows.Forms.CheckBox();
            this.AdvancedSettings = new System.Windows.Forms.GroupBox();
            this.SettingsItem5 = new System.Windows.Forms.Label();
            this.SettingsItem4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SettingsItem2 = new System.Windows.Forms.Label();
            this.DocumentRootRef = new System.Windows.Forms.Button();
            this.DocumentRootPath = new System.Windows.Forms.TextBox();
            this.SettingsItem3 = new System.Windows.Forms.Label();
            this.PHPRef = new System.Windows.Forms.Button();
            this.PortNumber = new System.Windows.Forms.TextBox();
            this.IPaddress = new System.Windows.Forms.TextBox();
            this.PHPPath = new System.Windows.Forms.TextBox();
            this.PHPStatus = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.AdvancedSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsItem1
            // 
            this.SettingsItem1.AutoSize = true;
            this.SettingsItem1.Location = new System.Drawing.Point(10, 24);
            this.SettingsItem1.Name = "SettingsItem1";
            this.SettingsItem1.Size = new System.Drawing.Size(122, 15);
            this.SettingsItem1.TabIndex = 2;
            this.SettingsItem1.Text = "Webサーバーソフトウェア";
            // 
            // RunPHPSetup
            // 
            this.RunPHPSetup.Location = new System.Drawing.Point(15, 30);
            this.RunPHPSetup.Name = "RunPHPSetup";
            this.RunPHPSetup.Size = new System.Drawing.Size(170, 25);
            this.RunPHPSetup.TabIndex = 1;
            this.RunPHPSetup.Text = "PHPの自動セットアップ";
            this.RunPHPSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RunPHPSetup.UseVisualStyleBackColor = true;
            this.RunPHPSetup.Click += new System.EventHandler(this.RunPHPSetup_Click);
            // 
            // UsePATHValue
            // 
            this.UsePATHValue.AutoSize = true;
            this.UsePATHValue.Location = new System.Drawing.Point(200, 76);
            this.UsePATHValue.Name = "UsePATHValue";
            this.UsePATHValue.Size = new System.Drawing.Size(148, 19);
            this.UsePATHValue.TabIndex = 25;
            this.UsePATHValue.Text = "環境変数の値を使用する";
            this.UsePATHValue.UseVisualStyleBackColor = true;
            // 
            // AdvancedSettings
            // 
            this.AdvancedSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvancedSettings.Controls.Add(this.SettingsItem5);
            this.AdvancedSettings.Controls.Add(this.SettingsItem4);
            this.AdvancedSettings.Controls.Add(this.comboBox1);
            this.AdvancedSettings.Controls.Add(this.SettingsItem2);
            this.AdvancedSettings.Controls.Add(this.DocumentRootRef);
            this.AdvancedSettings.Controls.Add(this.DocumentRootPath);
            this.AdvancedSettings.Controls.Add(this.SettingsItem3);
            this.AdvancedSettings.Controls.Add(this.PHPRef);
            this.AdvancedSettings.Controls.Add(this.PortNumber);
            this.AdvancedSettings.Controls.Add(this.IPaddress);
            this.AdvancedSettings.Controls.Add(this.PHPPath);
            this.AdvancedSettings.Controls.Add(this.SettingsItem1);
            this.AdvancedSettings.Controls.Add(this.UsePATHValue);
            this.AdvancedSettings.Location = new System.Drawing.Point(12, 65);
            this.AdvancedSettings.Name = "AdvancedSettings";
            this.AdvancedSettings.Size = new System.Drawing.Size(580, 193);
            this.AdvancedSettings.TabIndex = 2;
            this.AdvancedSettings.TabStop = false;
            this.AdvancedSettings.Text = "詳細設定 (PHPの自動セットアップを使用する場合は変更しないでください)";
            // 
            // SettingsItem5
            // 
            this.SettingsItem5.AutoSize = true;
            this.SettingsItem5.Location = new System.Drawing.Point(13, 169);
            this.SettingsItem5.Name = "SettingsItem5";
            this.SettingsItem5.Size = new System.Drawing.Size(59, 15);
            this.SettingsItem5.TabIndex = 0;
            this.SettingsItem5.Text = "ポート番号";
            // 
            // SettingsItem4
            // 
            this.SettingsItem4.AutoSize = true;
            this.SettingsItem4.Location = new System.Drawing.Point(13, 140);
            this.SettingsItem4.Name = "SettingsItem4";
            this.SettingsItem4.Size = new System.Drawing.Size(54, 15);
            this.SettingsItem4.TabIndex = 0;
            this.SettingsItem4.Text = "IPアドレス";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PHPのビルトインウェブサーバーを使用する",
            "Nginx、Apacheなどを使用する"});
            this.comboBox1.Location = new System.Drawing.Point(200, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(367, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // SettingsItem2
            // 
            this.SettingsItem2.AutoSize = true;
            this.SettingsItem2.Location = new System.Drawing.Point(10, 54);
            this.SettingsItem2.Name = "SettingsItem2";
            this.SettingsItem2.Size = new System.Drawing.Size(117, 15);
            this.SettingsItem2.TabIndex = 0;
            this.SettingsItem2.Text = "PHP実行ファイルのパス";
            // 
            // DocumentRootRef
            // 
            this.DocumentRootRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentRootRef.Location = new System.Drawing.Point(538, 100);
            this.DocumentRootRef.Name = "DocumentRootRef";
            this.DocumentRootRef.Size = new System.Drawing.Size(29, 23);
            this.DocumentRootRef.TabIndex = 35;
            this.DocumentRootRef.UseVisualStyleBackColor = true;
            // 
            // DocumentRootPath
            // 
            this.DocumentRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentRootPath.Location = new System.Drawing.Point(200, 101);
            this.DocumentRootPath.Name = "DocumentRootPath";
            this.DocumentRootPath.Size = new System.Drawing.Size(332, 23);
            this.DocumentRootPath.TabIndex = 30;
            // 
            // SettingsItem3
            // 
            this.SettingsItem3.AutoSize = true;
            this.SettingsItem3.Location = new System.Drawing.Point(10, 104);
            this.SettingsItem3.Name = "SettingsItem3";
            this.SettingsItem3.Size = new System.Drawing.Size(86, 15);
            this.SettingsItem3.TabIndex = 0;
            this.SettingsItem3.Text = "ドキュメントルート";
            // 
            // PHPRef
            // 
            this.PHPRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PHPRef.Location = new System.Drawing.Point(538, 50);
            this.PHPRef.Name = "PHPRef";
            this.PHPRef.Size = new System.Drawing.Size(29, 23);
            this.PHPRef.TabIndex = 20;
            this.PHPRef.UseVisualStyleBackColor = true;
            // 
            // PortNumber
            // 
            this.PortNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortNumber.Location = new System.Drawing.Point(200, 161);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(180, 23);
            this.PortNumber.TabIndex = 45;
            // 
            // IPaddress
            // 
            this.IPaddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPaddress.Location = new System.Drawing.Point(200, 132);
            this.IPaddress.Name = "IPaddress";
            this.IPaddress.Size = new System.Drawing.Size(180, 23);
            this.IPaddress.TabIndex = 40;
            // 
            // PHPPath
            // 
            this.PHPPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PHPPath.Location = new System.Drawing.Point(200, 51);
            this.PHPPath.Name = "PHPPath";
            this.PHPPath.Size = new System.Drawing.Size(332, 23);
            this.PHPPath.TabIndex = 15;
            // 
            // PHPStatus
            // 
            this.PHPStatus.AutoSize = true;
            this.PHPStatus.Location = new System.Drawing.Point(12, 10);
            this.PHPStatus.Name = "PHPStatus";
            this.PHPStatus.Size = new System.Drawing.Size(167, 15);
            this.PHPStatus.TabIndex = 4;
            this.PHPStatus.Text = "PHPセットアップ済 / 未セットアップ";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(341, 264);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 30);
            this.OK.TabIndex = 50;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(427, 264);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 30);
            this.Cancel.TabIndex = 55;
            this.Cancel.Text = "キャンセル";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(513, 264);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(80, 30);
            this.Apply.TabIndex = 60;
            this.Apply.Text = "適用";
            this.Apply.UseVisualStyleBackColor = true;
            // 
            // PHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(604, 299);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PHPStatus);
            this.Controls.Add(this.AdvancedSettings);
            this.Controls.Add(this.RunPHPSetup);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaximizeBox = false;
            this.Name = "PHP";
            this.Text = "PHP設定";
            this.AdvancedSettings.ResumeLayout(false);
            this.AdvancedSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsItem1;
        private System.Windows.Forms.Button RunPHPSetup;
        private System.Windows.Forms.CheckBox UsePATHValue;
        private System.Windows.Forms.GroupBox AdvancedSettings;
        private System.Windows.Forms.Label PHPStatus;
        private System.Windows.Forms.TextBox PHPPath;
        private System.Windows.Forms.Button PHPRef;
        private System.Windows.Forms.Label SettingsItem3;
        private System.Windows.Forms.Button DocumentRootRef;
        private System.Windows.Forms.TextBox DocumentRootPath;
        private System.Windows.Forms.Label SettingsItem2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label SettingsItem5;
        private System.Windows.Forms.Label SettingsItem4;
        private System.Windows.Forms.TextBox PortNumber;
        private System.Windows.Forms.TextBox IPaddress;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Apply;
    }
}