using System;
using System.Windows.Forms;

namespace BlogPost
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }
        
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            var BlogPost = new PostMod();

            MainPane.Controls.Clear();
            MainPane.Controls.Add(BlogPost);
        }

        private void YouTubeButton_Click(object sender, EventArgs e)
        {
            var YouTube = new YTVidMod();

            MainPane.Controls.Clear();
            MainPane.Controls.Add(YouTube);
        }

        private void CustomButton_Click(object sender, EventArgs e)
        {
            var Colors = new ColorsMod();

            MainPane.Controls.Clear();
            MainPane.Controls.Add(Colors);
        }
    }
}