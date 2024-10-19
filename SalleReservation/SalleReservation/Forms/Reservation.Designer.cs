namespace SalleReservation.Forms
{
    partial class Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.label2 = new System.Windows.Forms.Label();
            this.tfPrenom = new System.Windows.Forms.TextBox();
            this.dateR = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.seConnecterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeR = new System.Windows.Forms.ComboBox();
            this.salleR = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tfCIN = new System.Windows.Forms.TextBox();
            this.tfNom = new System.Windows.Forms.TextBox();
            this.tfEmail = new System.Windows.Forms.TextBox();
            this.tfTele = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(128, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "Reservation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tfPrenom
            // 
            this.tfPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfPrenom.Location = new System.Drawing.Point(231, 172);
            this.tfPrenom.Name = "tfPrenom";
            this.tfPrenom.Size = new System.Drawing.Size(182, 21);
            this.tfPrenom.TabIndex = 18;
            // 
            // dateR
            // 
            this.dateR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateR.Location = new System.Drawing.Point(231, 93);
            this.dateR.Name = "dateR";
            this.dateR.Size = new System.Drawing.Size(182, 21);
            this.dateR.TabIndex = 17;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(20, 92);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(168, 21);
            this.Email.TabIndex = 16;
            this.Email.Text = "Date de reservation ";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(23, 254);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(50, 21);
            this.password.TabIndex = 15;
            this.password.Text = "Email";
            // 
            // seConnecterBtn
            // 
            this.seConnecterBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.seConnecterBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seConnecterBtn.ForeColor = System.Drawing.Color.DimGray;
            this.seConnecterBtn.Location = new System.Drawing.Point(354, 413);
            this.seConnecterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.seConnecterBtn.Name = "seConnecterBtn";
            this.seConnecterBtn.Size = new System.Drawing.Size(92, 36);
            this.seConnecterBtn.TabIndex = 14;
            this.seConnecterBtn.Text = "Réserver";
            this.seConnecterBtn.UseVisualStyleBackColor = false;
            this.seConnecterBtn.Click += new System.EventHandler(this.seConnecterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 373);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Salle";
            // 
            // typeR
            // 
            this.typeR.FormattingEnabled = true;
            this.typeR.Items.AddRange(new object[] {
            "Anniversaire",
            "Mariage",
            "Association",
            "Autre"});
            this.typeR.Location = new System.Drawing.Point(231, 337);
            this.typeR.Name = "typeR";
            this.typeR.Size = new System.Drawing.Size(182, 21);
            this.typeR.TabIndex = 23;
            // 
            // salleR
            // 
            this.salleR.FormattingEnabled = true;
            this.salleR.Items.AddRange(new object[] {
            "Grande Salle",
            "Petite Salle",
            "Mariage Salle"});
            this.salleR.Location = new System.Drawing.Point(231, 373);
            this.salleR.Name = "salleR";
            this.salleR.Size = new System.Drawing.Size(182, 21);
            this.salleR.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nom ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "CIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tele";
            // 
            // tfCIN
            // 
            this.tfCIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCIN.Location = new System.Drawing.Point(231, 131);
            this.tfCIN.Name = "tfCIN";
            this.tfCIN.Size = new System.Drawing.Size(182, 21);
            this.tfCIN.TabIndex = 29;
            // 
            // tfNom
            // 
            this.tfNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfNom.Location = new System.Drawing.Point(231, 208);
            this.tfNom.Name = "tfNom";
            this.tfNom.Size = new System.Drawing.Size(182, 21);
            this.tfNom.TabIndex = 30;
            // 
            // tfEmail
            // 
            this.tfEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfEmail.Location = new System.Drawing.Point(231, 254);
            this.tfEmail.Name = "tfEmail";
            this.tfEmail.Size = new System.Drawing.Size(182, 21);
            this.tfEmail.TabIndex = 31;
            // 
            // tfTele
            // 
            this.tfTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfTele.Location = new System.Drawing.Point(231, 293);
            this.tfTele.Name = "tfTele";
            this.tfTele.Size = new System.Drawing.Size(182, 21);
            this.tfTele.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tfTele);
            this.Controls.Add(this.tfEmail);
            this.Controls.Add(this.tfNom);
            this.Controls.Add(this.tfCIN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salleR);
            this.Controls.Add(this.typeR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfPrenom);
            this.Controls.Add(this.dateR);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.seConnecterBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reservation";
            this.Text = "SalleBooker";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tfPrenom;
        private System.Windows.Forms.TextBox dateR;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button seConnecterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeR;
        private System.Windows.Forms.ComboBox salleR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tfCIN;
        private System.Windows.Forms.TextBox tfNom;
        private System.Windows.Forms.TextBox tfEmail;
        private System.Windows.Forms.TextBox tfTele;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}