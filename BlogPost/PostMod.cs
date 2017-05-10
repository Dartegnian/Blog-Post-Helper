using System;
using System.Windows.Forms;

namespace BlogPost
{
    public partial class PostMod : UserControl
    {
        public PostMod()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            OutputCode.Text = OriginalCode.Text.Replace(" style=\"margin-left: 1em; margin-right: 1em;\"", "");
            OutputCode.Text = OutputCode.Text.Replace("s640", "s0");
            OutputCode.Text = OutputCode.Text.Replace("s1600", "s0");
            OutputCode.Text = OutputCode.Text.Replace("width=\"640\"", "width=\"100%\"");
            OutputCode.Text = OutputCode.Text.Replace("http://1.bp.blogspot.com", "https://1.bp.blogspot.com");
            OutputCode.Text = OutputCode.Text.Replace("http://2.bp.blogspot.com", "https://2.bp.blogspot.com");
            OutputCode.Text = OutputCode.Text.Replace("http://3.bp.blogspot.com", "https://3.bp.blogspot.com");
            OutputCode.Text = OutputCode.Text.Replace("http://4.bp.blogspot.com", "https://4.bp.blogspot.com");
            OutputCode.Text = OutputCode.Text.Replace("http://5.bp.blogspot.com", "https://5.bp.blogspot.com");
            OutputCode.Text = OutputCode.Text.Replace("http://6.bp.blogspot.com", "https://6.bp.blogspot.com");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OriginalCode.Text = "";
            OutputCode.Text = "";
        }
    }
}
