namespace VarazsloIskolaGUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tanonc = new System.Windows.Forms.TextBox();
            this.txt_kipurcan = new System.Windows.Forms.TextBox();
            this.txt_logas = new System.Windows.Forms.TextBox();
            this.cmb_troll = new System.Windows.Forms.ComboBox();
            this.cmb_igyekezet = new System.Windows.Forms.ComboBox();
            this.btn_mentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanonc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trollkodás";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Igyekezettan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(32, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kipurcantan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(32, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lógástan";
            // 
            // txt_tanonc
            // 
            this.txt_tanonc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_tanonc.Location = new System.Drawing.Point(146, 43);
            this.txt_tanonc.Name = "txt_tanonc";
            this.txt_tanonc.Size = new System.Drawing.Size(139, 22);
            this.txt_tanonc.TabIndex = 5;
            // 
            // txt_kipurcan
            // 
            this.txt_kipurcan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_kipurcan.Location = new System.Drawing.Point(146, 171);
            this.txt_kipurcan.Name = "txt_kipurcan";
            this.txt_kipurcan.Size = new System.Drawing.Size(100, 22);
            this.txt_kipurcan.TabIndex = 6;
            // 
            // txt_logas
            // 
            this.txt_logas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_logas.Location = new System.Drawing.Point(146, 217);
            this.txt_logas.Name = "txt_logas";
            this.txt_logas.Size = new System.Drawing.Size(100, 22);
            this.txt_logas.TabIndex = 7;
            // 
            // cmb_troll
            // 
            this.cmb_troll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmb_troll.FormattingEnabled = true;
            this.cmb_troll.Items.AddRange(new object[] {
            "Várakozáson felüli",
            "Elfogadható",
            "Hitvány",
            "Troll"});
            this.cmb_troll.Location = new System.Drawing.Point(146, 83);
            this.cmb_troll.Name = "cmb_troll";
            this.cmb_troll.Size = new System.Drawing.Size(121, 24);
            this.cmb_troll.TabIndex = 8;
            // 
            // cmb_igyekezet
            // 
            this.cmb_igyekezet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmb_igyekezet.FormattingEnabled = true;
            this.cmb_igyekezet.Items.AddRange(new object[] {
            "Várakozáson felüli",
            "Elfogadható",
            "Hitvány",
            "Borzalmas"});
            this.cmb_igyekezet.Location = new System.Drawing.Point(146, 125);
            this.cmb_igyekezet.Name = "cmb_igyekezet";
            this.cmb_igyekezet.Size = new System.Drawing.Size(121, 24);
            this.cmb_igyekezet.TabIndex = 9;
            // 
            // btn_mentes
            // 
            this.btn_mentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_mentes.Location = new System.Drawing.Point(93, 287);
            this.btn_mentes.Name = "btn_mentes";
            this.btn_mentes.Size = new System.Drawing.Size(162, 26);
            this.btn_mentes.TabIndex = 10;
            this.btn_mentes.Text = "Adatok mentése";
            this.btn_mentes.UseVisualStyleBackColor = true;
            this.btn_mentes.Click += new System.EventHandler(this.Btn_mentes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 345);
            this.Controls.Add(this.btn_mentes);
            this.Controls.Add(this.cmb_igyekezet);
            this.Controls.Add(this.cmb_troll);
            this.Controls.Add(this.txt_logas);
            this.Controls.Add(this.txt_kipurcan);
            this.Controls.Add(this.txt_tanonc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Castelobruxo Varázslóiskola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tanonc;
        private System.Windows.Forms.TextBox txt_kipurcan;
        private System.Windows.Forms.TextBox txt_logas;
        private System.Windows.Forms.ComboBox cmb_troll;
        private System.Windows.Forms.ComboBox cmb_igyekezet;
        private System.Windows.Forms.Button btn_mentes;
    }
}

