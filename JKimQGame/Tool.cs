using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKimQGame
{
    public enum ToolTypes
    {
        None,
        Wall,
        RedDoor,
        RedBox,
        BlueDoor,
        BlueBox,
        GreenDoor,
        GreenBox
    }

    class Tool : PictureBox
    {
        private DesignForm designForm;

        private Image toolImage;
        private int toolNumber;

        public Image ToolImage { get => toolImage; set => toolImage = value; }
        public int ToolNumber { get => toolNumber; set => toolNumber = value; }

        public Tool(DesignForm designForm)
        {
            this.designForm = designForm;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Transparent;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Click += pictureBox_Click;
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Image = designForm.ToolImage;
            this.ToolNumber = designForm.ToolNumber;
        }
    }
}
