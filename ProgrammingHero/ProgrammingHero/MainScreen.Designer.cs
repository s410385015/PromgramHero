namespace ProgrammingHero
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.MainCharacter = new System.Windows.Forms.PictureBox();
            this.CharacterScreen = new System.Windows.Forms.GroupBox();
            this.LabelLv = new System.Windows.Forms.Label();
            this.LabelDa = new System.Windows.Forms.Label();
            this.LabelHP = new System.Windows.Forms.Label();
            this.Talker = new System.Windows.Forms.Label();
            this.OtherName = new System.Windows.Forms.Label();
            this.CharacterNext = new System.Windows.Forms.Button();
            this.CharacterText = new System.Windows.Forms.RichTextBox();
            this.OtherBox = new System.Windows.Forms.PictureBox();
            this.CharacterName = new System.Windows.Forms.Label();
            this.TutorialScreen = new System.Windows.Forms.GroupBox();
            this.TutorialPic = new System.Windows.Forms.PictureBox();
            this.TutorialNext = new System.Windows.Forms.Button();
            this.TutorialSkip = new System.Windows.Forms.Button();
            this.TutorialText = new System.Windows.Forms.RichTextBox();
            this.Showntimer = new System.Windows.Forms.Timer(this.components);
            this.LabelOHP = new System.Windows.Forms.Label();
            this.FuncButton = new System.Windows.Forms.Button();
            this.LabelODa = new System.Windows.Forms.Label();
            this.EscapeButton = new System.Windows.Forms.Button();
            this.FightButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainCharacter)).BeginInit();
            this.CharacterScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherBox)).BeginInit();
            this.TutorialScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TutorialPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainCharacter
            // 
            this.MainCharacter.Location = new System.Drawing.Point(67, 86);
            this.MainCharacter.Name = "MainCharacter";
            this.MainCharacter.Size = new System.Drawing.Size(281, 360);
            this.MainCharacter.TabIndex = 0;
            this.MainCharacter.TabStop = false;
            this.MainCharacter.Click += new System.EventHandler(this.MainCharacter_Click);
            // 
            // CharacterScreen
            // 
            this.CharacterScreen.Controls.Add(this.FightButton);
            this.CharacterScreen.Controls.Add(this.EscapeButton);
            this.CharacterScreen.Controls.Add(this.LabelODa);
            this.CharacterScreen.Controls.Add(this.FuncButton);
            this.CharacterScreen.Controls.Add(this.LabelOHP);
            this.CharacterScreen.Controls.Add(this.LabelLv);
            this.CharacterScreen.Controls.Add(this.LabelDa);
            this.CharacterScreen.Controls.Add(this.LabelHP);
            this.CharacterScreen.Controls.Add(this.Talker);
            this.CharacterScreen.Controls.Add(this.OtherName);
            this.CharacterScreen.Controls.Add(this.CharacterNext);
            this.CharacterScreen.Controls.Add(this.CharacterText);
            this.CharacterScreen.Controls.Add(this.OtherBox);
            this.CharacterScreen.Controls.Add(this.CharacterName);
            this.CharacterScreen.Controls.Add(this.MainCharacter);
            this.CharacterScreen.Location = new System.Drawing.Point(1, 3);
            this.CharacterScreen.Name = "CharacterScreen";
            this.CharacterScreen.Size = new System.Drawing.Size(1044, 621);
            this.CharacterScreen.TabIndex = 1;
            this.CharacterScreen.TabStop = false;
            this.CharacterScreen.Enter += new System.EventHandler(this.CharacterScreen_Enter);
            // 
            // LabelLv
            // 
            this.LabelLv.AutoSize = true;
            this.LabelLv.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelLv.Location = new System.Drawing.Point(356, 97);
            this.LabelLv.Name = "LabelLv";
            this.LabelLv.Size = new System.Drawing.Size(29, 20);
            this.LabelLv.TabIndex = 9;
            this.LabelLv.Text = "Lv";
            // 
            // LabelDa
            // 
            this.LabelDa.AutoSize = true;
            this.LabelDa.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelDa.Location = new System.Drawing.Point(355, 160);
            this.LabelDa.Name = "LabelDa";
            this.LabelDa.Size = new System.Drawing.Size(31, 20);
            this.LabelDa.TabIndex = 8;
            this.LabelDa.Text = "Da";
            // 
            // LabelHP
            // 
            this.LabelHP.AutoSize = true;
            this.LabelHP.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelHP.Location = new System.Drawing.Point(354, 128);
            this.LabelHP.Name = "LabelHP";
            this.LabelHP.Size = new System.Drawing.Size(32, 20);
            this.LabelHP.TabIndex = 7;
            this.LabelHP.Text = "Hp";
            // 
            // Talker
            // 
            this.Talker.AutoSize = true;
            this.Talker.BackColor = System.Drawing.Color.Black;
            this.Talker.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Talker.ForeColor = System.Drawing.Color.White;
            this.Talker.Location = new System.Drawing.Point(63, 470);
            this.Talker.Name = "Talker";
            this.Talker.Size = new System.Drawing.Size(64, 24);
            this.Talker.TabIndex = 6;
            this.Talker.Text = "label1";
            // 
            // OtherName
            // 
            this.OtherName.AutoSize = true;
            this.OtherName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OtherName.Location = new System.Drawing.Point(555, 51);
            this.OtherName.Name = "OtherName";
            this.OtherName.Size = new System.Drawing.Size(83, 30);
            this.OtherName.TabIndex = 5;
            this.OtherName.Text = "label1";
            // 
            // CharacterNext
            // 
            this.CharacterNext.Location = new System.Drawing.Point(902, 497);
            this.CharacterNext.Name = "CharacterNext";
            this.CharacterNext.Size = new System.Drawing.Size(73, 78);
            this.CharacterNext.TabIndex = 4;
            this.CharacterNext.Text = "下一步";
            this.CharacterNext.UseVisualStyleBackColor = true;
            this.CharacterNext.Click += new System.EventHandler(this.CharacterNext_Click);
            // 
            // CharacterText
            // 
            this.CharacterText.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CharacterText.Location = new System.Drawing.Point(67, 497);
            this.CharacterText.Name = "CharacterText";
            this.CharacterText.Size = new System.Drawing.Size(810, 78);
            this.CharacterText.TabIndex = 3;
            this.CharacterText.Text = "";
            // 
            // OtherBox
            // 
            this.OtherBox.Location = new System.Drawing.Point(560, 88);
            this.OtherBox.Name = "OtherBox";
            this.OtherBox.Size = new System.Drawing.Size(349, 360);
            this.OtherBox.TabIndex = 2;
            this.OtherBox.TabStop = false;
            // 
            // CharacterName
            // 
            this.CharacterName.AutoSize = true;
            this.CharacterName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CharacterName.Location = new System.Drawing.Point(62, 51);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(81, 30);
            this.CharacterName.TabIndex = 1;
            this.CharacterName.Text = "Name";
            this.CharacterName.Click += new System.EventHandler(this.CharacterName_Click);
            // 
            // TutorialScreen
            // 
            this.TutorialScreen.Controls.Add(this.TutorialPic);
            this.TutorialScreen.Controls.Add(this.TutorialNext);
            this.TutorialScreen.Controls.Add(this.TutorialSkip);
            this.TutorialScreen.Controls.Add(this.TutorialText);
            this.TutorialScreen.Location = new System.Drawing.Point(1, 3);
            this.TutorialScreen.Name = "TutorialScreen";
            this.TutorialScreen.Size = new System.Drawing.Size(1055, 606);
            this.TutorialScreen.TabIndex = 4;
            this.TutorialScreen.TabStop = false;
            // 
            // TutorialPic
            // 
            this.TutorialPic.BackColor = System.Drawing.Color.White;
            this.TutorialPic.Location = new System.Drawing.Point(0, 0);
            this.TutorialPic.Name = "TutorialPic";
            this.TutorialPic.Size = new System.Drawing.Size(1038, 483);
            this.TutorialPic.TabIndex = 0;
            this.TutorialPic.TabStop = false;
            this.TutorialPic.Click += new System.EventHandler(this.TurtorialPic_Click);
            // 
            // TutorialNext
            // 
            this.TutorialNext.Location = new System.Drawing.Point(915, 489);
            this.TutorialNext.Name = "TutorialNext";
            this.TutorialNext.Size = new System.Drawing.Size(123, 126);
            this.TutorialNext.TabIndex = 3;
            this.TutorialNext.Text = "下一步";
            this.TutorialNext.UseVisualStyleBackColor = true;
            this.TutorialNext.Click += new System.EventHandler(this.TutorialNext_Click);
            // 
            // TutorialSkip
            // 
            this.TutorialSkip.Location = new System.Drawing.Point(963, 10);
            this.TutorialSkip.Name = "TutorialSkip";
            this.TutorialSkip.Size = new System.Drawing.Size(75, 23);
            this.TutorialSkip.TabIndex = 2;
            this.TutorialSkip.Text = "Skip";
            this.TutorialSkip.UseVisualStyleBackColor = true;
            this.TutorialSkip.Click += new System.EventHandler(this.TutorialSkip_Click);
            // 
            // TutorialText
            // 
            this.TutorialText.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TutorialText.Location = new System.Drawing.Point(1, 489);
            this.TutorialText.Name = "TutorialText";
            this.TutorialText.ReadOnly = true;
            this.TutorialText.Size = new System.Drawing.Size(908, 117);
            this.TutorialText.TabIndex = 1;
            this.TutorialText.Text = "";
            this.TutorialText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TurtorialText_MouseClick);
            this.TutorialText.TextChanged += new System.EventHandler(this.TurtorialText_TextChanged);
            // 
            // Showntimer
            // 
            this.Showntimer.Tick += new System.EventHandler(this.Showntimer_Tick);
            // 
            // LabelOHP
            // 
            this.LabelOHP.AutoSize = true;
            this.LabelOHP.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelOHP.Location = new System.Drawing.Point(926, 88);
            this.LabelOHP.Name = "LabelOHP";
            this.LabelOHP.Size = new System.Drawing.Size(33, 20);
            this.LabelOHP.TabIndex = 11;
            this.LabelOHP.Text = "HP";
            // 
            // FuncButton
            // 
            this.FuncButton.ForeColor = System.Drawing.Color.Red;
            this.FuncButton.Location = new System.Drawing.Point(408, 207);
            this.FuncButton.Name = "FuncButton";
            this.FuncButton.Size = new System.Drawing.Size(83, 77);
            this.FuncButton.TabIndex = 12;
            this.FuncButton.UseVisualStyleBackColor = true;
            this.FuncButton.Click += new System.EventHandler(this.FuncButton_Click);
            // 
            // LabelODa
            // 
            this.LabelODa.AutoSize = true;
            this.LabelODa.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelODa.Location = new System.Drawing.Point(928, 119);
            this.LabelODa.Name = "LabelODa";
            this.LabelODa.Size = new System.Drawing.Size(31, 20);
            this.LabelODa.TabIndex = 13;
            this.LabelODa.Text = "Da";
            this.LabelODa.Click += new System.EventHandler(this.label1_Click);
            // 
            // EscapeButton
            // 
            this.EscapeButton.Location = new System.Drawing.Point(386, 313);
            this.EscapeButton.Name = "EscapeButton";
            this.EscapeButton.Size = new System.Drawing.Size(137, 48);
            this.EscapeButton.TabIndex = 14;
            this.EscapeButton.Text = "Escape";
            this.EscapeButton.UseVisualStyleBackColor = true;
            this.EscapeButton.Click += new System.EventHandler(this.EscapeButton_Click);
            // 
            // FightButton
            // 
            this.FightButton.Location = new System.Drawing.Point(386, 386);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(137, 48);
            this.FightButton.TabIndex = 15;
            this.FightButton.Text = "Fight";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 621);
            this.Controls.Add(this.CharacterScreen);
            this.Controls.Add(this.TutorialScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "程式英雄";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainCharacter)).EndInit();
            this.CharacterScreen.ResumeLayout(false);
            this.CharacterScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherBox)).EndInit();
            this.TutorialScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TutorialPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainCharacter;
        private System.Windows.Forms.GroupBox CharacterScreen;
        private System.Windows.Forms.Label CharacterName;
        private System.Windows.Forms.GroupBox TutorialScreen;
        private System.Windows.Forms.Button TutorialSkip;
        private System.Windows.Forms.RichTextBox TutorialText;
        private System.Windows.Forms.PictureBox TutorialPic;
        private System.Windows.Forms.Button TutorialNext;
        private System.Windows.Forms.Timer Showntimer;
        private System.Windows.Forms.Button CharacterNext;
        private System.Windows.Forms.RichTextBox CharacterText;
        private System.Windows.Forms.PictureBox OtherBox;
        private System.Windows.Forms.Label OtherName;
        private System.Windows.Forms.Label Talker;
        private System.Windows.Forms.Label LabelHP;
        private System.Windows.Forms.Label LabelDa;
        private System.Windows.Forms.Label LabelLv;
        private System.Windows.Forms.Label LabelOHP;
        private System.Windows.Forms.Button FuncButton;
        private System.Windows.Forms.Label LabelODa;
        private System.Windows.Forms.Button FightButton;
        private System.Windows.Forms.Button EscapeButton;
    }
}