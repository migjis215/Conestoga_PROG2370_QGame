using System.Drawing;
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
        private int toolNumber;

        public int ToolNumber { get => toolNumber; set => toolNumber = value; }

        public Tool()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Transparent;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
