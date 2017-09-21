namespace ProgrammingHero
{
    partial class Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request));
            this.myText = new System.Windows.Forms.RichTextBox();
            this.Complete = new System.Windows.Forms.Button();
            this.RequestLabel = new System.Windows.Forms.Label();
            this.Hint = new System.Windows.Forms.CheckBox();
            this.Reset = new System.Windows.Forms.Button();
            this.RequestBox = new System.Windows.Forms.RichTextBox();
            this.HintBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // myText
            // 
            this.myText.Location = new System.Drawing.Point(13, 13);
            this.myText.Name = "myText";
            this.myText.Size = new System.Drawing.Size(316, 343);
            this.myText.TabIndex = 0;
            this.myText.Text = "";
            // 
            // Complete
            // 
            this.Complete.Location = new System.Drawing.Point(25, 362);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(75, 35);
            this.Complete.TabIndex = 1;
            this.Complete.Text = "提交";
            this.Complete.UseVisualStyleBackColor = true;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // RequestLabel
            // 
            this.RequestLabel.AutoSize = true;
            this.RequestLabel.Location = new System.Drawing.Point(345, 13);
            this.RequestLabel.Name = "RequestLabel";
            this.RequestLabel.Size = new System.Drawing.Size(67, 15);
            this.RequestLabel.TabIndex = 2;
            this.RequestLabel.Text = "任務訊息";
            // 
            // Hint
            // 
            this.Hint.AutoSize = true;
            this.Hint.Location = new System.Drawing.Point(348, 203);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(89, 19);
            this.Hint.TabIndex = 4;
            this.Hint.Text = "顯示提示";
            this.Hint.UseVisualStyleBackColor = true;
            this.Hint.CheckedChanged += new System.EventHandler(this.Hint_CheckedChanged);
            this.Hint.Click += new System.EventHandler(this.Hint_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(233, 362);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 35);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "清除";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // RequestBox
            // 
            this.RequestBox.Location = new System.Drawing.Point(348, 32);
            this.RequestBox.Name = "RequestBox";
            this.RequestBox.ReadOnly = true;
            this.RequestBox.Size = new System.Drawing.Size(358, 165);
            this.RequestBox.TabIndex = 7;
            this.RequestBox.Text = "";
            // 
            // HintBox
            // 
            this.HintBox.Location = new System.Drawing.Point(348, 229);
            this.HintBox.Name = "HintBox";
            this.HintBox.Size = new System.Drawing.Size(358, 127);
            this.HintBox.TabIndex = 8;
            this.HintBox.Text = "";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 405);
            this.Controls.Add(this.HintBox);
            this.Controls.Add(this.RequestBox);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Hint);
            this.Controls.Add(this.RequestLabel);
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.myText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Request";
            this.Text = "任務清單";
            this.Load += new System.EventHandler(this.RequestBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox myText;
        private System.Windows.Forms.Button Complete;
        private System.Windows.Forms.Label RequestLabel;
        private System.Windows.Forms.CheckBox Hint;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.RichTextBox RequestBox;
        private System.Windows.Forms.RichTextBox HintBox;
    }
}