namespace SalleReservation
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.password = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.EmailTf = new System.Windows.Forms.Label();
            this.passwordTf = new System.Windows.Forms.Label();
            this.sinscrireBtn = new System.Windows.Forms.Button();
            this.nomTf = new System.Windows.Forms.Label();
            this.prenomTf = new System.Windows.Forms.Label();
            this.numTf = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bPrev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(198, 353);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(182, 21);
            this.password.TabIndex = 19;
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(198, 190);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(182, 21);
            this.nom.TabIndex = 18;
            // 
            // EmailTf
            // 
            this.EmailTf.AutoSize = true;
            this.EmailTf.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTf.Location = new System.Drawing.Point(43, 307);
            this.EmailTf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailTf.Name = "EmailTf";
            this.EmailTf.Size = new System.Drawing.Size(50, 21);
            this.EmailTf.TabIndex = 17;
            this.EmailTf.Text = "Email";
            // 
            // passwordTf
            // 
            this.passwordTf.AutoSize = true;
            this.passwordTf.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTf.Location = new System.Drawing.Point(43, 352);
            this.passwordTf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordTf.Name = "passwordTf";
            this.passwordTf.Size = new System.Drawing.Size(115, 21);
            this.passwordTf.TabIndex = 16;
            this.passwordTf.Text = "Mot de Passe";
            // 
            // sinscrireBtn
            // 
            this.sinscrireBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sinscrireBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinscrireBtn.ForeColor = System.Drawing.Color.DimGray;
            this.sinscrireBtn.Location = new System.Drawing.Point(236, 403);
            this.sinscrireBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sinscrireBtn.Name = "sinscrireBtn";
            this.sinscrireBtn.Size = new System.Drawing.Size(144, 36);
            this.sinscrireBtn.TabIndex = 15;
            this.sinscrireBtn.Text = "S\'inscrire";
            this.sinscrireBtn.UseVisualStyleBackColor = false;
            this.sinscrireBtn.Click += new System.EventHandler(this.seConnecterBtn_Click);
            // 
            // nomTf
            // 
            this.nomTf.AutoSize = true;
            this.nomTf.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTf.Location = new System.Drawing.Point(43, 189);
            this.nomTf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomTf.Name = "nomTf";
            this.nomTf.Size = new System.Drawing.Size(45, 21);
            this.nomTf.TabIndex = 21;
            this.nomTf.Text = "Nom";
            // 
            // prenomTf
            // 
            this.prenomTf.AutoSize = true;
            this.prenomTf.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomTf.Location = new System.Drawing.Point(43, 223);
            this.prenomTf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prenomTf.Name = "prenomTf";
            this.prenomTf.Size = new System.Drawing.Size(67, 21);
            this.prenomTf.TabIndex = 22;
            this.prenomTf.Text = "Prenom";
            // 
            // numTf
            // 
            this.numTf.AutoSize = true;
            this.numTf.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTf.Location = new System.Drawing.Point(43, 265);
            this.numTf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numTf.Name = "numTf";
            this.numTf.Size = new System.Drawing.Size(69, 21);
            this.numTf.TabIndex = 23;
            this.numTf.Text = "Numéro";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(198, 307);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(182, 21);
            this.email.TabIndex = 24;
            // 
            // prenom
            // 
            this.prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(198, 224);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(182, 21);
            this.prenom.TabIndex = 25;
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(198, 265);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(182, 21);
            this.num.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(106, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 157);
            this.panel1.TabIndex = 27;
            // 
            // bPrev
            // 
            this.bPrev.Location = new System.Drawing.Point(12, 414);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(34, 25);
            this.bPrev.TabIndex = 28;
            this.bPrev.Text = "<<";
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.bPrev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.email);
            this.Controls.Add(this.numTf);
            this.Controls.Add(this.prenomTf);
            this.Controls.Add(this.nomTf);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.EmailTf);
            this.Controls.Add(this.passwordTf);
            this.Controls.Add(this.sinscrireBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "SalleBooker";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label EmailTf;
        private System.Windows.Forms.Label passwordTf;
        private System.Windows.Forms.Button sinscrireBtn;
        private System.Windows.Forms.Label nomTf;
        private System.Windows.Forms.Label prenomTf;
        private System.Windows.Forms.Label numTf;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bPrev;
    }
}