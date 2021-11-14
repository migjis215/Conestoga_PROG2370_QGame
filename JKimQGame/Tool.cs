/* Tool.cs
 * Assignment 2
 * Revision Histroy
 *      Jisung Kim, 2021.11.02: Created
 *      Jisung Kim, 2021.11.13: Added properties (RowIndex, ColumnIndex)
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
        private int rowIndex;
        private int columnIndex;
        private int toolNumber;

        // Declaring property for accessing class variable
        public int RowIndex { get => rowIndex; set => rowIndex = value; }
        public int ColumnIndex { get => columnIndex; set => columnIndex = value; }
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

        /// <summary>
        /// Get the name of specific tool type
        /// </summary>
        /// <param name="indexOfToolTypes">Integer value of ToolTypes</param>
        /// <returns>String value of tool name</returns>
        public static string getToolName(int toolNumber)
        {
            return ((ToolTypes)toolNumber).ToString();
        }
    }
}
