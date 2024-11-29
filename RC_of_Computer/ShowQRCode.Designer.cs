﻿namespace RC_of_Computer
{
    partial class ShowQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowQRCode));
            this.QRPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QRPictureBox
            // 
            this.QRPictureBox.Location = new System.Drawing.Point(14, 15);
            this.QRPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QRPictureBox.Name = "QRPictureBox";
            this.QRPictureBox.Size = new System.Drawing.Size(233, 250);
            this.QRPictureBox.TabIndex = 0;
            this.QRPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "QRコードを読み取るか、ブラウザのアドレスバーに次のURLを入力してアクセスしてください";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(648, 236);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(88, 29);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(257, 46);
            this.URLTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.ReadOnly = true;
            this.URLTextBox.Size = new System.Drawing.Size(223, 23);
            this.URLTextBox.TabIndex = 4;
            this.URLTextBox.Text = "http://x.x.x.x:8000";
            // 
            // ShowQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(741, 272);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QRPictureBox);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowQRCode";
            this.Text = "ShowQRCode";
            ((System.ComponentModel.ISupportInitialize)(this.QRPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox URLTextBox;
    }
}