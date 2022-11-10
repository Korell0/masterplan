
namespace MasterPlanProgram
{
    partial class Sikideg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sikideg));
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.hengerBtn = new System.Windows.Forms.PictureBox();
            this.gulaBtn = new System.Windows.Forms.PictureBox();
            this.gombBtn = new System.Windows.Forms.PictureBox();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hengerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gulaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gombBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.hengerBtn);
            this.groupbox1.Controls.Add(this.gulaBtn);
            this.groupbox1.Controls.Add(this.gombBtn);
            this.groupbox1.Location = new System.Drawing.Point(12, 12);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(810, 70);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Térbeli Alakzatok";
            this.groupbox1.Visible = false;
            // 
            // hengerBtn
            // 
            this.hengerBtn.Image = ((System.Drawing.Image)(resources.GetObject("hengerBtn.Image")));
            this.hengerBtn.Location = new System.Drawing.Point(577, 13);
            this.hengerBtn.Name = "hengerBtn";
            this.hengerBtn.Size = new System.Drawing.Size(50, 50);
            this.hengerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hengerBtn.TabIndex = 2;
            this.hengerBtn.TabStop = false;
            this.hengerBtn.Click += new System.EventHandler(this.hengerBtn_Click);
            // 
            // gulaBtn
            // 
            this.gulaBtn.Image = ((System.Drawing.Image)(resources.GetObject("gulaBtn.Image")));
            this.gulaBtn.Location = new System.Drawing.Point(382, 13);
            this.gulaBtn.Name = "gulaBtn";
            this.gulaBtn.Size = new System.Drawing.Size(50, 50);
            this.gulaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gulaBtn.TabIndex = 2;
            this.gulaBtn.TabStop = false;
            this.gulaBtn.Click += new System.EventHandler(this.gulaBtn_Click);
            // 
            // gombBtn
            // 
            this.gombBtn.Image = ((System.Drawing.Image)(resources.GetObject("gombBtn.Image")));
            this.gombBtn.Location = new System.Drawing.Point(164, 13);
            this.gombBtn.Name = "gombBtn";
            this.gombBtn.Size = new System.Drawing.Size(50, 50);
            this.gombBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gombBtn.TabIndex = 1;
            this.gombBtn.TabStop = false;
            this.gombBtn.Click += new System.EventHandler(this.gombBtn_Click);
            // 
            // groupbox2
            // 
            this.groupbox2.Location = new System.Drawing.Point(12, 88);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(810, 70);
            this.groupbox2.TabIndex = 2;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Síkbeli alakzatok";
            this.groupbox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(545, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Sikideg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupbox1);
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Sikideg";
            this.Text = "Sikideg";
            this.groupbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hengerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gulaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gombBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.PictureBox hengerBtn;
        private System.Windows.Forms.PictureBox gulaBtn;
        private System.Windows.Forms.PictureBox gombBtn;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}