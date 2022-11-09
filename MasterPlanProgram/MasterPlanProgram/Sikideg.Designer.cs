
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hengerBtn = new System.Windows.Forms.PictureBox();
            this.gulaBtn = new System.Windows.Forms.PictureBox();
            this.gombBtn = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hengerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gulaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gombBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hengerBtn);
            this.groupBox1.Controls.Add(this.gulaBtn);
            this.groupBox1.Controls.Add(this.gombBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Térbeli Alakzatok";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Számol";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Sikideg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Sikideg";
            this.Text = "Sikideg";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hengerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gulaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gombBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox hengerBtn;
        private System.Windows.Forms.PictureBox gulaBtn;
        private System.Windows.Forms.PictureBox gombBtn;
        private System.Windows.Forms.Button button1;
    }
}