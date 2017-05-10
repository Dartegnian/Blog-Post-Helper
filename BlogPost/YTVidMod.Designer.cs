namespace BlogPost
{
    partial class YTVidMod
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VideoLink = new System.Windows.Forms.RichTextBox();
            this.EmbedCode = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(33)))), ((int)(((byte)(23)))));
            this.ClearButton.Location = new System.Drawing.Point(447, 247);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(176, 58);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(33)))), ((int)(((byte)(23)))));
            this.label2.Location = new System.Drawing.Point(698, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "Output Embed Code";
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.White;
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.ConvertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(33)))), ((int)(((byte)(23)))));
            this.ConvertButton.Location = new System.Drawing.Point(447, 183);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(176, 58);
            this.ConvertButton.TabIndex = 10;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(33)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(60, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Source YouTube Video";
            // 
            // VideoLink
            // 
            this.VideoLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.VideoLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VideoLink.DetectUrls = false;
            this.VideoLink.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.VideoLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(33)))), ((int)(((byte)(23)))));
            this.VideoLink.Location = new System.Drawing.Point(3, 49);
            this.VideoLink.Name = "VideoLink";
            this.VideoLink.Size = new System.Drawing.Size(438, 396);
            this.VideoLink.TabIndex = 14;
            this.VideoLink.Text = "";
            // 
            // EmbedCode
            // 
            this.EmbedCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.EmbedCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmbedCode.DetectUrls = false;
            this.EmbedCode.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.EmbedCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(33)))), ((int)(((byte)(23)))));
            this.EmbedCode.Location = new System.Drawing.Point(629, 49);
            this.EmbedCode.Name = "EmbedCode";
            this.EmbedCode.Size = new System.Drawing.Size(438, 396);
            this.EmbedCode.TabIndex = 15;
            this.EmbedCode.Text = "";
            // 
            // YTVidMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EmbedCode);
            this.Controls.Add(this.VideoLink);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "YTVidMod";
            this.Size = new System.Drawing.Size(1070, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox VideoLink;
        private System.Windows.Forms.RichTextBox EmbedCode;
    }
}
