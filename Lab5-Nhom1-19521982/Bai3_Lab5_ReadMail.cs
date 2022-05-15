using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;

namespace Lab5_Nhom1_19521982
{
    public partial class Bai3_Lab5_ReadMail : Form
    {
        private string _mail;
        private string _password;
        public Bai3_Lab5_ReadMail()
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

        private void Lab05_Bai03_ReadMail_Load(object sender, EventArgs e)
        {
            tbEmail.Text = _mail;
            tbPassword.Text = _password;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("127.0.0.1", 143, SecureSocketOptions.None);
                    client.Authenticate(tbEmail.Text.ToString().Trim(), tbPassword.Text.ToString().Trim());
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    lbTotalMail.Text = inbox.Count.ToString();
                    lbRecentTotal.Text = inbox.Recent.ToString();
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem name = new ListViewItem(message.Subject);
                        ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                        name.SubItems.Add(from);
                        ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                        name.SubItems.Add(date);
                        listView.Items.Add(name);
                    }
                    client.Disconnect(true);
                    MessageBox.Show("Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            Bai3_Lab5_SendMail Form = new Bai3_Lab5_SendMail();
            Form.MailUsersName = tbEmail.Text;
            Form.Password = tbPassword.Text;
            Form.Show();
        }
    }
}
