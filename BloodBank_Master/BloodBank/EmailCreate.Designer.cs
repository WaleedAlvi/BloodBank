﻿namespace BloodBank
{
    partial class EmailCreate
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
            this.sendbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjbox = new System.Windows.Forms.TextBox();
            this.msgbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendbtn
            // 
            this.sendbtn.BackColor = System.Drawing.Color.PowderBlue;
            this.sendbtn.Location = new System.Drawing.Point(270, 247);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 23);
            this.sendbtn.TabIndex = 1;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = false;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message";
            // 
            // subjbox
            // 
            this.subjbox.Location = new System.Drawing.Point(102, 49);
            this.subjbox.Name = "subjbox";
            this.subjbox.Size = new System.Drawing.Size(307, 22);
            this.subjbox.TabIndex = 2;
            // 
            // msgbox
            // 
            this.msgbox.Location = new System.Drawing.Point(102, 103);
            this.msgbox.Multiline = true;
            this.msgbox.Name = "msgbox";
            this.msgbox.Size = new System.Drawing.Size(307, 106);
            this.msgbox.TabIndex = 6;
            // 
            // EmailCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(466, 306);
            this.Controls.Add(this.msgbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjbox);
            this.Controls.Add(this.sendbtn);
            this.Name = "EmailCreate";
            this.Text = "EmailCreate";
            this.Load += new System.EventHandler(this.EmailCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjbox;
        private System.Windows.Forms.TextBox msgbox;
    }
}