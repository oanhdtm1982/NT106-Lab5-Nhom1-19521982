using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Security;


namespace Lab5_Nhom1_19521982
{
    public partial class Bai3_Lab5 : Form
    {
        public Bai3_Lab5()
        {
            InitializeComponent();
        }
        public ImapClient client;
        public string name;
        public string password;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                name = tbEmail.Text.ToString().Trim();
                password = tbPassword.Text.ToString().Trim();
                client = new ImapClient();
                client.Connect("127.0.0.1", 143, SecureSocketOptions.None);
                client.Authenticate(name, password);
                Lab05_Bai03_ReadMail Form = new Lab05_Bai03_ReadMail();
                Form.MailUsersName = txtEmail.Text;
                Form.Password = tbPassword.Text;
                Form.Show();
                MessageBox.Show("Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
