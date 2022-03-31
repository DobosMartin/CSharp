namespace _20210309
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
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.btn_felulre = new System.Windows.Forms.Button();
            this.btn_fel = new System.Windows.Forms.Button();
            this.btn_le = new System.Windows.Forms.Button();
            this.btn_alulra = new System.Windows.Forms.Button();
            this.btn_torol = new System.Windows.Forms.Button();
            this.btn_rendezes = new System.Windows.Forms.Button();
            this.btn_iras = new System.Windows.Forms.Button();
            this.btn_olvas = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.lbxElemek = new System.Windows.Forms.ListBox();
            this.txtHozzaad = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Location = new System.Drawing.Point(237, 78);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(93, 24);
            this.btn_hozzaad.TabIndex = 0;
            this.btn_hozzaad.Text = "Hozzáad";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.btn_hozzaad_Click);
            // 
            // btn_felulre
            // 
            this.btn_felulre.Enabled = false;
            this.btn_felulre.Location = new System.Drawing.Point(237, 122);
            this.btn_felulre.Name = "btn_felulre";
            this.btn_felulre.Size = new System.Drawing.Size(93, 24);
            this.btn_felulre.TabIndex = 1;
            this.btn_felulre.Text = "Felülre";
            this.btn_felulre.UseVisualStyleBackColor = true;
            this.btn_felulre.Click += new System.EventHandler(this.btn_felulre_Click);
            // 
            // btn_fel
            // 
            this.btn_fel.Enabled = false;
            this.btn_fel.Location = new System.Drawing.Point(237, 165);
            this.btn_fel.Name = "btn_fel";
            this.btn_fel.Size = new System.Drawing.Size(93, 24);
            this.btn_fel.TabIndex = 2;
            this.btn_fel.Text = "Fel";
            this.btn_fel.UseVisualStyleBackColor = true;
            this.btn_fel.Click += new System.EventHandler(this.btn_fel_Click);
            // 
            // btn_le
            // 
            this.btn_le.Enabled = false;
            this.btn_le.Location = new System.Drawing.Point(237, 208);
            this.btn_le.Name = "btn_le";
            this.btn_le.Size = new System.Drawing.Size(93, 24);
            this.btn_le.TabIndex = 3;
            this.btn_le.Text = "Le";
            this.btn_le.UseVisualStyleBackColor = true;
            this.btn_le.Click += new System.EventHandler(this.btn_le_Click);
            // 
            // btn_alulra
            // 
            this.btn_alulra.Enabled = false;
            this.btn_alulra.Location = new System.Drawing.Point(237, 253);
            this.btn_alulra.Name = "btn_alulra";
            this.btn_alulra.Size = new System.Drawing.Size(93, 24);
            this.btn_alulra.TabIndex = 4;
            this.btn_alulra.Text = "Alulra";
            this.btn_alulra.UseVisualStyleBackColor = true;
            this.btn_alulra.Click += new System.EventHandler(this.btn_alulra_Click);
            // 
            // btn_torol
            // 
            this.btn_torol.Location = new System.Drawing.Point(237, 304);
            this.btn_torol.Name = "btn_torol";
            this.btn_torol.Size = new System.Drawing.Size(93, 24);
            this.btn_torol.TabIndex = 5;
            this.btn_torol.Text = "Töröl";
            this.btn_torol.UseVisualStyleBackColor = true;
            this.btn_torol.Click += new System.EventHandler(this.btn_torol_Click);
            // 
            // btn_rendezes
            // 
            this.btn_rendezes.Enabled = false;
            this.btn_rendezes.Location = new System.Drawing.Point(237, 353);
            this.btn_rendezes.Name = "btn_rendezes";
            this.btn_rendezes.Size = new System.Drawing.Size(93, 24);
            this.btn_rendezes.TabIndex = 6;
            this.btn_rendezes.Text = "Rendezés";
            this.btn_rendezes.UseVisualStyleBackColor = true;
            this.btn_rendezes.Click += new System.EventHandler(this.btn_rendezes_Click);
            // 
            // btn_iras
            // 
            this.btn_iras.Location = new System.Drawing.Point(237, 402);
            this.btn_iras.Name = "btn_iras";
            this.btn_iras.Size = new System.Drawing.Size(93, 24);
            this.btn_iras.TabIndex = 7;
            this.btn_iras.Text = "Írás";
            this.btn_iras.UseVisualStyleBackColor = true;
            this.btn_iras.Click += new System.EventHandler(this.btn_iras_Click);
            // 
            // btn_olvas
            // 
            this.btn_olvas.Location = new System.Drawing.Point(237, 450);
            this.btn_olvas.Name = "btn_olvas";
            this.btn_olvas.Size = new System.Drawing.Size(93, 24);
            this.btn_olvas.TabIndex = 8;
            this.btn_olvas.Text = "Olvasás";
            this.btn_olvas.UseVisualStyleBackColor = true;
            this.btn_olvas.Click += new System.EventHandler(this.btn_olvas_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.Location = new System.Drawing.Point(237, 500);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(93, 24);
            this.btn_kilep.TabIndex = 9;
            this.btn_kilep.Text = "Kilépés";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.btn_kilep_Click);
            // 
            // lbxElemek
            // 
            this.lbxElemek.FormattingEnabled = true;
            this.lbxElemek.Location = new System.Drawing.Point(44, 78);
            this.lbxElemek.Name = "lbxElemek";
            this.lbxElemek.Size = new System.Drawing.Size(187, 446);
            this.lbxElemek.TabIndex = 11;
            this.lbxElemek.SelectedIndexChanged += new System.EventHandler(this.lbxElemek_SelectedIndexChanged);
            // 
            // txtHozzaad
            // 
            this.txtHozzaad.Location = new System.Drawing.Point(44, 39);
            this.txtHozzaad.Name = "txtHozzaad";
            this.txtHozzaad.Size = new System.Drawing.Size(187, 20);
            this.txtHozzaad.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 553);
            this.Controls.Add(this.txtHozzaad);
            this.Controls.Add(this.lbxElemek);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_olvas);
            this.Controls.Add(this.btn_iras);
            this.Controls.Add(this.btn_rendezes);
            this.Controls.Add(this.btn_torol);
            this.Controls.Add(this.btn_alulra);
            this.Controls.Add(this.btn_le);
            this.Controls.Add(this.btn_fel);
            this.Controls.Add(this.btn_felulre);
            this.Controls.Add(this.btn_hozzaad);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.Button btn_felulre;
        private System.Windows.Forms.Button btn_fel;
        private System.Windows.Forms.Button btn_le;
        private System.Windows.Forms.Button btn_alulra;
        private System.Windows.Forms.Button btn_torol;
        private System.Windows.Forms.Button btn_rendezes;
        private System.Windows.Forms.Button btn_iras;
        private System.Windows.Forms.Button btn_olvas;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.ListBox lbxElemek;
        private System.Windows.Forms.TextBox txtHozzaad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

