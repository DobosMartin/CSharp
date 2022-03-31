namespace _20210929
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
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_evszak = new System.Windows.Forms.Label();
            this.btn_evszak = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.txt_evszak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(12, 68);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(104, 13);
            this.lbl_type.TabIndex = 0;
            this.lbl_type.Text = "Hónapok sorszáma: ";
            // 
            // lbl_evszak
            // 
            this.lbl_evszak.AutoSize = true;
            this.lbl_evszak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_evszak.Location = new System.Drawing.Point(118, 135);
            this.lbl_evszak.Name = "lbl_evszak";
            this.lbl_evszak.Size = new System.Drawing.Size(103, 24);
            this.lbl_evszak.TabIndex = 1;
            this.lbl_evszak.Text = "Az évszak";
            // 
            // btn_evszak
            // 
            this.btn_evszak.Location = new System.Drawing.Point(23, 191);
            this.btn_evszak.Name = "btn_evszak";
            this.btn_evszak.Size = new System.Drawing.Size(92, 39);
            this.btn_evszak.TabIndex = 2;
            this.btn_evszak.Text = "Évszak";
            this.btn_evszak.UseVisualStyleBackColor = true;
            this.btn_evszak.Click += new System.EventHandler(this.Btn_evszak_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.Location = new System.Drawing.Point(210, 191);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(100, 38);
            this.btn_kilep.TabIndex = 3;
            this.btn_kilep.Text = "Kilépés";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.Btn_kilep_Click);
            // 
            // txt_evszak
            // 
            this.txt_evszak.Location = new System.Drawing.Point(122, 65);
            this.txt_evszak.Name = "txt_evszak";
            this.txt_evszak.Size = new System.Drawing.Size(116, 20);
            this.txt_evszak.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 245);
            this.Controls.Add(this.txt_evszak);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_evszak);
            this.Controls.Add(this.lbl_evszak);
            this.Controls.Add(this.lbl_type);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_evszak;
        private System.Windows.Forms.Button btn_evszak;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.TextBox txt_evszak;
    }
}

