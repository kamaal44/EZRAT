﻿namespace EZRATClient.Forms
{
    partial class Chat
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
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.tbxMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbMsg
            // 
            this.rtbMsg.BackColor = System.Drawing.Color.DarkGray;
            this.rtbMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMsg.Location = new System.Drawing.Point(0, -1);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.ReadOnly = true;
            this.rtbMsg.Size = new System.Drawing.Size(596, 266);
            this.rtbMsg.TabIndex = 0;
            this.rtbMsg.Text = "";
            // 
            // tbxMsg
            // 
            this.tbxMsg.BackColor = System.Drawing.Color.LightGray;
            this.tbxMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMsg.Location = new System.Drawing.Point(1, 266);
            this.tbxMsg.Name = "tbxMsg";
            this.tbxMsg.Size = new System.Drawing.Size(518, 20);
            this.tbxMsg.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightGray;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(519, 263);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 25);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(597, 290);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxMsg);
            this.Controls.Add(this.rtbMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Chat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Chat";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Windows.Forms.TextBox tbxMsg;
        private System.Windows.Forms.Button btnSend;
    }
}