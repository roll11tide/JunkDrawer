namespace Junk_Drawer
{
    partial class GetInput
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputField = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.showKeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputLabel.Location = new System.Drawing.Point(12, 9);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(64, 23);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Key";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(82, 10);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(201, 20);
            this.inputField.TabIndex = 2;
            this.inputField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputField_KeyPress);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.submitButton.Location = new System.Drawing.Point(16, 36);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(228, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.closeButton.Location = new System.Drawing.Point(250, 36);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(62, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // showKeyButton
            // 
            this.showKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.showKeyButton.Location = new System.Drawing.Point(289, 10);
            this.showKeyButton.Name = "showKeyButton";
            this.showKeyButton.Size = new System.Drawing.Size(23, 20);
            this.showKeyButton.TabIndex = 12;
            this.showKeyButton.Text = "~";
            this.showKeyButton.UseVisualStyleBackColor = true;
            this.showKeyButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showKeyButton_MouseDown);
            this.showKeyButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showKeyButton_MouseUp);
            // 
            // GetInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 63);
            this.Controls.Add(this.showKeyButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.inputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GetInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button showKeyButton;
    }
}