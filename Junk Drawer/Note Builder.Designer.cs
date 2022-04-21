namespace Junk_Drawer
{
    partial class Note_Builder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note_Builder));
            this.label1 = new System.Windows.Forms.Label();
            this.subjectField = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.noteText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.discardButton = new System.Windows.Forms.Button();
            this.encryptBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.keyField = new System.Windows.Forms.TextBox();
            this.showKeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subjectField
            // 
            this.subjectField.Location = new System.Drawing.Point(12, 32);
            this.subjectField.Name = "subjectField";
            this.subjectField.Size = new System.Drawing.Size(232, 20);
            this.subjectField.TabIndex = 1;
            this.subjectField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subjectField.TextChanged += new System.EventHandler(this.subjectField_TextChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateLabel.Location = new System.Drawing.Point(250, 35);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 20);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "0/0/0";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(12, 87);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(472, 242);
            this.noteText.TabIndex = 3;
            this.noteText.TextChanged += new System.EventHandler(this.noteText_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.saveButton.Location = new System.Drawing.Point(356, 9);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(128, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Note";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discardButton
            // 
            this.discardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.discardButton.Location = new System.Drawing.Point(356, 32);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(128, 23);
            this.discardButton.TabIndex = 6;
            this.discardButton.Text = "Discard Note";
            this.discardButton.UseVisualStyleBackColor = true;
            this.discardButton.Click += new System.EventHandler(this.discardButton_Click);
            // 
            // encryptBox
            // 
            this.encryptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.encryptBox.Location = new System.Drawing.Point(12, 58);
            this.encryptBox.Name = "encryptBox";
            this.encryptBox.Size = new System.Drawing.Size(86, 26);
            this.encryptBox.TabIndex = 8;
            this.encryptBox.Text = "Encrypt";
            this.encryptBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(104, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Key:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyField
            // 
            this.keyField.Location = new System.Drawing.Point(154, 62);
            this.keyField.Name = "keyField";
            this.keyField.Size = new System.Drawing.Size(301, 20);
            this.keyField.TabIndex = 10;
            this.keyField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showKeyButton
            // 
            this.showKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.showKeyButton.Location = new System.Drawing.Point(461, 62);
            this.showKeyButton.Name = "showKeyButton";
            this.showKeyButton.Size = new System.Drawing.Size(23, 20);
            this.showKeyButton.TabIndex = 11;
            this.showKeyButton.Text = "~";
            this.showKeyButton.UseVisualStyleBackColor = true;
            this.showKeyButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showKeyButton_MouseDown);
            this.showKeyButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showKeyButton_MouseUp);
            // 
            // Note_Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 341);
            this.Controls.Add(this.showKeyButton);
            this.Controls.Add(this.keyField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptBox);
            this.Controls.Add(this.discardButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.subjectField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Note_Builder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Junk Drawer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Note_Builder_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectField;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button discardButton;
        private System.Windows.Forms.CheckBox encryptBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyField;
        private System.Windows.Forms.Button showKeyButton;
    }
}