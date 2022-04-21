namespace Junk_Drawer
{
    partial class Email_Sender
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
            this.label1 = new System.Windows.Forms.Label();
            this.subjectField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.senderField = new System.Windows.Forms.TextBox();
            this.recipientField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(222, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subjectField
            // 
            this.subjectField.Location = new System.Drawing.Point(310, 12);
            this.subjectField.Multiline = true;
            this.subjectField.Name = "subjectField";
            this.subjectField.Size = new System.Drawing.Size(232, 23);
            this.subjectField.TabIndex = 2;
            this.subjectField.Text = "Note Manifest";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(222, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sender";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // senderField
            // 
            this.senderField.Location = new System.Drawing.Point(310, 41);
            this.senderField.Multiline = true;
            this.senderField.Name = "senderField";
            this.senderField.Size = new System.Drawing.Size(232, 23);
            this.senderField.TabIndex = 4;
            // 
            // recipientField
            // 
            this.recipientField.Location = new System.Drawing.Point(310, 70);
            this.recipientField.Multiline = true;
            this.recipientField.Name = "recipientField";
            this.recipientField.Size = new System.Drawing.Size(232, 23);
            this.recipientField.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(222, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recipient";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(16, 99);
            this.emailText.Multiline = true;
            this.emailText.Name = "emailText";
            this.emailText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.emailText.Size = new System.Drawing.Size(526, 153);
            this.emailText.TabIndex = 8;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sendButton.Location = new System.Drawing.Point(16, 12);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(200, 52);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Send Email";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(100, 70);
            this.passwordField.Multiline = true;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(116, 23);
            this.passwordField.TabIndex = 11;
            // 
            // Email_Sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 264);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.recipientField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.senderField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectField);
            this.Controls.Add(this.label1);
            this.Name = "Email_Sender";
            this.Text = "Email Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senderField;
        private System.Windows.Forms.TextBox recipientField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordField;
    }
}