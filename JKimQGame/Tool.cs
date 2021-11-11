/* Tool.cs
 * Assignment 2
 * Revision Histroy
 *      Jisung Kim, 2021.11.02: Created
 *      
 */

using System.Drawing;
using System.Windows.Forms;

namespace JKimQGame
{
    /// <summary>
    /// Specify the tool types
    /// </summary>
    public enum ToolTypes
    {
        /// <summary>
        /// Type to empty the cell
        /// </summary>
        None,
        /// <summary>
        /// Type of wall
        /// </summary>
        Wall,
        /// <summary>
        /// Type of red door
        /// </summary>
        RedDoor,
        /// <summary>
        /// Type of red box
        /// </summary>
        RedBox,
        /// <summary>
        /// Type of blue door
        /// </summary>
        BlueDoor,
        /// <summary>
        /// Type of blue box
        /// </summary>
        BlueBox,
        /// <summary>
        /// Type of green door
        /// </summary>
        GreenDoor,
        /// <summary>
        /// Type of green box
        /// </summary>
        GreenBox
    }

    /// <summary>
    /// A class to create objects that inherit PictureBox class
    /// </summary>
    class Tool : PictureBox
    {
        // Declaring class variable
        private int toolNumber;

        // Declaring property for accessing class variable
        public int ToolNumber { get => toolNumber; set => toolNumber = value; }

        /// <summary>
        /// Default constructor of the Tool class
        /// </summary>
        public Tool()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Transparent;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
