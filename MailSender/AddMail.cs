using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSender {
    public partial class AddMail : Form {
        private Form1 MainForm;
        public AddMail(Form1 mainForm) {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void Cantel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SaveCSV() {
            try {
                using (StreamWriter outputFile = new StreamWriter("emails.csv")) {
                    foreach (ListViewItem item in MainForm.GetMails().Items)
                        outputFile.WriteLine(item.SubItems[0].Text);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void AddNewMail_Click(object sender, EventArgs e) {
            if (emailBox.Text != "") {
                MainForm.GetMails().Items.Add(emailBox.Text);
                SaveCSV();
                MainForm.Send(emailBox.Text);
                this.Close();
            }
        }
    }
}
