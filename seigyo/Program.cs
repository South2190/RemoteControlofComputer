﻿using System;
using System.Windows.Forms;

namespace seigyo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("引数が指定されていません");
                Environment.ExitCode = -1;   //終了コード
            }
            else
            {
                switch (args[0])
                {
                    case "-k":
                    case "--KeyPress":
                        try
                        {
                            SendKeys.SendWait(args[1]);
                        }
                        catch
                        {
                            Console.WriteLine("エラーが発生しました");
                            Environment.ExitCode = -2;   //終了コード
                        }
                        break;
                    default:
                        Console.WriteLine("引数が指定されていません");
                        Environment.ExitCode = -1;   //終了コード
                        break;
                }
            }
            Application.Exit();
        }
    }
}
