namespace ProgrammingHero
{
    partial class LevelUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelUP));
            this.addrequest = new System.Windows.Forms.TextBox();
            this.ex = new System.Windows.Forms.RichTextBox();
            this.lvup = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Label();
            this.ablitylist = new System.Windows.Forms.ListBox();
            this.Hint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addrequest
            // 
            this.addrequest.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addrequest.Location = new System.Drawing.Point(13, 46);
            this.addrequest.Name = "addrequest";
            this.addrequest.Size = new System.Drawing.Size(507, 31);
            this.addrequest.TabIndex = 0;
            this.addrequest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addrequest_KeyDown);
            this.addrequest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addrequest_KeyPress);
            // 
            // ex
            // 
            this.ex.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ex.Location = new System.Drawing.Point(219, 102);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(301, 201);
            this.ex.TabIndex = 1;
            this.ex.Text = "";
            // 
            // lvup
            // 
            this.lvup.Location = new System.Drawing.Point(12, 280);
            this.lvup.Name = "lvup";
            this.lvup.Size = new System.Drawing.Size(183, 48);
            this.lvup.TabIndex = 2;
            this.lvup.Text = "升等";
            this.lvup.UseVisualStyleBackColor = true;
            this.lvup.Click += new System.EventHandler(this.lvup_Click);
            // 
            // Point
            // 
            this.Point.AutoSize = true;
            this.Point.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Point.Location = new System.Drawing.Point(12, 15);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(99, 20);
            this.Point.TabIndex = 3;
            this.Point.Text = "剩餘點數: ";
            // 
            // ablitylist
            // 
            this.ablitylist.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ablitylist.FormattingEnabled = true;
            this.ablitylist.ItemHeight = 20;
            this.ablitylist.Location = new System.Drawing.Point(13, 102);
            this.ablitylist.Name = "ablitylist";
            this.ablitylist.Size = new System.Drawing.Size(182, 144);
            this.ablitylist.TabIndex = 4;
            this.ablitylist.SelectedIndexChanged += new System.EventHandler(this.ablitylist_SelectedIndexChanged);
            // 
            // Hint
            // 
            this.Hint.Location = new System.Drawing.Point(461, 13);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(75, 23);
            this.Hint.TabIndex = 5;
            this.Hint.Text = "提示";
            this.Hint.UseVisualStyleBackColor = true;
            this.Hint.Click += new System.EventHandler(this.Hint_Click);
            // 
            // LevelUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 340);
            this.Controls.Add(this.Hint);
            this.Controls.Add(this.ablitylist);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.lvup);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.addrequest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LevelUP";
            this.Text = "等級上升";
            this.Load += new System.EventHandler(this.LevelUP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addrequest;
        private System.Windows.Forms.RichTextBox ex;
        private System.Windows.Forms.Button lvup;
        private System.Windows.Forms.Label Point;
        private System.Windows.Forms.ListBox ablitylist;
        private System.Windows.Forms.Button Hint;
    }
}