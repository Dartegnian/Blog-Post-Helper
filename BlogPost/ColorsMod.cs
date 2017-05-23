using System;
using System.Windows.Forms;

namespace BlogPost
{
    public partial class ColorsMod : UserControl
    {
        public ColorsMod()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string COLOR1 = Color1.Text;
            string COLOR2 = Color2.Text;
            string COLOR3 = Color3.Text;
            string COLOR4 = Color4.Text;
            string mainIMG = headIMGURL.Text;
            string styles = templateStyles.Text;
            mainIMG.Replace("s0", "s900");
            styles = styles.Replace("IMGURL", mainIMG);
            styles = styles.Replace("CUSCOLOR1", COLOR1);
            styles = styles.Replace("CUSCOLOR2", COLOR2);
            styles = styles.Replace("CUSCOLOR3", COLOR3);
            styles = styles.Replace("CUSCOLOR4", COLOR4);
            CustomPostStyles.Text = styles;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CustomPostStyles.Text = "";
            Color1.Text = "";
            Color2.Text = "";
            Color3.Text = "";
            Color4.Text = "";
        }
    }
}
