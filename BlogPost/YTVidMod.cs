using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogPost
{
    public partial class YTVidMod : UserControl
    {
        public YTVidMod()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            var VideoID = VideoLink.Text.Replace("https://www.youtube.com/watch?v=", "");
            EmbedCode.Text =
                "<div class=\"ABT-video_outer_wrap\"><div class=\"ABT-video_wrap bottomshadows\"><iframe width=\"1920\" height=\"1080\" src=\"https://www.youtube-nocookie.com/embed/" +
                VideoID +
                "?rel=0\" frameborder=\"0\" allowfullscreen></iframe></div></div>\n<br/><br/>\n";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            VideoLink.Text = "";
            EmbedCode.Text = "";
        }
    }
}
