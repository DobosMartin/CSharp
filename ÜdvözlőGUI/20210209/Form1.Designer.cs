namespace _20210209
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
            this.keremanevet = new System.Windows.Forms.Label();
            this.nevbe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.udv = new System.Windows.Forms.Button();
            this.doktor = new System.Windows.Forms.Button();
            this.vege = new System.Windows.Forms.Button();
            this.torol = new System.Windows.Forms.Button();
            this.vezeteknev = new System.Windows.Forms.TextBox();
            this.keresztnev = new System.Windows.Forms.TextBox();
            this.hossz = new System.Windows.Forms.TextBox();
            this.udvozlo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keremanevet
            // 
            this.keremanevet.AutoSize = true;
            this.keremanevet.Location = new System.Drawing.Point(34, 28);
            this.keremanevet.Name = "keremanevet";
            this.keremanevet.Size = new System.Drawing.Size(79, 13);
            this.keremanevet.TabIndex = 0;
            this.keremanevet.Text = "Kérem a nevet:";
            // 
            // nevbe
            // 
            this.nevbe.Location = new System.Drawing.Point(37, 54);
            this.nevbe.Name = "nevbe";
            this.nevbe.Size = new System.Drawing.Size(220, 20);
            this.nevbe.TabIndex = 1;
            this.nevbe.TextChanged += new System.EventHandler(this.nevbe_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vezetéknév:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "A név hossza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "karakter.";
            // 
            // udv
            // 
            this.udv.Location = new System.Drawing.Point(43, 264);
            this.udv.Name = "udv";
            this.udv.Size = new System.Drawing.Size(86, 24);
            this.udv.TabIndex = 6;
            this.udv.Text = "Üdvözlés";
            this.udv.UseVisualStyleBackColor = true;
            this.udv.Click += new System.EventHandler(this.udv_Click);
            // 
            // doktor
            // 
            this.doktor.Location = new System.Drawing.Point(171, 264);
            this.doktor.Name = "doktor";
            this.doktor.Size = new System.Drawing.Size(86, 24);
            this.doktor.TabIndex = 7;
            this.doktor.Text = "Doktor";
            this.doktor.UseVisualStyleBackColor = true;
            this.doktor.Click += new System.EventHandler(this.doktor_Click);
            // 
            // vege
            // 
            this.vege.Location = new System.Drawing.Point(43, 314);
            this.vege.Name = "vege";
            this.vege.Size = new System.Drawing.Size(86, 24);
            this.vege.TabIndex = 8;
            this.vege.Text = "Vége";
            this.vege.UseVisualStyleBackColor = true;
            this.vege.Click += new System.EventHandler(this.vege_Click);
            // 
            // torol
            // 
            this.torol.Location = new System.Drawing.Point(171, 314);
            this.torol.Name = "torol";
            this.torol.Size = new System.Drawing.Size(86, 23);
            this.torol.TabIndex = 9;
            this.torol.Text = "Törlés";
            this.torol.UseVisualStyleBackColor = true;
            this.torol.Click += new System.EventHandler(this.torol_Click);
            // 
            // vezeteknev
            // 
            this.vezeteknev.BackColor = System.Drawing.Color.Gainsboro;
            this.vezeteknev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vezeteknev.Location = new System.Drawing.Point(128, 104);
            this.vezeteknev.Name = "vezeteknev";
            this.vezeteknev.ReadOnly = true;
            this.vezeteknev.Size = new System.Drawing.Size(109, 22);
            this.vezeteknev.TabIndex = 10;
            this.vezeteknev.TextChanged += new System.EventHandler(this.vezeteknev_TextChanged);
            // 
            // keresztnev
            // 
            this.keresztnev.BackColor = System.Drawing.Color.Gainsboro;
            this.keresztnev.Location = new System.Drawing.Point(128, 139);
            this.keresztnev.Name = "keresztnev";
            this.keresztnev.ReadOnly = true;
            this.keresztnev.Size = new System.Drawing.Size(109, 20);
            this.keresztnev.TabIndex = 11;
            // 
            // hossz
            // 
            this.hossz.BackColor = System.Drawing.Color.Gainsboro;
            this.hossz.Location = new System.Drawing.Point(120, 185);
            this.hossz.Name = "hossz";
            this.hossz.Size = new System.Drawing.Size(63, 20);
            this.hossz.TabIndex = 14;
            // 
            // udvozlo
            // 
            this.udvozlo.AutoSize = true;
            this.udvozlo.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.udvozlo.Location = new System.Drawing.Point(61, 220);
            this.udvozlo.Name = "udvozlo";
            this.udvozlo.Size = new System.Drawing.Size(0, 19);
            this.udvozlo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Keresztnév:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(301, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udvozlo);
            this.Controls.Add(this.hossz);
            this.Controls.Add(this.keresztnev);
            this.Controls.Add(this.vezeteknev);
            this.Controls.Add(this.torol);
            this.Controls.Add(this.vege);
            this.Controls.Add(this.doktor);
            this.Controls.Add(this.udv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nevbe);
            this.Controls.Add(this.keremanevet);
            this.Name = "Form1";
            this.Text = "Stringek használata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keremanevet;
        private System.Windows.Forms.TextBox nevbe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button udv;
        private System.Windows.Forms.Button doktor;
        private System.Windows.Forms.Button vege;
        private System.Windows.Forms.Button torol;
        private System.Windows.Forms.TextBox vezeteknev;
        private System.Windows.Forms.TextBox keresztnev;
        private System.Windows.Forms.TextBox hossz;
        private System.Windows.Forms.Label udvozlo;
        private System.Windows.Forms.Label label1;
    }
}

