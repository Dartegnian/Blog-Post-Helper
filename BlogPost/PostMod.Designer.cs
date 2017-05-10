namespace BlogPost
{
    partial class PostMod
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
            this.label1 = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OriginalCode = new System.Windows.Forms.RichTextBox();
            this.OutputCode = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(163)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(83, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Post Code";
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.White;
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.ConvertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(163)))), ((int)(((byte)(82)))));
            this.ConvertButton.Location = new System.Drawing.Point(447, 181);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(176, 58);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(163)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(722, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Post Code";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(163)))), ((int)(((byte)(82)))));
            this.ClearButton.Location = new System.Drawing.Point(447, 245);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(176, 58);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OriginalCode
            // 
            this.OriginalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OriginalCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OriginalCode.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.OriginalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(163)))), ((int)(((byte)(82)))));
            this.OriginalCode.Location = new System.Drawing.Point(3, 49);
            this.OriginalCode.Name = "OriginalCode";
            this.OriginalCode.Size = new System.Drawing.Size(438, 396);
            this.OriginalCode.TabIndex = 8;
            this.OriginalCode.Text = "";
            // 
            // OutputCode
            // 
            this.OutputCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OutputCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputCode.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.OutputCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(163)))), ((int)(((byte)(82)))));
            this.OutputCode.Location = new System.Drawing.Point(629, 49);
            this.OutputCode.Name = "OutputCode";
            this.OutputCode.Size = new System.Drawing.Size(438, 396);
            this.OutputCode.TabIndex = 9;
            this.OutputCode.Text = "";
            // 
            // PostMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.OutputCode);
            this.Controls.Add(this.OriginalCode);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "PostMod";
            this.Size = new System.Drawing.Size(1070, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RichTextBox OriginalCode;
        private System.Windows.Forms.RichTextBox OutputCode;
    }
}
