namespace _20210224
{
    partial class Form1
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
            this.lblnev = new System.Windows.Forms.Label();
            this.lbltipp = new System.Windows.Forms.Label();
            this.txtnev = new System.Windows.Forms.TextBox();
            this.txtTipp = new System.Windows.Forms.TextBox();
            this.btnhozzaad = new System.Windows.Forms.Button();
            this.btnkilep = new System.Windows.Forms.Button();
            this.lblDB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnev
            // 
            this.lblnev.AutoSize = true;
            this.lblnev.Location = new System.Drawing.Point(40, 69);
            this.lblnev.Name = "lblnev";
            this.lblnev.Size = new System.Drawing.Size(71, 13);
            this.lblnev.TabIndex = 0;
            this.lblnev.Text = "Játékos neve";
            // 
            // lbltipp
            // 
            this.lbltipp.AutoSize = true;
            this.lbltipp.Location = new System.Drawing.Point(40, 131);
            this.lbltipp.Name = "lbltipp";
            this.lbltipp.Size = new System.Drawing.Size(74, 13);
            this.lbltipp.TabIndex = 1;
            this.lbltipp.Text = "Játékos tippjei";
            // 
            // txtnev
            // 
            this.txtnev.Location = new System.Drawing.Point(164, 66);
            this.txtnev.Name = "txtnev";
            this.txtnev.Size = new System.Drawing.Size(258, 20);
            this.txtnev.TabIndex = 2;
            // 
            // txtTipp
            // 
            this.txtTipp.Location = new System.Drawing.Point(164, 128);
            this.txtTipp.Name = "txtTipp";
            this.txtTipp.Size = new System.Drawing.Size(258, 20);
            this.txtTipp.TabIndex = 3;
            this.txtTipp.TextChanged += new System.EventHandler(this.txtTipp_TextChanged_1);
            // 
            // btnhozzaad
            // 
            this.btnhozzaad.Location = new System.Drawing.Point(218, 168);
            this.btnhozzaad.Name = "btnhozzaad";
            this.btnhozzaad.Size = new System.Drawing.Size(150, 24);
            this.btnhozzaad.TabIndex = 4;
            this.btnhozzaad.Text = "Játékos hozzáadása";
            this.btnhozzaad.UseVisualStyleBackColor = true;
            this.btnhozzaad.Click += new System.EventHandler(this.btnhozzaad_Click);
            // 
            // btnkilep
            // 
            this.btnkilep.Location = new System.Drawing.Point(240, 219);
            this.btnkilep.Name = "btnkilep";
            this.btnkilep.Size = new System.Drawing.Size(102, 21);
            this.btnkilep.TabIndex = 5;
            this.btnkilep.Text = "Kilépés";
            this.btnkilep.UseVisualStyleBackColor = true;
            this.btnkilep.Click += new System.EventHandler(this.btnkilep_Click);
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(454, 134);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(10, 13);
            this.lblDB.TabIndex = 6;
            this.lblDB.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 299);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.btnkilep);
            this.Controls.Add(this.btnhozzaad);
            this.Controls.Add(this.txtTipp);
            this.Controls.Add(this.txtnev);
            this.Controls.Add(this.lbltipp);
            this.Controls.Add(this.lblnev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnev;
        private System.Windows.Forms.Label lbltipp;
        private System.Windows.Forms.TextBox txtnev;
        private System.Windows.Forms.TextBox txtTipp;
        private System.Windows.Forms.Button btnhozzaad;
        private System.Windows.Forms.Button btnkilep;
        private System.Windows.Forms.Label lblDB;
    }
}

