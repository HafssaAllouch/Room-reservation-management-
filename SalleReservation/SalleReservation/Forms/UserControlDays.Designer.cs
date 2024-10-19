namespace SalleReservation.Forms
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.e1 = new System.Windows.Forms.Label();
            this.e2 = new System.Windows.Forms.Label();
            this.e3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "00";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(6, 58);
            this.l1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 20);
            this.l1.TabIndex = 1;
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Location = new System.Drawing.Point(6, 31);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(0, 20);
            this.e1.TabIndex = 2;
            this.e1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.Location = new System.Drawing.Point(6, 49);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(0, 20);
            this.e2.TabIndex = 3;
            this.e2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // e3
            // 
            this.e3.AutoSize = true;
            this.e3.Location = new System.Drawing.Point(6, 70);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(0, 20);
            this.e3.TabIndex = 4;
            this.e3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.e3);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(186, 108);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.Label e2;
        private System.Windows.Forms.Label e3;
    }
}
