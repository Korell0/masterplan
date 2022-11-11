
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(555, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kerület: ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(555, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Terület: ";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(627, 369);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(627, 403);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Visible = false;
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetBtn.Location = new System.Drawing.Point(104, 332);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 30);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Visible = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Sikideg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.PictureBox hengerBtn;
        private System.Windows.Forms.PictureBox gulaBtn;
        private System.Windows.Forms.PictureBox gombBtn;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button resetBtn;
    }
}