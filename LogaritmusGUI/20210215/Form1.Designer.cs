namespace _20210215
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
            this.lblDefinicio = new System.Windows.Forms.Label();
            this.pictureKep = new System.Windows.Forms.PictureBox();
            this.grbValasztas = new System.Windows.Forms.GroupBox();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKep)).BeginInit();
            this.grbValasztas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDefinicio
            // 
            this.lblDefinicio.AutoSize = true;
            this.lblDefinicio.Location = new System.Drawing.Point(15, 51);
            this.lblDefinicio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDefinicio.Name = "lblDefinicio";
            this.lblDefinicio.Size = new System.Drawing.Size(619, 66);
            this.lblDefinicio.TabIndex = 0;
            this.lblDefinicio.Text = "Definíció: \"a\" alapú logaritmus \"b\" azt a hatványkitevőt jelenti,\r\namelyre \"a\"-t " +
    "hatványozva \"b\"-t kapunk. (a>0, a<>1, b>0)\r\n";
            // 
            // pictureKep
            // 
            this.pictureKep.Image = ((System.Drawing.Image)(resources.GetObject("pictureKep.Image")));
            this.pictureKep.Location = new System.Drawing.Point(40, 130);
            this.pictureKep.Name = "pictureKep";
            this.pictureKep.Size = new System.Drawing.Size(222, 163);
            this.pictureKep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureKep.TabIndex = 1;
            this.pictureKep.TabStop = false;
            // 
            // grbValasztas
            // 
            this.grbValasztas.Controls.Add(this.radioC);
            this.grbValasztas.Controls.Add(this.radioB);
            this.grbValasztas.Controls.Add(this.radioA);
            this.grbValasztas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grbValasztas.Location = new System.Drawing.Point(304, 130);
            this.grbValasztas.Name = "grbValasztas";
            this.grbValasztas.Size = new System.Drawing.Size(148, 109);
            this.grbValasztas.TabIndex = 2;
            this.grbValasztas.TabStop = false;
            this.grbValasztas.Text = "Mit számoljunk ki?";
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Checked = true;
            this.radioC.Location = new System.Drawing.Point(6, 75);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(33, 21);
            this.radioC.TabIndex = 2;
            this.radioC.TabStop = true;
            this.radioC.Text = "c";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Checked = false;
            this.radioB.Location = new System.Drawing.Point(6, 48);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(33, 21);
            this.radioB.TabIndex = 1;
            this.radioB.TabStop = true;
            this.radioB.Text = "b";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Checked = false;
            this.radioA.Location = new System.Drawing.Point(6, 21);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(33, 21);
            this.radioA.TabIndex = 0;
            this.radioA.TabStop = true;
            this.radioA.Text = "a";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblA.Location = new System.Drawing.Point(479, 151);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(27, 17);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "a =";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblB.Location = new System.Drawing.Point(479, 182);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(27, 17);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "b =";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblC.Location = new System.Drawing.Point(479, 209);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(27, 17);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "c =";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtA.Location = new System.Drawing.Point(512, 149);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(49, 22);
            this.txtA.TabIndex = 6;
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtC.Location = new System.Drawing.Point(512, 207);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(49, 22);
            this.txtC.TabIndex = 7;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtB.Location = new System.Drawing.Point(512, 178);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(49, 22);
            this.txtB.TabIndex = 8;
            // 
            // btnSzamol
            // 
            this.btnSzamol.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzamol.Location = new System.Drawing.Point(77, 360);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(95, 27);
            this.btnSzamol.TabIndex = 9;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTorol.Location = new System.Drawing.Point(274, 360);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(95, 27);
            this.btnTorol.TabIndex = 10;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilep.Location = new System.Drawing.Point(466, 360);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(95, 27);
            this.btnKilep.TabIndex = 11;
            this.btnKilep.Text = "Kilép";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 439);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.grbValasztas);
            this.Controls.Add(this.pictureKep);
            this.Controls.Add(this.lblDefinicio);
            this.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Logaritmus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureKep)).EndInit();
            this.grbValasztas.ResumeLayout(false);
            this.grbValasztas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDefinicio;
        private System.Windows.Forms.PictureBox pictureKep;
        private System.Windows.Forms.GroupBox grbValasztas;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnKilep;
    }
}

