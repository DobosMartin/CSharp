namespace _20220106
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_listbox = new System.Windows.Forms.Button();
            this.txt_datum = new System.Windows.Forms.TextBox();
            this.txt_benzin = new System.Windows.Forms.TextBox();
            this.txt_gazolaj = new System.Windows.Forms.TextBox();
            this.btn_datumkeres = new System.Windows.Forms.Button();
            this.btn_menttorol = new System.Windows.Forms.Button();
            this.btn_feltölt = new System.Windows.Forms.Button();
            this.lbx_adatok = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dátum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Benzin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gázolaj";
            // 
            // btn_listbox
            // 
            this.btn_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_listbox.Location = new System.Drawing.Point(19, 251);
            this.btn_listbox.Name = "btn_listbox";
            this.btn_listbox.Size = new System.Drawing.Size(93, 41);
            this.btn_listbox.TabIndex = 3;
            this.btn_listbox.Text = "Listboxba írás";
            this.btn_listbox.UseVisualStyleBackColor = true;
            this.btn_listbox.Click += new System.EventHandler(this.Btn_listbox_Click);
            // 
            // txt_datum
            // 
            this.txt_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_datum.Location = new System.Drawing.Point(99, 67);
            this.txt_datum.Name = "txt_datum";
            this.txt_datum.Size = new System.Drawing.Size(100, 22);
            this.txt_datum.TabIndex = 4;
            // 
            // txt_benzin
            // 
            this.txt_benzin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_benzin.Location = new System.Drawing.Point(99, 104);
            this.txt_benzin.Name = "txt_benzin";
            this.txt_benzin.Size = new System.Drawing.Size(100, 22);
            this.txt_benzin.TabIndex = 5;
            // 
            // txt_gazolaj
            // 
            this.txt_gazolaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_gazolaj.Location = new System.Drawing.Point(99, 140);
            this.txt_gazolaj.Name = "txt_gazolaj";
            this.txt_gazolaj.Size = new System.Drawing.Size(100, 22);
            this.txt_gazolaj.TabIndex = 6;
            // 
            // btn_datumkeres
            // 
            this.btn_datumkeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_datumkeres.Location = new System.Drawing.Point(75, 345);
            this.btn_datumkeres.Name = "btn_datumkeres";
            this.btn_datumkeres.Size = new System.Drawing.Size(158, 41);
            this.btn_datumkeres.TabIndex = 7;
            this.btn_datumkeres.Text = "Keresés dátum alapján";
            this.btn_datumkeres.UseVisualStyleBackColor = true;
            this.btn_datumkeres.Click += new System.EventHandler(this.Btn_datumkeres_Click);
            // 
            // btn_menttorol
            // 
            this.btn_menttorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_menttorol.Location = new System.Drawing.Point(75, 298);
            this.btn_menttorol.Name = "btn_menttorol";
            this.btn_menttorol.Size = new System.Drawing.Size(158, 41);
            this.btn_menttorol.TabIndex = 8;
            this.btn_menttorol.Text = "Listbox mentése és törlése";
            this.btn_menttorol.UseVisualStyleBackColor = true;
            this.btn_menttorol.Click += new System.EventHandler(this.Btn_menttorol_Click);
            // 
            // btn_feltölt
            // 
            this.btn_feltölt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_feltölt.Location = new System.Drawing.Point(129, 251);
            this.btn_feltölt.Name = "btn_feltölt";
            this.btn_feltölt.Size = new System.Drawing.Size(158, 41);
            this.btn_feltölt.TabIndex = 9;
            this.btn_feltölt.Text = "Feltöltés Listboxba";
            this.btn_feltölt.UseVisualStyleBackColor = true;
            this.btn_feltölt.Click += new System.EventHandler(this.Btn_feltölt_Click);
            // 
            // lbx_adatok
            // 
            this.lbx_adatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbx_adatok.FormattingEnabled = true;
            this.lbx_adatok.ItemHeight = 16;
            this.lbx_adatok.Location = new System.Drawing.Point(318, 48);
            this.lbx_adatok.Name = "lbx_adatok";
            this.lbx_adatok.Size = new System.Drawing.Size(161, 180);
            this.lbx_adatok.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 401);
            this.Controls.Add(this.lbx_adatok);
            this.Controls.Add(this.btn_feltölt);
            this.Controls.Add(this.btn_menttorol);
            this.Controls.Add(this.btn_datumkeres);
            this.Controls.Add(this.txt_gazolaj);
            this.Controls.Add(this.txt_benzin);
            this.Controls.Add(this.txt_datum);
            this.Controls.Add(this.btn_listbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_listbox;
        private System.Windows.Forms.TextBox txt_datum;
        private System.Windows.Forms.TextBox txt_benzin;
        private System.Windows.Forms.TextBox txt_gazolaj;
        private System.Windows.Forms.Button btn_datumkeres;
        private System.Windows.Forms.Button btn_menttorol;
        private System.Windows.Forms.Button btn_feltölt;
        private System.Windows.Forms.ListBox lbx_adatok;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

