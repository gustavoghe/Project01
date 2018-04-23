using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web;
using System.Net.Mail;

using System.IO;

namespace EmailSenderV01
{
    public partial class Form1 : Form
    {

        public string login = "gustavoghe@gmail.com";
        public string smtp = "smtp.gmail.com";
        public string port = "587";




        public Form1()
        {
            InitializeComponent();

            txtpassword.PasswordChar = '*';

            txtlogin.Text = login;
            txtfrom.Text = login;
            txtsmtp.Text = smtp;
            txtport.Text = port;
           

        }

        private void btnsend_Click(object sender, EventArgs e)
        {           

            MailMessage mail = new MailMessage(txtfrom.Text, txtto.Text, txtsubject.Text, txtbody.Text);

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(txtfilepath.Text);
            mail.Attachments.Add(attachment);

            SmtpClient client = new SmtpClient(txtsmtp.Text); //smtp.gmail.com

            client.Port = 587; // port 587
            client.Credentials = new System.Net.NetworkCredential(txtlogin.Text, txtpassword.Text);

            

            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Operation Suceeded");
        }

        

        private void btnsendtolist_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Resource\Data0X.txt";

            List<Contact> Mailing = new List<Contact>();

            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Contact Person = new Contact();
                Person.Name = entries[0];
                Person.Url = entries[1];

                Mailing.Add(Person);
            }


            foreach (var contact in Mailing)
            {
                string receiver = contact.Url.ToString();

                MailMessage mail = new MailMessage(txtfrom.Text, receiver, txtsubject.Text, txtbody.Text);

                SmtpClient client = new SmtpClient(txtsmtp.Text); //smtp.gmail.com

                client.Port = 587; // port 587
                client.Credentials = new System.Net.NetworkCredential(txtlogin.Text, txtpassword.Text);

                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Operation Suceeded");

            }

        }

        private void btnbrowsefile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtfilepath.Text = openFileDialog1.FileName;
            }
        }

        private void btnloadtext_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                txtbody.LoadFile(openFile1.FileName);
            }
        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            txtbody.Rtf = txtbody.Rtf.Replace("xname", txtreplace.Text);
        }
    }
}
