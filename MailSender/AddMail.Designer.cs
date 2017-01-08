namespace MailSender {
    partial class AddMail {
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
            this.label1 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.AddNewMail = new System.Windows.Forms.Button();
            this.Cantel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(53, 25);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(186, 20);
            this.emailBox.TabIndex = 1;
            // 
            // AddNewMail
            // 
            this.AddNewMail.Location = new System.Drawing.Point(163, 54);
            this.AddNewMail.Name = "AddNewMail";
            this.AddNewMail.Size = new System.Drawing.Size(75, 23);
            this.AddNewMail.TabIndex = 2;
            this.AddNewMail.Text = "Add";
            this.AddNewMail.UseVisualStyleBackColor = true;
            this.AddNewMail.Click += new System.EventHandler(this.AddNewMail_Click);
            // 
            // Cantel
            // 
            this.Cantel.Location = new System.Drawing.Point(15, 54);
            this.Cantel.Name = "Cantel";
            this.Cantel.Size = new System.Drawing.Size(75, 23);
            this.Cantel.TabIndex = 3;
            this.Cantel.Text = "Cantel";
            this.Cantel.UseVisualStyleBackColor = true;
            this.Cantel.Click += new System.EventHandler(this.Cantel_Click);
            // 
            // AddMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 89);
            this.Controls.Add(this.Cantel);
            this.Controls.Add(this.AddNewMail);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label1);
            this.Name = "AddMail";
            this.Text = "AddMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button AddNewMail;
        private System.Windows.Forms.Button Cantel;
    }
}