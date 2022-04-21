using System;
using System.Windows.Forms;

namespace Junk_Drawer
{
    public partial class GetInput : Form
    {
        public GetInput()
        {
            InitializeComponent();
            inputField.PasswordChar = '*';
        }

        private void fireInput()
        {
            if (String.IsNullOrWhiteSpace(inputField.Text))
            {
                // The key is blank or whitespace
                MessageBox.Show("The key cannot be blank.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                inputField.Text = inputField.Text.Replace("\r\n", "");
                Form1.encryptionKey = inputField.Text;
                Close();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            fireInput();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form1.encryptionKey = "";
            Close();
        }

        private void showKeyButton_MouseDown(object sender, MouseEventArgs e)
        {
            inputField.PasswordChar = (char)0;
        }

        private void showKeyButton_MouseUp(object sender, MouseEventArgs e)
        {
            inputField.PasswordChar = '*';
        }

        private void inputField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                fireInput();
            }
        }
    }
}