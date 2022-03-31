namespace _20211007
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nev = new System.Windows.Forms.TextBox();
            this.txt_tipp = new System.Windows.Forms.TextBox();
            this.lbl_db = new System.Windows.Forms.Label();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Játékos tippjei:";
            // 
            // txt_nev
            // 
            this.txt_nev.Location = new System.Drawing.Point(160, 30);
            this.txt_nev.Name = "txt_nev";
            this.txt_nev.Size = new System.Drawing.Size(369, 20);
            this.txt_nev.TabIndex = 2;
            // 
            // txt_tipp
            // 
            this.txt_tipp.Location = new System.Drawing.Point(160, 95);
            this.txt_tipp.Name = "txt_tipp";
            this.txt_tipp.Size = new System.Drawing.Size(398, 20);
            this.txt_tipp.TabIndex = 3;
            this.txt_tipp.TextChanged += new System.EventHandler(this.Txt_tipp_TextChanged);
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Location = new System.Drawing.Point(601, 98);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(19, 13);
            this.lbl_db.TabIndex = 4;
            this.lbl_db.Text = "db";
            this.lbl_db.Click += new System.EventHandler(this.Lbl_db_Click);
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Location = new System.Drawing.Point(218, 138);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(234, 23);
            this.btn_hozzaad.TabIndex = 5;
            this.btn_hozzaad.Text = "Játékos hozzáadása";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.Btn_hozzaad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 183);
            this.Controls.Add(this.btn_hozzaad);
            this.Controls.Add(this.lbl_db);
            this.Controls.Add(this.txt_tipp);
            this.Controls.Add(this.txt_nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Egyszámjáték GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nev;
        private System.Windows.Forms.TextBox txt_tipp;
        private System.Windows.Forms.Label lbl_db;
        private System.Windows.Forms.Button btn_hozzaad;
    }
}

