using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization;

namespace Junk_Drawer
{
    public partial class Form1 : Form
    {
        #region Variables
        public static List<Note> noteList = new List<Note>();
        Label blankLabel = new Label();
        bool treeviewExpanded = false;
        //TrayIcon trayIcon = new TrayIcon();
        ContextMenu nodeContextMenu = new ContextMenu();
        ContextMenu nodeParentContextMenu = new ContextMenu();
        string selectedNode = "";
        public static string encryptionKey = "";
        #endregion

        public Form1()
        {
            InitializeComponent();

            // Initializes icon
            //trayIcon.initializeTrayIcon(this);

            // Configure node context menu
            MenuItem editItem = new MenuItem("Edit");
            editItem.Click += new EventHandler(nodeMenuEdit_Click);
            nodeContextMenu.MenuItems.Add(editItem);

            MenuItem deleteItem = new MenuItem("Delete");
            deleteItem.Click += new EventHandler(nodeMenuDelete_Click);
            nodeContextMenu.MenuItems.Add(deleteItem);

            // Configure node parent context menu
            MenuItem deleteEntireTree = new MenuItem("Delete Entire Tree");
            deleteEntireTree.Click += new EventHandler(nodeParentMenuDelete_Click);
            nodeParentContextMenu.MenuItems.Add(deleteEntireTree);

            // Load notes from XML and collapse all
            initializeNoteListFromXML();
            noteTreeView.CollapseAll();

            blankLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            blankLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            blankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            //blankLabel.Name = "blankLabel";
            blankLabel.Size = new System.Drawing.Size(246, 28);
            blankLabel.Text = "";
            blankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        #region XML Functions
        public static void saveNote(Note note)
        {
            if (!File.Exists("NoteData.xml"))
            {
                File.Create("NoteData.xml").Close();
            }

            FileStream file = File.Create(Environment.CurrentDirectory + "//NoteData.xml");
            noteList.Add(note);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Note>));
            xmlSerializer.Serialize(file, noteList);

            file.Close();
        }

        public static void setXML()
        {
            if (!File.Exists("NoteData.xml"))
            {
                File.Create("NoteData.xml").Close();
            }

            FileStream file = File.Create(Environment.CurrentDirectory + "//NoteData.xml");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Note>));
            xmlSerializer.Serialize(file, noteList);

            file.Close();
        }

        public bool initializeNoteListFromXML()
        {
            if (File.Exists("NoteData.xml"))
            {
                XmlDocument xmlDocument = new XmlDocument();
                
                if (String.IsNullOrWhiteSpace(File.ReadAllText("NoteData.xml")))
                {
                    // The document is empty
                    if(MessageBox.Show("---The XML document is blank. Disregard this warning and press no if there are no notes to begin with; there is nothing to worry about.---\r\n\r\nHowever, if there were notes in this program and you see this warning, send this to Jesse and try replacing your data file with a backup:\r\n\r\n" +
                        "initializeNoteListFromXML failed to return any child nodes at xmlDocument.ChildNodes.Count, indicating an empty document. Check to be sure a stream isn't overwriting the document and it is being read and written correctly.\r\n\r\nWould you like to copy this exception to the clipboard?", 
                        "Blank XML Document", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Clipboard.SetText("initializeNoteListFromXML failed to return any child nodes at xmlDocument.ChildNodes.Count, indicating an empty document. Check to be sure a stream isn't overwriting the document and it is being read and written correctly.");
                    }

                    return false;
                } else
                {
                    // The document has nodes in it
                    xmlDocument.Load("NoteData.xml");
                    List<Note> fallbackNoteList = noteList;
                    try
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Note>));
                        string xmlString = xmlDocument.OuterXml.ToString();

                        using (XmlNodeReader reader = new XmlNodeReader(xmlDocument))
                        {
                            noteList = (List<Note>)serializer.Deserialize(reader);
                        }

                        List<DateTime> dates = new List<DateTime>();

                        foreach (Note note in noteList)
                        {
                            DateTime parsed = new DateTime();

                            if (DateTime.TryParse(note.Date, out parsed))
                            {
                                if (!dates.Contains(parsed))
                                {
                                    // A unique date was found
                                    dates.Add(parsed);
                                }
                            }
                            else
                            {
                                // An invalid date was found
                                MessageBox.Show("Invalid date found! Did the XML get edited?", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }

                        // Sorts ascending - the oldest notes will show up on top
                        dates.Sort((a, b) => a.CompareTo(b));

                        List<TreeNode> parentNodes = new List<TreeNode>();
                        treeviewExpanded = false;
                        noteTreeView.Nodes.Clear();

                        // Adds all date roots by looping through every DateTime and adding it to the TreeView
                        foreach (DateTime date in dates)
                        {
                            TreeNode parentNode = new TreeNode(date.ToString("MM/dd/yy"));

                            foreach (Note note in noteList)
                            {
                                if (note.Date == parentNode.Text)
                                {
                                    parentNode.Nodes.Add(note.Subject);
                                }
                            }
                            noteTreeView.Nodes.Add(parentNode);
                            parentNodes.Add(parentNode);
                        }

                        // Adds subjects by matching the root dates to the note dates
                        foreach (TreeNode parentNode in parentNodes)
                        {
                            foreach (Note note in noteList)
                            {
                                if (note.Date == parentNode.ToString())
                                {
                                    parentNode.Nodes.Add(note.Subject);
                                }
                            }
                        }
                        return true;
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show("Error reading or displaying XML! Was it edited? Show this to Jesse:\r\n" + ex.ToString() + "\r\n\r\nWould you like to copy this exception to the clipboard?", "Invalid XML", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                        {
                            Clipboard.SetText(ex.ToString());
                        }

                        noteList = fallbackNoteList;
                        return false;
                    }
                }
            } else {
                // The XML document was not found
                MessageBox.Show("---XML data form was not found! If this is the first time you've run this program or have recently deleted your data file there is no problem and you can disregard this dialog.---\r\n\r\n" +
                    "Otherwise, you can copy a backup to this program's directory and name it \"NoteData.xml\" to use a previously saved XML form. A blank XML document will now be created.", "XML Data Form Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                File.Create("NoteData.xml").Close();
                return false;
            }
        }
        #endregion

        public class Note : ISerializable
        {
            public string Subject { get; set; }
            public string Date { get; set; }
            public string NoteText { get; set; }
            public bool Encrypted { get; set; }

            public Note() { }

            public Note(string Subject, string Date, string NoteText, bool Encrypted)
            {
                this.Subject = Subject;
                this.Date = Date;
                this.NoteText = NoteText;
                this.Encrypted = Encrypted;
            }

            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("Date", Date);
                info.AddValue("NoteText", NoteText);
            }
        }

        #region Event Handlers
        private void newNoteButton_Click(object sender, EventArgs e)
        {
            // This is a new note it doesn't need any strings to set the fields to
            Note note = new Note("", "", "", false);
            Note_Builder noteBuilder = new Note_Builder(false, note, this);
            noteBuilder.Owner = this;
            noteBuilder.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            initializeNoteListFromXML();
        }

        private void expandCollapseButton_Click(object sender, EventArgs e)
        {
            if (treeviewExpanded)
            {
                noteTreeView.CollapseAll();
                treeviewExpanded = false;
            } else
            {
                noteTreeView.ExpandAll();
                treeviewExpanded = true;
            }
        }

        private void noteTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DateTime parsed = new DateTime();

            // Checks to see if it doesn't parse to a date and has no child nodes - a strong indication that this is not a date node
            if (!DateTime.TryParse(e.Node.Text, out parsed) & (e.Node.Nodes.Count == 0))
            {
                // A date note was not selected
                string subject = e.Node.Text;

                foreach (Note note in noteList.ToArray())
                {
                    if (note.Subject == subject)
                    {
                        if (note.Encrypted)
                        {
                            // Note needs to be decrypted first
                            GetInput gi = new GetInput();
                            gi.Owner = this;
                            gi.ShowDialog();
                        }
                        
                        if (note.Encrypted & String.IsNullOrWhiteSpace(encryptionKey))
                        {
                            // Input form returned an empty string or whitespace
                            MessageBox.Show("Key is blank or whitespace.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } else {
                            // Open note in note builder
                            try
                            {
                                note.NoteText = AES.Decrypt(note.NoteText, encryptionKey);
                                Note_Builder noteBuilder = new Note_Builder(true, note, this);
                                noteBuilder.Owner = this;
                                noteBuilder.ShowDialog();
                            } catch
                            {
                                // Most likely the encryption key was invalid
                                MessageBox.Show("Failed to decrypt note contents. The key is most likely invalid.", "Failed to Decrypt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //trayIcon.diposeAll();
        }

        private void noteTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DateTime parsed = new DateTime();

            if (e.Button == MouseButtons.Right)
            {
                if (!DateTime.TryParse(e.Node.Text, out parsed) & (e.Node.Nodes.Count == 0))
                {
                    // This is almost certainly a child/subject node and not a date node
                    nodeContextMenu.Show(this, new Point(e.X + 10, e.Y + 50));
                    selectedNode = e.Node.Text;
                } else
                {
                    // This is a date note
                    nodeParentContextMenu.Show(this, new Point(e.X + 10, e.Y + 50));
                    selectedNode = e.Node.Text;
                }
            }
            
        }

        private void nodeParentMenuDelete_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete every note inside " + selectedNode + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // Loops through each note and checks to see if its date matches the data of the node
                foreach (Note note in noteList.ToList<Note>())
                {
                    if (note.Date == selectedNode)
                    {
                        noteList.Remove(note);
                    }
                }

                setXML();
                initializeNoteListFromXML();
            }
        }

        private void nodeMenuDelete_Click(object sender, System.EventArgs e)
        {
            foreach (Note note in noteList.ToList<Note>())
            {
                if (note.Subject == selectedNode)
                {
                    noteList.Remove(note);
                    setXML();
                    initializeNoteListFromXML();
                    selectedNode = "";
                    break;
                }
            }
        }

        private void nodeMenuEdit_Click(object sender, System.EventArgs e)
        {
            foreach (Note note in noteList.ToList<Note>())
            {
                if (note.Subject == selectedNode)
                {
                    Note_Builder noteBuilder = new Note_Builder(true, note, this);
                    noteBuilder.Owner = this;
                    noteBuilder.ShowDialog();
                    selectedNode = "";
                    break;
                }
            }
        }

        private void emailManifestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make manifest of all existing notes
            string message = "";
            int counter = 0;

            foreach (Note note in noteList)
            {
                counter++;
                message += "---Note " + counter.ToString() + "---\r\n";
                message += "Subject: " + note.Subject;
                message += "\r\nDate: " + note.Date;
                message += "\r\nNote Text: " + note.NoteText + "\r\n\r\n";
            }

            // Send email
            Email_Sender es = new Email_Sender(message);
            es.Show();
        }

        private void copyManifestToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "";
            int counter = 0;

            foreach (Note note in noteList)
            {
                counter++;
                message += "---Note " + counter.ToString() + "---\r\n";
                message += "Subject: " + note.Subject;
                message += "\r\nDate: " + note.Date;
                message += "\r\nNote Text: " + note.NoteText + "\r\n\r\n";
            }

            if (!String.IsNullOrWhiteSpace(message))
            {
                Clipboard.SetText(message);
            }

            MessageBox.Show("Note manifest copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void connectToServerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}