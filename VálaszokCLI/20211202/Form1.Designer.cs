namespace _20211202
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
            this.btn_keres = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_kod = new System.Windows.Forms.Label();
            this.lbl_valasz = new System.Windows.Forms.Label();
            this.txt_kod = new System.Windows.Forms.TextBox();
            this.txt_valasz = new System.Windows.Forms.TextBox();
            this.btn_beolvas = new System.Windows.Forms.Button();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.btn_ment = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_vissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_keres
            // 
            this.btn_keres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_keres.Location = new System.Drawing.Point(326, 54);
            this.btn_keres.Name = "btn_keres";
            this.btn_keres.Size = new System.Drawing.Size(106, 42);
            this.btn_keres.TabIndex = 0;
            this.btn_keres.Text = "Keresés";
            this.btn_keres.UseVisualStyleBackColor = true;
            this.btn_keres.Click += new System.EventHandler(this.Btn_keres_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(460, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 173);
            this.listBox1.TabIndex = 1;
            // 
            // lbl_kod
            // 
            this.lbl_kod.AutoSize = true;
            this.lbl_kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_kod.Location = new System.Drawing.Point(35, 54);
            this.lbl_kod.Name = "lbl_kod";
            this.lbl_kod.Size = new System.Drawing.Size(35, 18);
            this.lbl_kod.TabIndex = 2;
            this.lbl_kod.Text = "Kód";
            // 
            // lbl_valasz
            // 
            this.lbl_valasz.AutoSize = true;
            this.lbl_valasz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_valasz.Location = new System.Drawing.Point(35, 117);
            this.lbl_valasz.Name = "lbl_valasz";
            this.lbl_valasz.Size = new System.Drawing.Size(52, 18);
            this.lbl_valasz.TabIndex = 3;
            this.lbl_valasz.Text = "Válasz";
            // 
            // txt_kod
            // 
            this.txt_kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_kod.Location = new System.Drawing.Point(95, 51);
            this.txt_kod.Name = "txt_kod";
            this.txt_kod.Size = new System.Drawing.Size(100, 24);
            this.txt_kod.TabIndex = 4;
            // 
            // txt_valasz
            // 
            this.txt_valasz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_valasz.Location = new System.Drawing.Point(95, 114);
            this.txt_valasz.Name = "txt_valasz";
            this.txt_valasz.Size = new System.Drawing.Size(100, 24);
            this.txt_valasz.TabIndex = 5;
            this.txt_valasz.TextChanged += new System.EventHandler(this.Txt_valasz_TextChanged);
            // 
            // btn_beolvas
            // 
            this.btn_beolvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_beolvas.Location = new System.Drawing.Point(326, 114);
            this.btn_beolvas.Name = "btn_beolvas";
            this.btn_beolvas.Size = new System.Drawing.Size(106, 42);
            this.btn_beolvas.TabIndex = 6;
            this.btn_beolvas.Text = "Beolvas";
            this.btn_beolvas.UseVisualStyleBackColor = true;
            this.btn_beolvas.Click += new System.EventHandler(this.Btn_beolvas_Click);
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Enabled = false;
            this.btn_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_hozzaad.Location = new System.Drawing.Point(326, 176);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(106, 42);
            this.btn_hozzaad.TabIndex = 7;
            this.btn_hozzaad.Text = "Hozzáad";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.Btn_hozzaad_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kilep.Location = new System.Drawing.Point(198, 176);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(106, 42);
            this.btn_kilep.TabIndex = 8;
            this.btn_kilep.Text = "Kilépés";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.Btn_kilep_Click);
            // 
            // btn_ment
            // 
            this.btn_ment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ment.Location = new System.Drawing.Point(65, 177);
            this.btn_ment.Name = "btn_ment";
            this.btn_ment.Size = new System.Drawing.Size(106, 42);
            this.btn_ment.TabIndex = 9;
            this.btn_ment.Text = "Mentés";
            this.btn_ment.UseVisualStyleBackColor = true;
            this.btn_ment.Click += new System.EventHandler(this.Btn_ment_Click);
            // 
            // btn_vissza
            // 
            this.btn_vissza.Location = new System.Drawing.Point(245, 65);
            this.btn_vissza.Name = "btn_vissza";
            this.btn_vissza.Size = new System.Drawing.Size(75, 23);
            this.btn_vissza.TabIndex = 10;
            this.btn_vissza.Text = "Vissza";
            this.btn_vissza.UseVisualStyleBackColor = true;
            this.btn_vissza.Click += new System.EventHandler(this.Btn_vissza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(670, 259);
            this.Controls.Add(this.btn_vissza);
            this.Controls.Add(this.btn_ment);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_hozzaad);
            this.Controls.Add(this.btn_beolvas);
            this.Controls.Add(this.txt_valasz);
            this.Controls.Add(this.txt_kod);
            this.Controls.Add(this.lbl_valasz);
            this.Controls.Add(this.lbl_kod);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_keres);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tesztverseny GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_keres;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_kod;
        private System.Windows.Forms.Label lbl_valasz;
        private System.Windows.Forms.TextBox txt_kod;
        private System.Windows.Forms.TextBox txt_valasz;
        private System.Windows.Forms.Button btn_beolvas;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.Button btn_ment;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_vissza;
    }
}

