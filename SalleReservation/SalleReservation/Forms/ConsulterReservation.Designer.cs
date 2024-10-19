namespace SalleReservation.Forms
{
    partial class ConsulterReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulterReservation));
            this.dgReservation = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tfCIN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeSalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgReservation
            // 
            this.dgReservation.AllowUserToDeleteRows = false;
            this.dgReservation.BackgroundColor = System.Drawing.Color.White;
            this.dgReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idR,
            this.dateR,
            this.CIN,
            this.nom,
            this.prenom,
            this.email,
            this.tele,
            this.TypeSalle,
            this.typeR,
            this.idU,
            this.Delete,
            this.Update});
            this.dgReservation.Location = new System.Drawing.Point(3, 32);
            this.dgReservation.Name = "dgReservation";
            this.dgReservation.ReadOnly = true;
            this.dgReservation.Size = new System.Drawing.Size(1152, 497);
            this.dgReservation.TabIndex = 0;
            this.dgReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReservation_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tfCIN);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 25);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(0, -4);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Accueil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tfCIN
            // 
            this.tfCIN.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCIN.Location = new System.Drawing.Point(405, 0);
            this.tfCIN.Name = "tfCIN";
            this.tfCIN.Size = new System.Drawing.Size(232, 28);
            this.tfCIN.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(642, -4);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Chercher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(860, -4);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Toutes les réservations";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idR
            // 
            this.idR.DataPropertyName = "id_r";
            this.idR.HeaderText = "idReservation";
            this.idR.Name = "idR";
            this.idR.ReadOnly = true;
            this.idR.Visible = false;
            // 
            // dateR
            // 
            this.dateR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateR.DataPropertyName = "dateResrv";
            this.dateR.HeaderText = "Date de réservation";
            this.dateR.Name = "dateR";
            this.dateR.ReadOnly = true;
            this.dateR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // CIN
            // 
            this.CIN.DataPropertyName = "CIN";
            this.CIN.HeaderText = "CIN";
            this.CIN.Name = "CIN";
            this.CIN.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "prenom";
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // tele
            // 
            this.tele.DataPropertyName = "tele";
            this.tele.HeaderText = "tele";
            this.tele.Name = "tele";
            this.tele.ReadOnly = true;
            // 
            // TypeSalle
            // 
            this.TypeSalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeSalle.DataPropertyName = "TypeSalle";
            this.TypeSalle.HeaderText = "Salle";
            this.TypeSalle.Name = "TypeSalle";
            this.TypeSalle.ReadOnly = true;
            // 
            // typeR
            // 
            this.typeR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeR.DataPropertyName = "typeReser";
            this.typeR.HeaderText = "Réservation activité";
            this.typeR.Name = "typeR";
            this.typeR.ReadOnly = true;
            this.typeR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idU
            // 
            this.idU.DataPropertyName = "idU";
            this.idU.HeaderText = "idU";
            this.idU.Name = "idU";
            this.idU.ReadOnly = true;
            this.idU.Visible = false;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.FillWeight = 10F;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            this.Update.DataPropertyName = "Update";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Update.DefaultCellStyle = dataGridViewCellStyle2;
            this.Update.HeaderText = "";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // ConsulterReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgReservation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsulterReservation";
            this.Text = "SalleBooker";
            this.Load += new System.EventHandler(this.ConsulterReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReservation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tfCIN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn tele;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeSalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeR;
        private System.Windows.Forms.DataGridViewTextBoxColumn idU;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}