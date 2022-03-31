
namespace Film
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.PictureBox();
            this.btnfrissit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbezar = new System.Windows.Forms.PictureBox();
            this.btnminmax = new System.Windows.Forms.PictureBox();
            this.btntalca = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfrissit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbezar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btntalca)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(108, 94);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(594, 284);
            this.listBox2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Controls.Add(this.btnfrissit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnbezar);
            this.panel1.Controls.Add(this.btnminmax);
            this.panel1.Controls.Add(this.btntalca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 11;
            // 
            // btnhome
            // 
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.Location = new System.Drawing.Point(175, 7);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(34, 28);
            this.btnhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnhome.TabIndex = 6;
            this.btnhome.TabStop = false;
            this.btnhome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnhome_MouseClick);
            // 
            // btnfrissit
            // 
            this.btnfrissit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfrissit.Image = ((System.Drawing.Image)(resources.GetObject("btnfrissit.Image")));
            this.btnfrissit.Location = new System.Drawing.Point(129, 7);
            this.btnfrissit.Name = "btnfrissit";
            this.btnfrissit.Size = new System.Drawing.Size(34, 28);
            this.btnfrissit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnfrissit.TabIndex = 5;
            this.btnfrissit.TabStop = false;
            this.btnfrissit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnfrissit_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(311, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Megtekintett sorozatok";
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
            this.btnbezar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbezar_MouseClick);
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
            this.btnminmax.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnminmax_MouseClick);
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
            this.btntalca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btntalca_MouseClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfrissit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbezar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btntalca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnhome;
        private System.Windows.Forms.PictureBox btnfrissit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnbezar;
        private System.Windows.Forms.PictureBox btnminmax;
        private System.Windows.Forms.PictureBox btntalca;
    }
}