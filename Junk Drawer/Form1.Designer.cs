namespace Junk_Drawer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newNoteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.noteTreeView = new System.Windows.Forms.TreeView();
            this.expandCollapseButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyManifestToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newNoteButton
            // 
            this.newNoteButton.Location = new System.Drawing.Point(252, 27);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(92, 23);
            this.newNoteButton.TabIndex = 1;
            this.newNoteButton.Text = "New Note";
            this.newNoteButton.UseVisualStyleBackColor = true;
            this.newNoteButton.Click += new System.EventHandler(this.newNoteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 27);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(92, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // noteTreeView
            // 
            this.noteTreeView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.noteTreeView.Location = new System.Drawing.Point(0, 56);
            this.noteTreeView.Name = "noteTreeView";
            this.noteTreeView.Size = new System.Drawing.Size(356, 395);
            this.noteTreeView.TabIndex = 3;
            this.noteTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.noteTreeView_NodeMouseClick);
            this.noteTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.noteTreeView_NodeMouseDoubleClick);
            // 
            // expandCollapseButton
            // 
            this.expandCollapseButton.Location = new System.Drawing.Point(121, 27);
            this.expandCollapseButton.Name = "expandCollapseButton";
            this.expandCollapseButton.Size = new System.Drawing.Size(114, 23);
            this.expandCollapseButton.TabIndex = 4;
            this.expandCollapseButton.Text = "Expand/Collapse All";
            this.expandCollapseButton.UseVisualStyleBackColor = true;
            this.expandCollapseButton.Click += new System.EventHandler(this.expandCollapseButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyManifestToClipboardToolStripMenuItem,
            this.emailManifestToolStripMenuItem,
            this.connectToServerToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // copyManifestToClipboardToolStripMenuItem
            // 
            this.copyManifestToClipboardToolStripMenuItem.Name = "copyManifestToClipboardToolStripMenuItem";
            this.copyManifestToClipboardToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.copyManifestToClipboardToolStripMenuItem.Text = "Clipboard Manifest";
            this.copyManifestToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyManifestToClipboardToolStripMenuItem_Click);
            // 
            // emailManifestToolStripMenuItem
            // 
            this.emailManifestToolStripMenuItem.Name = "emailManifestToolStripMenuItem";
            this.emailManifestToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.emailManifestToolStripMenuItem.Text = "Email Manifest...";
            this.emailManifestToolStripMenuItem.Click += new System.EventHandler(this.emailManifestToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // connectToServerToolStripMenuItem
            // 
            this.connectToServerToolStripMenuItem.Name = "connectToServerToolStripMenuItem";
            this.connectToServerToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.connectToServerToolStripMenuItem.Text = "Connect to Server...";
            this.connectToServerToolStripMenuItem.Click += new System.EventHandler(this.connectToServerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(356, 451);
            this.Controls.Add(this.expandCollapseButton);
            this.Controls.Add(this.noteTreeView);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Junk Drawer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newNoteButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TreeView noteTreeView;
        private System.Windows.Forms.Button expandCollapseButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailManifestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyManifestToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToServerToolStripMenuItem;
    }
}

