
namespace Film
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nev = new System.Windows.Forms.TextBox();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntalca = new System.Windows.Forms.PictureBox();
            this.btnminmax = new System.Windows.Forms.PictureBox();
            this.btnbezar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfilmek = new FontAwesome.Sharp.IconButton();
            this.btnkedvencek = new FontAwesome.Sharp.IconButton();
            this.btnsorozatok = new FontAwesome.Sharp.IconButton();
            this.btnkereso = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnhelp = new FontAwesome.Sharp.IconButton();
            this.combofs = new System.Windows.Forms.ComboBox();
            this.comboevadok = new System.Windows.Forms.ComboBox();
            this.lblevad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btntalca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbezar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Netflixes film/sorozat neve:";
            // 
            // txt_nev
            // 
            this.txt_nev.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_nev.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_nev.Location = new System.Drawing.Point(262, 274);
            this.txt_nev.Name = "txt_nev";
            this.txt_nev.Size = new System.Drawing.Size(626, 29);
            this.txt_nev.TabIndex = 1;
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_hozzaad.Location = new System.Drawing.Point(556, 437);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(138, 36);
            this.btn_hozzaad.TabIndex = 2;
            this.btn_hozzaad.Text = "Hozzáadás";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.btn_hozzaad_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btntalca);
            this.panel1.Controls.Add(this.btnminmax);
            this.panel1.Controls.Add(this.btnbezar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 35);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 500);
            this.panel2.TabIndex = 3;
            // 
            // btntalca
            // 
            this.btntalca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntalca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntalca.Image = ((System.Drawing.Image)(resources.GetObject("btntalca.Image")));
            this.btntalca.Location = new System.Drawing.Point(1066, 12);
            this.btntalca.Name = "btntalca";
            this.btntalca.Size = new System.Drawing.Size(16, 16);
            this.btntalca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btntalca.TabIndex = 2;
            this.btntalca.TabStop = false;
            this.btntalca.Click += new System.EventHandler(this.btntalca_Click);
            // 
            // btnminmax
            // 
            this.btnminmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminmax.Image = ((System.Drawing.Image)(resources.GetObject("btnminmax.Image")));
            this.btnminmax.Location = new System.Drawing.Point(1088, 12);
            this.btnminmax.Name = "btnminmax";
            this.btnminmax.Size = new System.Drawing.Size(16, 16);
            this.btnminmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminmax.TabIndex = 1;
            this.btnminmax.TabStop = false;
            this.btnminmax.Click += new System.EventHandler(this.btnminmax_Click);
            // 
            // btnbezar
            // 
            this.btnbezar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbezar.Image = ((System.Drawing.Image)(resources.GetObject("btnbezar.Image")));
            this.btnbezar.Location = new System.Drawing.Point(1110, 12);
            this.btnbezar.Name = "btnbezar";
            this.btnbezar.Size = new System.Drawing.Size(16, 16);
            this.btnbezar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnbezar.TabIndex = 0;
            this.btnbezar.TabStop = false;
            this.btnbezar.Click += new System.EventHandler(this.btnbezar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu";
            // 
            // btnfilmek
            // 
            this.btnfilmek.FlatAppearance.BorderSize = 0;
            this.btnfilmek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfilmek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnfilmek.ForeColor = System.Drawing.Color.DimGray;
            this.btnfilmek.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnfilmek.IconColor = System.Drawing.Color.DimGray;
            this.btnfilmek.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnfilmek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfilmek.Location = new System.Drawing.Point(12, 52);
            this.btnfilmek.Name = "btnfilmek";
            this.btnfilmek.Size = new System.Drawing.Size(144, 43);
            this.btnfilmek.TabIndex = 1;
            this.btnfilmek.Tag = "Filmek";
            this.btnfilmek.Text = "Filmek";
            this.btnfilmek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfilmek.UseVisualStyleBackColor = true;
            this.btnfilmek.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnfilmek_MouseClick);
            // 
            // btnkedvencek
            // 
            this.btnkedvencek.FlatAppearance.BorderSize = 0;
            this.btnkedvencek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkedvencek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnkedvencek.ForeColor = System.Drawing.Color.DimGray;
            this.btnkedvencek.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnkedvencek.IconColor = System.Drawing.Color.DimGray;
            this.btnkedvencek.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnkedvencek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkedvencek.Location = new System.Drawing.Point(12, 150);
            this.btnkedvencek.Name = "btnkedvencek";
            this.btnkedvencek.Size = new System.Drawing.Size(144, 43);
            this.btnkedvencek.TabIndex = 2;
            this.btnkedvencek.Tag = "Kedvencek";
            this.btnkedvencek.Text = "Kedvencek";
            this.btnkedvencek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnkedvencek.UseVisualStyleBackColor = true;
            // 
            // btnsorozatok
            // 
            this.btnsorozatok.FlatAppearance.BorderSize = 0;
            this.btnsorozatok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsorozatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnsorozatok.ForeColor = System.Drawing.Color.DimGray;
            this.btnsorozatok.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.btnsorozatok.IconColor = System.Drawing.Color.DimGray;
            this.btnsorozatok.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsorozatok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsorozatok.Location = new System.Drawing.Point(12, 101);
            this.btnsorozatok.Name = "btnsorozatok";
            this.btnsorozatok.Size = new System.Drawing.Size(144, 43);
            this.btnsorozatok.TabIndex = 3;
            this.btnsorozatok.Tag = "Sorozatok";
            this.btnsorozatok.Text = "Sorozatok";
            this.btnsorozatok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsorozatok.UseVisualStyleBackColor = true;
            this.btnsorozatok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnsorozatok_MouseClick);
            // 
            // btnkereso
            // 
            this.btnkereso.FlatAppearance.BorderSize = 0;
            this.btnkereso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkereso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnkereso.ForeColor = System.Drawing.Color.DimGray;
            this.btnkereso.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnkereso.IconColor = System.Drawing.Color.DimGray;
            this.btnkereso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnkereso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkereso.Location = new System.Drawing.Point(12, 206);
            this.btnkereso.Name = "btnkereso";
            this.btnkereso.Size = new System.Drawing.Size(144, 43);
            this.btnkereso.TabIndex = 4;
            this.btnkereso.Tag = "Kedvencek";
            this.btnkereso.Text = "Kereső";
            this.btnkereso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnkereso.UseVisualStyleBackColor = true;
            this.btnkereso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnkereso_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btnhelp);
            this.panel3.Controls.Add(this.btnkereso);
            this.panel3.Controls.Add(this.btnsorozatok);
            this.panel3.Controls.Add(this.btnkedvencek);
            this.panel3.Controls.Add(this.btnfilmek);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 499);
            this.panel3.TabIndex = 9;
            // 
            // btnhelp
            // 
            this.btnhelp.FlatAppearance.BorderSize = 0;
            this.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnhelp.ForeColor = System.Drawing.Color.DimGray;
            this.btnhelp.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnhelp.IconColor = System.Drawing.Color.DimGray;
            this.btnhelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhelp.Location = new System.Drawing.Point(12, 444);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(144, 43);
            this.btnhelp.TabIndex = 5;
            this.btnhelp.Tag = "Kedvencek";
            this.btnhelp.Text = "Segítség";
            this.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnhelp_MouseClick);
            // 
            // combofs
            // 
            this.combofs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combofs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.combofs.FormattingEnabled = true;
            this.combofs.Items.AddRange(new object[] {
            " ",
            "Sorozat",
            "Film"});
            this.combofs.Location = new System.Drawing.Point(918, 274);
            this.combofs.Name = "combofs";
            this.combofs.Size = new System.Drawing.Size(121, 28);
            this.combofs.TabIndex = 10;
            this.combofs.SelectedIndexChanged += new System.EventHandler(this.combofs_SelectedIndexChanged);
            // 
            // comboevadok
            // 
            this.comboevadok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboevadok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboevadok.FormattingEnabled = true;
            this.comboevadok.Items.AddRange(new object[] {
            " ",
            "Minisorozat",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboevadok.Location = new System.Drawing.Point(609, 323);
            this.comboevadok.Name = "comboevadok";
            this.comboevadok.Size = new System.Drawing.Size(110, 28);
            this.comboevadok.TabIndex = 11;
            // 
            // lblevad
            // 
            this.lblevad.AutoSize = true;
            this.lblevad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblevad.Location = new System.Drawing.Point(369, 331);
            this.lblevad.Name = "lblevad";
            this.lblevad.Size = new System.Drawing.Size(206, 20);
            this.lblevad.TabIndex = 12;
            this.lblevad.Text = "Kérlek válaszd ki az évadot: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 534);
            this.Controls.Add(this.lblevad);
            this.Controls.Add(this.comboevadok);
            this.Controls.Add(this.combofs);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_hozzaad);
            this.Controls.Add(this.txt_nev);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netflix filmek";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btntalca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbezar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nev;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnbezar;
        private System.Windows.Forms.PictureBox btnminmax;
        private System.Windows.Forms.PictureBox btntalca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnfilmek;
        private FontAwesome.Sharp.IconButton btnkedvencek;
        private FontAwesome.Sharp.IconButton btnsorozatok;
        private FontAwesome.Sharp.IconButton btnkereso;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox combofs;
        private System.Windows.Forms.ComboBox comboevadok;
        private FontAwesome.Sharp.IconButton btnhelp;
        private System.Windows.Forms.Label lblevad;
    }
}

