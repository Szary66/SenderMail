namespace MailSender {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LoadCSV = new System.Windows.Forms.Button();
            this.ListAllMails = new System.Windows.Forms.ListView();
            this.AddMailButton = new System.Windows.Forms.Button();
            this.AllMails = new System.Windows.Forms.Label();
            this.SendedMails = new System.Windows.Forms.Label();
            this.SendMail = new System.Windows.Forms.Button();
            this.ListSendedMails = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LoadCSV
            // 
            this.LoadCSV.Location = new System.Drawing.Point(12, 296);
            this.LoadCSV.Name = "LoadCSV";
            this.LoadCSV.Size = new System.Drawing.Size(75, 23);
            this.LoadCSV.TabIndex = 0;
            this.LoadCSV.Text = "Load";
            this.LoadCSV.UseVisualStyleBackColor = true;
            this.LoadCSV.Click += new System.EventHandler(this.LoadCSV_Click);
            // 
            // ListAllMails
            // 
            this.ListAllMails.FullRowSelect = true;
            this.ListAllMails.GridLines = true;
            this.ListAllMails.HideSelection = false;
            this.ListAllMails.LabelEdit = true;
            this.ListAllMails.Location = new System.Drawing.Point(12, 35);
            this.ListAllMails.MinimumSize = new System.Drawing.Size(152, 238);
            this.ListAllMails.Name = "ListAllMails";
            this.ListAllMails.Size = new System.Drawing.Size(173, 238);
            this.ListAllMails.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListAllMails.TabIndex = 1;
            this.ListAllMails.UseCompatibleStateImageBehavior = false;
            this.ListAllMails.View = System.Windows.Forms.View.List;
            // 
            // AddMailButton
            // 
            this.AddMailButton.Location = new System.Drawing.Point(93, 296);
            this.AddMailButton.Name = "AddMailButton";
            this.AddMailButton.Size = new System.Drawing.Size(75, 23);
            this.AddMailButton.TabIndex = 3;
            this.AddMailButton.Text = "Add";
            this.AddMailButton.UseVisualStyleBackColor = true;
            this.AddMailButton.Click += new System.EventHandler(this.AddMailButton_Click);
            // 
            // AllMails
            // 
            this.AllMails.AutoSize = true;
            this.AllMails.Location = new System.Drawing.Point(64, 10);
            this.AllMails.Name = "AllMails";
            this.AllMails.Size = new System.Drawing.Size(44, 13);
            this.AllMails.TabIndex = 4;
            this.AllMails.Text = "All mails";
            // 
            // SendedMails
            // 
            this.SendedMails.AutoSize = true;
            this.SendedMails.Location = new System.Drawing.Point(206, 10);
            this.SendedMails.Name = "SendedMails";
            this.SendedMails.Size = new System.Drawing.Size(70, 13);
            this.SendedMails.TabIndex = 5;
            this.SendedMails.Text = "Sended mails";
            // 
            // SendMail
            // 
            this.SendMail.Location = new System.Drawing.Point(289, 296);
            this.SendMail.Name = "SendMail";
            this.SendMail.Size = new System.Drawing.Size(75, 23);
            this.SendMail.TabIndex = 6;
            this.SendMail.Text = "Send";
            this.SendMail.UseVisualStyleBackColor = true;
            this.SendMail.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // ListSendedMails
            // 
            this.ListSendedMails.FullRowSelect = true;
            this.ListSendedMails.GridLines = true;
            this.ListSendedMails.HideSelection = false;
            this.ListSendedMails.LabelEdit = true;
            this.ListSendedMails.Location = new System.Drawing.Point(191, 35);
            this.ListSendedMails.MinimumSize = new System.Drawing.Size(152, 238);
            this.ListSendedMails.Name = "ListSendedMails";
            this.ListSendedMails.Size = new System.Drawing.Size(173, 238);
            this.ListSendedMails.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListSendedMails.TabIndex = 7;
            this.ListSendedMails.UseCompatibleStateImageBehavior = false;
            this.ListSendedMails.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 349);
            this.Controls.Add(this.ListSendedMails);
            this.Controls.Add(this.SendMail);
            this.Controls.Add(this.SendedMails);
            this.Controls.Add(this.AllMails);
            this.Controls.Add(this.AddMailButton);
            this.Controls.Add(this.ListAllMails);
            this.Controls.Add(this.LoadCSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadCSV;
        private System.Windows.Forms.ListView ListAllMails;
        private System.Windows.Forms.Button AddMailButton;
        private System.Windows.Forms.Label AllMails;
        private System.Windows.Forms.Label SendedMails;
        private System.Windows.Forms.Button SendMail;
        private System.Windows.Forms.ListView ListSendedMails;
    }
}

