
namespace Film
{
    partial class Kereso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kereso));
            this.txtkereso = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.PictureBox();
            this.btnbezar = new System.Windows.Forms.PictureBox();
            this.btnminmax = new System.Windows.Forms.PictureBox();
            this.btntalca = new System.Windows.Forms.PictureBox();
            this.lbxhiden = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbezar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btntalca)).BeginInit();
            this.SuspendLayout();
            // 
            // txtkereso
            // 
            this.txtkereso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtkereso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtkereso.Location = new System.Drawing.Point(255, 12);
            this.txtkereso.Name = "txtkereso";
            this.txtkereso.Size = new System.Drawing.Size(284, 22);
            this.txtkereso.TabIndex = 0;
            this.txtkereso.TextChanged += new System.EventHandler(this.txtkereso_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Controls.Add(this.txtkereso);
            this.panel1.Controls.Add(this.btnbezar);
            this.panel1.Controls.Add(this.btnminmax);
            this.panel1.Controls.Add(this.btntalca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 9;
            // 
            // btnhome
            // 
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.Location = new System.Drawing.Point(175, 7);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(34, 28);
            this.btnhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnhome.TabIndex = 4;
            this.btnhome.TabStop = false;
            this.btnhome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnhome_MouseClick);
            // 
            // btnbezar
            // 
            this.btnbezar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbezar.Image = ((System.Drawing.Image)(resources.GetObject("btnbezar.Image")));
            this.btnbezar.Location = new System.Drawing.Point(772, 15);
            this.btnbezar.Name = "btnbezar";
            this.btnbezar.Size = new System.Drawing.Size(16, 16);
            this.btnbezar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnbezar.TabIndex = 0;
            this.btnbezar.TabStop = false;
            this.btnbezar.Click += new System.EventHandler(this.btnbezar_Click);
            // 
            // btnminmax
            // 
            this.btnminmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminmax.Image = ((System.Drawing.Image)(resources.GetObject("btnminmax.Image")));
            this.btnminmax.Location = new System.Drawing.Point(750, 15);
            this.btnminmax.Name = "btnminmax";
            this.btnminmax.Size = new System.Drawing.Size(16, 16);
            this.btnminmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminmax.TabIndex = 1;
            this.btnminmax.TabStop = false;
            this.btnminmax.Click += new System.EventHandler(this.btnminmax_Click);
            // 
            // btntalca
            // 
            this.btntalca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntalca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntalca.Image = ((System.Drawing.Image)(resources.GetObject("btntalca.Image")));
            this.btntalca.Location = new System.Drawing.Point(728, 15);
            this.btntalca.Name = "btntalca";
            this.btntalca.Size = new System.Drawing.Size(16, 16);
            this.btntalca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btntalca.TabIndex = 2;
            this.btntalca.TabStop = false;
            this.btntalca.Click += new System.EventHandler(this.btntalca_Click);
            // 
            // lbxhiden
            // 
            this.lbxhiden.FormattingEnabled = true;
            this.lbxhiden.Location = new System.Drawing.Point(0, 433);
            this.lbxhiden.Name = "lbxhiden";
            this.lbxhiden.Size = new System.Drawing.Size(27, 17);
            this.lbxhiden.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(135, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(517, 300);
            this.listBox1.TabIndex = 10;
            // 
            // Kereso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbxhiden);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kereso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kereso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbezar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btntalca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtkereso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btntalca;
        private System.Windows.Forms.PictureBox btnminmax;
        private System.Windows.Forms.PictureBox btnbezar;
        private System.Windows.Forms.ListBox lbxhiden;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox btnhome;
    }
}