using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junk_Drawer
{
    public partial class Note_Builder : Form
    {
        #region Variables
        bool saved = true;
        Form1 form1;
        #endregion

        public Note_Builder(bool isViewer, Form1.Note note, Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            keyField.PasswordChar = '*';
            
            if (!String.IsNullOrWhiteSpace(Form1.encryptionKey))
            {
                keyField.Text = Form1.encryptionKey;
                encryptBox.Checked = true;
            }

            if (isViewer)
            {
                subjectField.Text = note.Subject;
                dateLabel.Text = note.Date;
                noteText.Text = note.NoteText;
                saved = true;
            } else
            {
                dateLabel.Text = DateTime.Today.ToString("MM/dd/yy");
            }
        }

        #region Event Handlers
        private void Note_Builder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved && MessageBox.Show("Are you sure you don't want to save?", "Unsaved Note", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(subjectField.Text) & !String.IsNullOrWhiteSpace(noteText.Text))
            {
                bool executeWrite = true;
                
                // Remove returns from subject
                string subject = subjectField.Text.Replace("\r\n", "");
                
                // Save data to data source here (check for duplicate subjects)
                Form1.Note note = new Form1.Note(subject, dateLabel.Text, noteText.Text, encryptBox.Checked);

                foreach (Form1.Note item in Form1.noteList.ToArray())
                {
                    if (item.Subject == subject)
                    {
                        if (MessageBox.Show("This note subject already exists. Would you like to overwrite it?", "Duplicate Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                            // Overwrite an existing note
                            Form1.noteList.Remove(item);
                            //Form1.noteList.Add(note);
                            break;
                        } else
                        {
                            // User does not wish to overwrite note
                            executeWrite = false;
                        }
                    }
                }

                if (note.Encrypted)
                {
                    if (String.IsNullOrWhiteSpace(keyField.Text))
                    {
                        // Key field is blank
                        executeWrite = false;
                        MessageBox.Show("The note cannot be encrypted with a blank key.", "Failed to Encrypt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Note needs to be encrypted
                        keyField.Text = keyField.Text.Replace("\r\n", "");
                        note.NoteText = AES.Encrypt(note.NoteText, keyField.Text);
                    }
                }

                if (executeWrite)
                {
                    Form1.saveNote(note);
                    form1.initializeNoteListFromXML();
                    // When using static method - Form1.saveNote(note);
                    MessageBox.Show("Note saved!", "Note Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saved = true;
                    Close();
                }
            } else
            {
                MessageBox.Show("Subject or note field cannot be empty.", "Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your note?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string subject = subjectField.Text.Replace("\r\n", "");

                // Save data to data source here (check for duplicate subjects)
                Form1.Note note = new Form1.Note(subject, dateLabel.Text, noteText.Text, encryptBox.Checked);

                foreach (Form1.Note item in Form1.noteList.ToList())
                {
                    if (item.Subject == subject)
                    {
                        Form1.noteList.Remove(item);
                        Form1.setXML();
                        saved = true;
                        form1.initializeNoteListFromXML();
                        Close();
                    }
                }
            }
        }

        private void subjectField_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void noteText_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void showKeyButton_MouseDown(object sender, MouseEventArgs e)
        {
            keyField.PasswordChar = (char)0;
        }

        private void showKeyButton_MouseUp(object sender, MouseEventArgs e)
        {
            keyField.PasswordChar = '*';
        }
        #endregion
    }
}