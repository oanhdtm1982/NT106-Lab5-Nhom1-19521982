using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Lab5_Nhom1_19521982
{
    public partial class Bai3_Lab5_SendMail : Form
    {
        private string _mail;
        private string _password;
        public Bai3_Lab5_SendMail()
        {
            InitializeComponent();
        }
        public string MailUsersName
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private void Lab05_Bai03_SendMail_Load(object sender, EventArgs e)
        {
            tbEmail.Text = _mail;
            tbPassword.Text = _password;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = tbEmail.Text.ToString().Trim();
                string mailto = tbTo.Text.ToString().Trim();
                string password = tbPassword.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = tbSubject.Text.ToString().Trim();
                    message.IsBodyHtml = false;
                    message.Body = tbBody.Text.ToString();
                    message.To.Add(mailto);
                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Successfully sent!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Username or Password or is Incorrect!");
                    }
                }
            }
        }
    }
}
