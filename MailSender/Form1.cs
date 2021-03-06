﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSender {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            ReadCSV();
            ReadLogs();
        }

        public ListView GetMails() {
            return ListAllMails;
        }

        void SaveLogs() {
            try {
                using (StreamWriter outputFile = new StreamWriter("Logs.txt")) {
                    foreach (ListViewItem item in ListSendedMails.Items)
                        outputFile.WriteLine(item.SubItems[0].Text);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void ReadLogs() {
            try {   // Open the text file using a stream reader.
                ListSendedMails.Clear();
                using (StreamReader sr = new StreamReader("Logs.txt")) {
                    // Read the stream to a string, and write the string to the console.
                    while (!sr.EndOfStream) {
                        ListViewItem line = new ListViewItem(sr.ReadLine());
                        ListSendedMails.Items.Add(line);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }

        private void ReadCSV() {
            try {   // Open the text file using a stream reader.
                ListAllMails.Clear();
                using (StreamReader sr = new StreamReader("emails.csv")) {
                    // Read the stream to a string, and write the string to the console.
                    while (!sr.EndOfStream) {
                        ListViewItem line = new ListViewItem(sr.ReadLine());
                        ListAllMails.Items.Add(line);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }

        private void LoadCSV_Click(object sender, EventArgs e) {
            ReadCSV();
        }

        private void SendMail_Click(object sender, EventArgs e) {
            try {
                foreach (ListViewItem item in ListAllMails.Items) {
                    Send(item.SubItems[0].Text);
                    ListSendedMails.Items.Add(item.SubItems[0].Text);
                }
                SaveLogs();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Send(string address) {
            try {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("mailforath123@gmail.com");
                mail.To.Add(address);
                mail.Subject = "Test Mail";
                mail.IsBodyHtml = true;
                mail.Body = "<html><h1>Hello</h1><br /><p>Najlepsze życzenia z okazji świąt</p></html>";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("mailforath123@gmail.com", "lukasz123");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddMailButton_Click(object sender, EventArgs e) {
            AddMail AddMailForm = new MailSender.AddMail(this);
            AddMailForm.Show();
        }
    }
}

