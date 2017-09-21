namespace ProgrammingHero
{
    partial class CreateHero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateHero));
            this.CreateButton = new System.Windows.Forms.Button();
            this.HeroBox = new System.Windows.Forms.PictureBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BrushColor = new System.Windows.Forms.ColorDialog();
            this.Pcolor = new System.Windows.Forms.PictureBox();
            this.Lcolor = new System.Windows.Forms.Label();
            this.BrushSize = new System.Windows.Forms.ComboBox();
            this.Lsize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeroBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcolor)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CreateButton.Location = new System.Drawing.Point(12, 428);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 30);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "創建";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // HeroBox
            // 
            this.HeroBox.BackColor = System.Drawing.Color.White;
            this.HeroBox.Location = new System.Drawing.Point(12, 12);
            this.HeroBox.Name = "HeroBox";
            this.HeroBox.Size = new System.Drawing.Size(323, 399);
            this.HeroBox.TabIndex = 1;
            this.HeroBox.TabStop = false;
            this.HeroBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeroBox_MouseDown);
            this.HeroBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeroBox_MouseMove);
            this.HeroBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeroBox_MouseUp);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ResetButton.Location = new System.Drawing.Point(206, 428);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 30);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "清除";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Pcolor
            // 
            this.Pcolor.BackColor = System.Drawing.Color.Black;
            this.Pcolor.Location = new System.Drawing.Point(396, 12);
            this.Pcolor.Name = "Pcolor";
            this.Pcolor.Size = new System.Drawing.Size(36, 36);
            this.Pcolor.TabIndex = 3;
            this.Pcolor.TabStop = false;
            this.Pcolor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pcolor_MouseClick);
            // 
            // Lcolor
            // 
            this.Lcolor.AutoSize = true;
            this.Lcolor.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lcolor.Location = new System.Drawing.Point(341, 28);
            this.Lcolor.Name = "Lcolor";
            this.Lcolor.Size = new System.Drawing.Size(49, 20);
            this.Lcolor.TabIndex = 4;
            this.Lcolor.Text = "顏色";
            // 
            // BrushSize
            // 
            this.BrushSize.Location = new System.Drawing.Point(396, 82);
            this.BrushSize.Name = "BrushSize";
            this.BrushSize.Size = new System.Drawing.Size(89, 23);
            this.BrushSize.TabIndex = 5;
            this.BrushSize.Text = "10";
            this.BrushSize.SelectedIndexChanged += new System.EventHandler(this.BrushSize_SelectedIndexChanged);
            // 
            // Lsize
            // 
            this.Lsize.AutoSize = true;
            this.Lsize.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lsize.Location = new System.Drawing.Point(341, 85);
            this.Lsize.Name = "Lsize";
            this.Lsize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lsize.Size = new System.Drawing.Size(49, 20);
            this.Lsize.TabIndex = 6;
            this.Lsize.Text = "粗細";
            // 
            // CreateHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 470);
            this.Controls.Add(this.Lsize);
            this.Controls.Add(this.BrushSize);
            this.Controls.Add(this.Lcolor);
            this.Controls.Add(this.Pcolor);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.HeroBox);
            this.Controls.Add(this.CreateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateHero";
            this.Text = "創造英雄";
            this.Load += new System.EventHandler(this.CreateHero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeroBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcolor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.PictureBox HeroBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ColorDialog BrushColor;
        private System.Windows.Forms.PictureBox Pcolor;
        private System.Windows.Forms.Label Lcolor;
        private System.Windows.Forms.ComboBox BrushSize;
        private System.Windows.Forms.Label Lsize;
    }
}