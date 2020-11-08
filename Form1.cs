using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class Form1 : Form
    {
        private List<string> allFiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void sendBTN_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void selectFileBTN_Click(object sender, EventArgs e)
        {
            SelectFile();
            notselectedLBL.Visible = false; selectedLBL.Visible = true;
        }

        private void clearFileBTN_Click(object sender, EventArgs e)
        {
            allFiles = new List<string>();
            notselectedLBL.Visible = true; selectedLBL.Visible = false;
        }

        public void SendMessage()
        {
            string mailFrom = mailFromTXT.Text;
            string mailTo = mailToTXT.Text;
            string mailPassword = passwordTXT.Text;

            string mailSubject = subjectTXT.Text;
            string mailBody = bodyTXT.Text;
            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                SmtpClient client;

                if (mailFrom.Contains("gmail")) { client = new SmtpClient("smtp.gmail.com", 587); }
                else if (mailFrom.Contains("yandex")) { client = new SmtpClient("smtp.yandex.com.tr", 587); }
                else { client = new SmtpClient("smtp.live.com", 587); }

                mail.From = new MailAddress(mailFrom);
                mail.To.Add(mailTo);

                mail.Subject = mailSubject;
                mail.Body = mailBody;
                
                foreach (var file in allFiles)
                {
                    System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(file);
                    mail.Attachments.Add(attachment);
                }

                client.UseDefaultCredentials = true;
                client.Credentials = new System.Net.NetworkCredential(mailFrom, mailPassword);
                client.EnableSsl = true;

                client.Send(mail);

                MessageBox.Show("OK!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SelectFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                Multiselect = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            allFiles = new List<string>();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    allFiles.Add(file);
                }
            }
        }

        
    }
}
