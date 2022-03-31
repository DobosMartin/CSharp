namespace IskolaGUI
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
            this.lbx_adatok = new System.Windows.Forms.ListBox();
            this.btn_torol = new System.Windows.Forms.Button();
            this.btn_mentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_adatok
            // 
            this.lbx_adatok.FormattingEnabled = true;
            this.lbx_adatok.Location = new System.Drawing.Point(27, 20);
            this.lbx_adatok.Name = "lbx_adatok";
            this.lbx_adatok.Size = new System.Drawing.Size(292, 472);
            this.lbx_adatok.TabIndex = 0;
            // 
            // btn_torol
            // 
            this.btn_torol.Location = new System.Drawing.Point(27, 522);
            this.btn_torol.Name = "btn_torol";
            this.btn_torol.Size = new System.Drawing.Size(113, 23);
            this.btn_torol.TabIndex = 1;
            this.btn_torol.Text = "Törlés";
            this.btn_torol.UseVisualStyleBackColor = true;
            this.btn_torol.Click += new System.EventHandler(this.btn_torol_Click);
            // 
            // btn_mentes
            // 
            this.btn_mentes.Location = new System.Drawing.Point(188, 522);
            this.btn_mentes.Name = "btn_mentes";
            this.btn_mentes.Size = new System.Drawing.Size(131, 23);
            this.btn_mentes.TabIndex = 2;
            this.btn_mentes.Text = "Állomány mentése";
            this.btn_mentes.UseVisualStyleBackColor = true;
            this.btn_mentes.Click += new System.EventHandler(this.btn_mentes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 570);
            this.Controls.Add(this.btn_mentes);
            this.Controls.Add(this.btn_torol);
            this.Controls.Add(this.lbx_adatok);
            this.Name = "Form1";
            this.Text = "Iskola GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_adatok;
        private System.Windows.Forms.Button btn_torol;
        private System.Windows.Forms.Button btn_mentes;
    }
}

