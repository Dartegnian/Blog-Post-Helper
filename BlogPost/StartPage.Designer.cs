namespace BlogPost
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MainPane = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.YouTubeButton = new System.Windows.Forms.Button();
            this.CustomButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.MainPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(163)))), ((int)(((byte)(82)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 35F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blog Writer Helper";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(163)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 112);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(163)))), ((int)(((byte)(82)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(386, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "v1.3";
            // 
            // MainPane
            // 
            this.MainPane.BackColor = System.Drawing.Color.White;
            this.MainPane.Controls.Add(this.pictureBox1);
            this.MainPane.Location = new System.Drawing.Point(12, 181);
            this.MainPane.Name = "MainPane";
            this.MainPane.Size = new System.Drawing.Size(1070, 448);
            this.MainPane.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(241, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 189);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ModifyButton
            // 
            this.ModifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(163)))), ((int)(((byte)(82)))));
            this.ModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyButton.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.ModifyButton.ForeColor = System.Drawing.Color.White;
            this.ModifyButton.Location = new System.Drawing.Point(210, 119);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(208, 46);
            this.ModifyButton.TabIndex = 3;
            this.ModifyButton.Text = "Modify Blog Post";
            this.ModifyButton.UseVisualStyleBackColor = false;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // YouTubeButton
            // 
            this.YouTubeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(33)))), ((int)(((byte)(23)))));
            this.YouTubeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YouTubeButton.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.YouTubeButton.ForeColor = System.Drawing.Color.White;
            this.YouTubeButton.Location = new System.Drawing.Point(450, 119);
            this.YouTubeButton.Name = "YouTubeButton";
            this.YouTubeButton.Size = new System.Drawing.Size(208, 46);
            this.YouTubeButton.TabIndex = 4;
            this.YouTubeButton.Text = "YouTube Video";
            this.YouTubeButton.UseVisualStyleBackColor = false;
            this.YouTubeButton.Click += new System.EventHandler(this.YouTubeButton_Click);
            // 
            // CustomButton
            // 
            this.CustomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomButton.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.CustomButton.ForeColor = System.Drawing.Color.White;
            this.CustomButton.Location = new System.Drawing.Point(690, 119);
            this.CustomButton.Name = "CustomButton";
            this.CustomButton.Size = new System.Drawing.Size(208, 46);
            this.CustomButton.TabIndex = 5;
            this.CustomButton.Text = "Custom Styles";
            this.CustomButton.UseVisualStyleBackColor = false;
            this.CustomButton.Click += new System.EventHandler(this.CustomButton_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 641);
            this.Controls.Add(this.CustomButton);
            this.Controls.Add(this.YouTubeButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPane);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blog Writer Helper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel MainPane;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button YouTubeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CustomButton;
    }
}

