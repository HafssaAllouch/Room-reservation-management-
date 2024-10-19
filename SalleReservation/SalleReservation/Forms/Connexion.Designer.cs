namespace SalleReservation.Forms
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.seConnecterBtn = new System.Windows.Forms.Button();
            this.InscrireBtn = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.emailTf = new System.Windows.Forms.TextBox();
            this.passTf = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // seConnecterBtn
            // 
            this.seConnecterBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.seConnecterBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seConnecterBtn.ForeColor = System.Drawing.Color.DimGray;
            this.seConnecterBtn.Location = new System.Drawing.Point(245, 328);
            this.seConnecterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.seConnecterBtn.Name = "seConnecterBtn";
            this.seConnecterBtn.Size = new System.Drawing.Size(124, 36);
            this.seConnecterBtn.TabIndex = 5;
            this.seConnecterBtn.Text = "Se Connecter";
            this.seConnecterBtn.UseVisualStyleBackColor = false;
            this.seConnecterBtn.Click += new System.EventHandler(this.seConnecterBtn_Click);
            // 
            // InscrireBtn
            // 
            this.InscrireBtn.AutoSize = true;
            this.InscrireBtn.Location = new System.Drawing.Point(184, 397);
            this.InscrireBtn.Name = "InscrireBtn";
            this.InscrireBtn.Size = new System.Drawing.Size(49, 13);
            this.InscrireBtn.TabIndex = 6;
            this.InscrireBtn.TabStop = true;
            this.InscrireBtn.Text = "S\'inscrire";
            this.InscrireBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InscrireBtn_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vous n\'avez pas un Compte !";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(23, 275);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(115, 21);
            this.password.TabIndex = 9;
            this.password.Text = "Mot de Passe";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(23, 237);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(50, 21);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // emailTf
            // 
            this.emailTf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTf.Location = new System.Drawing.Point(187, 237);
            this.emailTf.Name = "emailTf";
            this.emailTf.Size = new System.Drawing.Size(182, 21);
            this.emailTf.TabIndex = 11;
            this.emailTf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passTf
            // 
            this.passTf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTf.Location = new System.Drawing.Point(187, 275);
            this.passTf.Name = "passTf";
            this.passTf.PasswordChar = '*';
            this.passTf.Size = new System.Drawing.Size(182, 21);
            this.passTf.TabIndex = 12;
            this.passTf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(81, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 181);
            this.panel1.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passTf);
            this.Controls.Add(this.emailTf);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InscrireBtn);
            this.Controls.Add(this.seConnecterBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalleBooker";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seConnecterBtn;
        private System.Windows.Forms.LinkLabel InscrireBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox emailTf;
        private System.Windows.Forms.TextBox passTf;
        private System.Windows.Forms.Panel panel1;
    }
}