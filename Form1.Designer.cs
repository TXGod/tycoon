namespace IndustryTycoon
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
            Form1.moveTopImg = new System.Windows.Forms.PictureBox();
            Form1.moveLeftImg = new System.Windows.Forms.PictureBox();
            Form1.moveRightImg = new System.Windows.Forms.PictureBox();
            Form1.moveDownImg = new System.Windows.Forms.PictureBox();
            Form1.buildingImg = new System.Windows.Forms.PictureBox();
            Form1.panel1 = new System.Windows.Forms.Panel();
            Form1.dbg_1_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(Form1.moveTopImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Form1.moveLeftImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Form1.moveRightImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Form1.moveDownImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Form1.buildingImg)).BeginInit();
            Form1.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveTopImg
            // 
            Form1.moveTopImg.BackColor = System.Drawing.Color.Transparent;
            Form1.moveTopImg.Image = global::IndustryTycoon.Properties.Resources.strzałka_gora;
            Form1.moveTopImg.Location = new System.Drawing.Point(390, 12);
            Form1.moveTopImg.Name = "moveTopImg";
            Form1.moveTopImg.Size = new System.Drawing.Size(100, 100);
            Form1.moveTopImg.TabIndex = 2;
            Form1.moveTopImg.TabStop = false;
            Form1.moveTopImg.Click += new System.EventHandler(this.moveTopImg_Click);
            // 
            // moveLeftImg
            // 
            Form1.moveLeftImg.BackColor = System.Drawing.Color.Transparent;
            Form1.moveLeftImg.Image = global::IndustryTycoon.Properties.Resources.strzałka_lewo;
            Form1.moveLeftImg.Location = new System.Drawing.Point(12, 215);
            Form1.moveLeftImg.Name = "moveLeftImg";
            Form1.moveLeftImg.Size = new System.Drawing.Size(100, 100);
            Form1.moveLeftImg.TabIndex = 1;
            Form1.moveLeftImg.TabStop = false;
            Form1.moveLeftImg.Click += new System.EventHandler(this.moveLeftImg_Click);
            // 
            // moveRightImg
            // 
            Form1.moveRightImg.BackColor = System.Drawing.Color.Transparent;
            Form1.moveRightImg.Image = global::IndustryTycoon.Properties.Resources.strzałka_prawo;
            Form1.moveRightImg.Location = new System.Drawing.Point(772, 215);
            Form1.moveRightImg.Name = "moveRightImg";
            Form1.moveRightImg.Size = new System.Drawing.Size(100, 100);
            Form1.moveRightImg.TabIndex = 0;
            Form1.moveRightImg.TabStop = false;
            Form1.moveRightImg.Click += new System.EventHandler(this.moveRightImg_Click);
            // 
            // moveDownImg
            // 
            Form1.moveDownImg.BackColor = System.Drawing.Color.Transparent;
            Form1.moveDownImg.Image = global::IndustryTycoon.Properties.Resources.strzałka_dol;
            Form1.moveDownImg.Location = new System.Drawing.Point(390, 449);
            Form1.moveDownImg.Name = "moveDownImg";
            Form1.moveDownImg.Size = new System.Drawing.Size(100, 100);
            Form1.moveDownImg.TabIndex = 3;
            Form1.moveDownImg.TabStop = false;
            Form1.moveDownImg.Click += new System.EventHandler(this.moveDownImg_Click);
            // 
            // buildingImg
            // 
            Form1.buildingImg.BackColor = System.Drawing.Color.Transparent;
            Form1.buildingImg.Image = global::IndustryTycoon.Properties.Resources.building_none;
            Form1.buildingImg.Location = new System.Drawing.Point(134, 118);
            Form1.buildingImg.Name = "buildingImg";
            Form1.buildingImg.Size = new System.Drawing.Size(632, 296);
            Form1.buildingImg.TabIndex = 4;
            Form1.buildingImg.TabStop = false;
            Form1.buildingImg.Click += new System.EventHandler(this.buildingImg_Click);
            // 
            // panel1
            // 
            Form1.panel1.Controls.Add(Form1.dbg_1_lbl);
            Form1.panel1.Location = new System.Drawing.Point(12, 442);
            Form1.panel1.Name = "panel1";
            Form1.panel1.Size = new System.Drawing.Size(190, 106);
            Form1.panel1.TabIndex = 5;
            // 
            // dbg_1_lbl
            // 
            Form1.dbg_1_lbl.AutoSize = true;
            Form1.dbg_1_lbl.Location = new System.Drawing.Point(3, 7);
            Form1.dbg_1_lbl.Name = "dbg_1_lbl";
            Form1.dbg_1_lbl.Size = new System.Drawing.Size(35, 13);
            Form1.dbg_1_lbl.TabIndex = 0;
            Form1.dbg_1_lbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IndustryTycoon.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(Form1.panel1);
            this.Controls.Add(Form1.buildingImg);
            this.Controls.Add(Form1.moveDownImg);
            this.Controls.Add(Form1.moveTopImg);
            this.Controls.Add(Form1.moveLeftImg);
            this.Controls.Add(Form1.moveRightImg);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Industry Tycoon";
            this.Icon = ((System.Drawing.Icon)global::IndustryTycoon.Properties.Resources.Icon);
            ((System.ComponentModel.ISupportInitialize)(Form1.moveTopImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Form1.moveLeftImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Form1.moveRightImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Form1.moveDownImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Form1.buildingImg)).EndInit();
            Form1.panel1.ResumeLayout(false);
            Form1.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public static System.Windows.Forms.PictureBox moveRightImg;
        public static System.Windows.Forms.PictureBox moveLeftImg;
        public static System.Windows.Forms.PictureBox moveTopImg;
        public static System.Windows.Forms.PictureBox moveDownImg;
        public static System.Windows.Forms.PictureBox buildingImg;
        public static System.Windows.Forms.Panel panel1;
        public static System.Windows.Forms.Label dbg_1_lbl;

    }
}

