using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Mail;
using System.Windows.Forms;

namespace Junk_Drawer
{
    public partial class Email_Sender : Form
    {
        public Email_Sender(string defaultEmailText)
        {
            InitializeComponent();
            if (!String.IsNullOrWhiteSpace(defaultEmailText))
            {
                // Fill in body only if it is not whitespace
                emailText.Text = defaultEmailText;
            }
        }

        public static void sendEmail(string senderAddress, string recipientAddress, string emailSubject, string messageText, string gmailPassword)
        {
            SmtpClient client = new SmtpClient();
            MailMessage message = new MailMessage(senderAddress, recipientAddress);
            message.Body = messageText;
            message.Subject = emailSubject;
            client.SendCompleted += new SendCompletedEventHandler(emailCallback);
            client.Host = "smtp.gmail.com";
            client.Credentials = new System.Net.NetworkCredential(senderAddress, gmailPassword);
            client.Port = 587;
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.Send(message);
        }

        private static void emailCallback(object sender, AsyncCompletedEventArgs e)
        {
            string token = (string)e.UserState;

            if (e.Cancelled)
            {
                MessageBox.Show("The email sending operation was cancelled.", "Email Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.Error != null)
            {
                MessageBox.Show("There was an error sending the email. If you believe there is something wrong internally, tell a programmer.\r\n\r\n---BEGIN DEBUG DUMP---\r\n" + e.Error.ToString());
            }
            else
            {
                MessageBox.Show("Message sent.", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (verifyFields())
            {
                bool proceedWhileBlank = false;
                if (String.IsNullOrWhiteSpace(emailText.Text))
                {
                    if(MessageBox.Show("The email body is blank or whitespace. Would you like to send the email anyway?", "Email Is Blank", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        proceedWhileBlank = true;
                    }
                }

                // If the email body is not blank or if it is blank and the textbox result returned yes, proceed with sending the email
                if (!String.IsNullOrWhiteSpace(emailText.Text) | proceedWhileBlank)
                {
                    sendEmail(senderField.Text, recipientField.Text, subjectField.Text, emailText.Text, passwordField.Text);
                }
            } else
            {
                MessageBox.Show("Invalid fields.", "Cannot Send", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool verifyFields()
        {
            if (!senderField.Text.Contains("@"))
            {
                // Sender field is missing an "@" and therefore cannot be an email address
                return false;
            }

            if (!recipientField.Text.Contains("@"))
            {
                // Recipient field is missing an "@" and therefore cannot be an email address
                return false;
            }

            if (String.IsNullOrWhiteSpace(subjectField.Text) | String.IsNullOrWhiteSpace(senderField.Text) | String.IsNullOrWhiteSpace(recipientField.Text) | String.IsNullOrWhiteSpace(passwordField.Text))
            {
                return false;
            }

            return true;
        }
    }
}