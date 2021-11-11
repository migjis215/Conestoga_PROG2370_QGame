/* DesignForm.cs
 * Assignment 2
 * Revision History
 *      Jisung Kim, 2021.11.02: Created
 *      
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JKimQGame
{
    /// <summary>
    /// A class to design the game level
    /// </summary>
    public partial class DesignForm : Form
    {
        // Declaring class variables and constants
        private const int LEFT = 220;
        private const int TOP = 84;
        private const int WIDTH = 60;
        private const int HEIGHT = 60;

        private int rowLength = 0;
        private int columnLength = 0;

        private int[] countsOfTools;
        private int numberOfDoors = 0;
        private int numberOfBoxes = 0;

        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        private Tool[,] tools;
        private Image toolImage = null;
        private int toolNumber = 0;


        /// <summary>
        /// Default constructor of the DesignForm class
        /// </summary>
        public DesignForm()
        {
            InitializeComponent();
        }


        private void DesignForm_Load(object sender, EventArgs e)
        {
            initialize();
        }


        /// <summary>
        /// Initialize variables and remove every PictureBox controls
        /// </summary>
        private void initialize()
        {
            btnGenerate.Visible = true;
            toolImage = null;
            toolNumber = 0;

            txtRows.Text = "";
            txtColumns.Text = "";
            txtRows.Select();

            foreach (var control in this.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBoxes.Add(pictureBox);
                }
            }

            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Dispose();
            }

            pictureBoxes.Clear();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                rowLength = getRowsOrColumns(txtRows);
                columnLength = getRowsOrColumns(txtColumns);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Q-Game",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnGenerate.Visible = false;
            tools = new Tool[rowLength, columnLength];

            int x = LEFT;
            int y = TOP;

            for (int row = 0; row < rowLength; row++)
            {
                for (int column = 0; column < columnLength; column++)
                {
                    Tool tool = new Tool();
                    tool.Left = x;
                    tool.Top = y;
                    tool.Width = WIDTH;
                    tool.Height = HEIGHT;
                    tool.Click += pictureBox_Click;

                    this.Controls.Add(tool);
                    tools[row, column] = tool;

                    x += WIDTH;
                }

                x = LEFT;
                y += HEIGHT;
            }
        }


        /// <summary>
        /// Validate user input and return the value of the rows or columns
        /// </summary>
        /// <param name="textBox">The TextBox of the rows or columns to be validated</param>
        /// <returns>If user input is valid, return the number of the rows or columns</returns>
        private int getRowsOrColumns(TextBox textBox)
        {
            int input = 0;

            try
            {
                input = int.Parse(textBox.Text);
                if (input <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                string textBoxName = textBox.Name.Substring(3);
                textBox.Focus();
                textBox.SelectAll();
                throw new Exception($"Please enter {textBoxName} again " +
                                    $"({textBoxName} must be integer greater than zero)");
            }

            return input;
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            Tool tool = (Tool)sender;
            tool.Image = toolImage;
            tool.ToolNumber = toolNumber;
        }


        private void toolboxButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            toolImage = button.Image;
            toolNumber = button.ImageIndex;

            if (toolImage == imgToolbox.Images[0])
            {
                toolImage = null;
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countsOfTools = new int[imgToolbox.Images.Count];
            dlgSave.FileName = "savegame_" + DateTime.Now.ToString("MMddyyHHmmss");

            string levelInformation = rowLength + "\n" + columnLength + "\n";

            for (int row = 0; row < rowLength; row++)
            {
                for (int column = 0; column < columnLength; column++)
                {
                    levelInformation += row + "\n" +
                                        column + "\n" +
                                        tools[row, column].ToolNumber + "\n";

                    countsOfTools[tools[row, column].ToolNumber]++;
                }
            }

            try
            {
                checkBoxes();
                checkMissingDoors();

                DialogResult result = dlgSave.ShowDialog();

                switch (result)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        using (StreamWriter writer = new StreamWriter(dlgSave.FileName))
                        {
                            writer.WriteLine(levelInformation);
                        }

                        numberOfDoors = 0;
                        numberOfBoxes = 0;

                        for (int i = 0; i < countsOfTools.Length; i++)
                        {
                            string toolName = getToolName(i);

                            if (toolName.Contains("Door"))
                            {
                                numberOfDoors += countsOfTools[i];
                            }
                            else if (toolName.Contains("Box"))
                            {
                                numberOfBoxes += countsOfTools[i];
                            }
                        }

                        MessageBox.Show("File saved successfully\n" +
                                        $"Total number of walls: {countsOfTools[1]}\n" +
                                        $"Total number of doors: {numberOfDoors}\n" +
                                        $"Total number of boxes: {numberOfBoxes}",
                                        "Q-Game",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception trying to save the file: " + ex.Message,
                                "Q-Game",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Check if every colored box has a matching colored door
        /// </summary>
        private void checkMissingDoors()
        {
            string errorMessage = "";

            for (int i = 0; i < countsOfTools.Length; i++)
            {
                string toolName = getToolName(i);

                if (toolName.Contains("Door"))
                {
                    if (countsOfTools[i + 1] > 0 && countsOfTools[i] == 0)
                    {
                        errorMessage += toolName.Insert(toolName.Length - 4, " ") + "\n";
                    }
                }
            }

            if (errorMessage != "")
            {
                throw new Exception("Every coloured box must have a matching coloured door. " +
                                    "Please add the doors below. \n\n" + errorMessage);
            }
        }


        /// <summary>
        /// Check if at least one box has been added
        /// </summary>
        private void checkBoxes()
        {
            int numberOfBoxes = 0;

            for (int i = 0; i < countsOfTools.Length; i++)
            {
                string toolName = getToolName(i);

                if (toolName.Contains("Box"))
                {
                    numberOfBoxes += countsOfTools[i];
                }
            }

            if (numberOfBoxes == 0)
            {
                throw new Exception("At least one box must be added.");
            }
        }
        

        /// <summary>
        /// Get the name of specific tool type
        /// </summary>
        /// <param name="indexOfToolTypes">Integer value of ToolTypes</param>
        /// <returns>String value of tool name</returns>
        private string getToolName(int indexOfToolTypes)
        {
            return ((ToolTypes)indexOfToolTypes).ToString();
        }


        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                    "All tools and a grid will be removed. " +
                                    "Are you sure to reset?",
                                    "Q-Game",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    initialize();
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnGenerate_MouseEnter(object sender, EventArgs e)
        {
            btnGenerate.BackgroundImage = Properties.Resources.generate_hover;
            Cursor = Cursors.Hand;
        }


        private void btnGenerate_MouseLeave(object sender, EventArgs e)
        {
            btnGenerate.BackgroundImage = Properties.Resources.generate;
            Cursor = Cursors.Arrow;
        }
    }
}
