namespace F01
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = System.Drawing.Color.PaleGoldenrod;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label8.ForeColor = System.Drawing.Color.Brown;
            label8.Location = new System.Drawing.Point(406, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(109, 39);
            label8.TabIndex = 2;
            label8.Text = "00:00";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "00:00:00";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(160, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 39);
            this.label7.TabIndex = 1;
            this.label7.Text = "#######";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(512, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 39);
            this.label9.TabIndex = 3;
            this.label9.Text = "Hátra";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(618, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 39);
            this.label10.TabIndex = 4;
            this.label10.Text = "00:00:00";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(769, 36);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hátra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer2;
    }
}

