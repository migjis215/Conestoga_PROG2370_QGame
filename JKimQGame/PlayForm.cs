/* PlayForm.cs
 * Assignment 3
 * Revision History
 *      Jisung Kim, 2021.11.15: Created
 *      
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace JKimQGame
{
    /// <summary>
    /// A class to play the game
    /// </summary>
    public partial class PlayForm : Form
    {
        // Declaring class variables and constants
        private const int INIT_LEFT = 60;
        private const int INIT_TOP = 60;
        private const int WIDTH = 60;
        private const int HEIGHT = 60;

        private int rowLength = 0;
        private int columnLength = 0;
        private string direction = "";
        private int resizeCount = 0;
        private int nextRowIndex;
        private int nextColumnIndex;
        private int previousRowIndex;
        private int previousColumnIndex;

        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        private int numberOfMoves = 0;
        private int numberOfRemainingBoxes = 0;

        private Tool[,] tiles;
        private Tool tileSelected;
        private Tool success;

        /// <summary>
        /// Default constructor of the PlayForm class
        /// </summary>
        public PlayForm()
        {
            InitializeComponent();
        }


        private void PlayForm_Load(object sender, EventArgs e)
        {
            initialize();
        }


        /// <summary>
        /// Initialize variables and remove every PictureBox controls
        /// </summary>
        private void initialize()
        {
            rowLength = 0;
            columnLength = 0;
            numberOfMoves = 0;
            numberOfRemainingBoxes = 0;
            txtNumberOfMoves.Text = "";
            txtNumberOfRemainingBoxes.Text = "";
            tileSelected = null;
            success = null;

            foreach (var control in pnlControl.Controls)
            {
                if (control is Button controller)
                {
                    controller.Enabled = false;
                }
            }

            foreach (var control in pnlTiles.Controls)
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


        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpen.ShowDialog();
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    initialize();
                    string fileName = dlgOpen.FileName;
                    load(fileName);
                    update();
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

            foreach (var control in pnlControl.Controls)
            {
                if (control is Button controller)
                {
                    controller.Enabled = true;
                }
            }
        }


        /// <summary>
        /// Read the game information file and display the game tiles on the screen
        /// </summary>
        /// <param name="fileName">File name to be read</param>
        private void load(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    rowLength = int.Parse(reader.ReadLine());
                    columnLength = int.Parse(reader.ReadLine());

                    tiles = new Tool[rowLength, columnLength];

                    int x = INIT_LEFT;
                    int y = INIT_TOP;

                    while (!reader.EndOfStream)
                    {
                        int rowIndex = int.Parse(reader.ReadLine());
                        int columnIndex = int.Parse(reader.ReadLine());
                        int toolNumber = int.Parse(reader.ReadLine());

                        if (toolNumber != 0)
                        {
                            Tool tile = new Tool();
                            tile.RowIndex = rowIndex;
                            tile.ColumnIndex = columnIndex;
                            tile.ToolNumber = toolNumber;

                            if (Tool.getToolName(toolNumber).Contains("Box"))
                            {
                                numberOfRemainingBoxes++;
                            }

                            tile.Left = x;
                            tile.Top = y;
                            tile.Width = WIDTH;
                            tile.Height = HEIGHT;
                            tile.BorderStyle = BorderStyle.None;
                            tile.Click += tile_Click;

                            tile.Image = imgToolbox.Images[tile.ToolNumber];

                            pnlTiles.Controls.Add(tile);
                            tiles[tile.RowIndex, tile.ColumnIndex] = tile;
                        }

                        x += WIDTH;

                        if (columnIndex == columnLength - 1)
                        {
                            x = INIT_LEFT;
                            y += HEIGHT;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception trying to load the file: " + ex.Message,
                                "Q-Game",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Update the number of moves and remaining boxes and notify if the game is over
        /// </summary>
        private void update()
        {
            txtNumberOfMoves.Text = numberOfMoves.ToString();
            txtNumberOfRemainingBoxes.Text = numberOfRemainingBoxes.ToString();

            if (numberOfRemainingBoxes == 0)
            {
                MessageBox.Show("Congratulations\nGame End",
                                "Q-Game",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                initialize();
            }
        }


        private void tile_Click(object sender, EventArgs e)
        {
            Tool tile = (Tool)sender;

            string toolName = Tool.getToolName(tile.ToolNumber);
            if (!toolName.Contains("Box"))
            {
                return;
            }

            if (tileSelected != null)
            {
                if (tileSelected.RowIndex != tile.RowIndex || 
                    tileSelected.ColumnIndex != tile.ColumnIndex)
                {
                    tileSelected.Image = imgToolbox.Images[tileSelected.ToolNumber];
                }
                else
                {
                    return;
                }
            }

            tileSelected = tile;

            switch (toolName.Substring(0, toolName.IndexOf("Box")))
            {
                case "Red":
                    tileSelected.Image = Properties.Resources.redhandtruck;
                    break;
                case "Blue":
                    tileSelected.Image = Properties.Resources.bluehandtruck;
                    break;
                case "Green":
                    tileSelected.Image = Properties.Resources.greenhandtruck;
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// Get the tile specified row and column
        /// </summary>
        /// <param name="row">An integer value of the row</param>
        /// <param name="column">An integer value of the column</param>
        /// <returns>Tool object at the specified row and column</returns>
        private Tool getTile(int row, int column)
        {
            return tiles[row, column];
        }


        private void controller_Click(object sender, EventArgs e)
        {
            if (tileSelected == null)
            {
                MessageBox.Show("Please click on a box to select",
                                        "Q-Game",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                return;
            }

            Button controller = (Button)sender;
            direction = controller.Name;

            nextRowIndex = tileSelected.RowIndex;
            nextColumnIndex = tileSelected.ColumnIndex;
            previousRowIndex = tileSelected.RowIndex;
            previousColumnIndex = tileSelected.ColumnIndex;

            this.Enabled = false;
            tmrMove.Enabled = true;
        }


        private void tmrMove_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case "btnUp":
                    nextRowIndex -= 1;
                    break;
                case "btnLeft":
                    nextColumnIndex -= 1;
                    break;
                case "btnDown":
                    nextRowIndex += 1;
                    break;
                case "btnRight":
                    nextColumnIndex += 1;
                    break;
            }

            Tool nextTile = getTile(nextRowIndex, nextColumnIndex);

            if (nextTile != null)
            {
                tmrMove.Enabled = false;

                if (tileSelected.ToolNumber == nextTile.ToolNumber + 1)
                {
                    numberOfRemainingBoxes--;
                    tiles[tileSelected.RowIndex, tileSelected.ColumnIndex] = null;
                    tileSelected.Dispose();
                    tileSelected = null;

                    foreach (var control in pnlTiles.Controls)
                    {
                        if (control is Tool tile)
                        {
                            if (tile.RowIndex == nextRowIndex && 
                                tile.ColumnIndex == nextColumnIndex)
                            {
                                success = tile;
                            }
                        }
                    }

                    tmrMatch.Enabled = true;
                }

                if (tileSelected == null || 
                    previousRowIndex != tileSelected.RowIndex || 
                    previousColumnIndex != tileSelected.ColumnIndex)
                {
                    numberOfMoves++;
                }

                this.Enabled = true;
                update();
            }
            else
            {
                tileSelected.Left = INIT_LEFT + (WIDTH * nextColumnIndex);
                tileSelected.Top = INIT_TOP + (HEIGHT * nextRowIndex);

                tiles[tileSelected.RowIndex, tileSelected.ColumnIndex] = null;
                tiles[nextRowIndex, nextColumnIndex] = tileSelected;

                tileSelected.RowIndex = nextRowIndex;
                tileSelected.ColumnIndex = nextColumnIndex;
            }
        }


        private void tmrMatch_Tick(object sender, EventArgs e)
        {
            int resizeValue = 1;
            if (resizeCount > WIDTH / 2)
            {
                resizeValue = -1;
            }

            success.Left += resizeValue;
            success.Top += resizeValue;
            success.Width -= resizeValue * 2;
            success.Height -= resizeValue * 2;

            resizeCount++;

            if (resizeCount > WIDTH)
            {
                resizeCount = 0;
                tmrMatch.Enabled = false;
            }
        }


        private void btnUp_MouseEnter(object sender, EventArgs e)
        {
            btnUp.BackgroundImage = Properties.Resources.up_hover;
            Cursor = Cursors.Hand;
        }

        private void btnUp_MouseLeave(object sender, EventArgs e)
        {
            btnUp.BackgroundImage = Properties.Resources.up;
            Cursor = Cursors.Arrow;
        }

        private void btnLeft_MouseEnter(object sender, EventArgs e)
        {
            btnLeft.BackgroundImage = Properties.Resources.left_hover;
            Cursor = Cursors.Hand;
        }

        private void btnLeft_MouseLeave(object sender, EventArgs e)
        {
            btnLeft.BackgroundImage = Properties.Resources.left;
            Cursor = Cursors.Arrow;
        }

        private void btnRight_MouseEnter(object sender, EventArgs e)
        {
            btnRight.BackgroundImage = Properties.Resources.right_hover;
            Cursor = Cursors.Hand;
        }

        private void btnRight_MouseLeave(object sender, EventArgs e)
        {
            btnRight.BackgroundImage = Properties.Resources.right;
            Cursor = Cursors.Arrow;
        }

        private void btnDown_MouseEnter(object sender, EventArgs e)
        {
            btnDown.BackgroundImage = Properties.Resources.down_hover;
            Cursor = Cursors.Hand;
        }

        private void btnDown_MouseLeave(object sender, EventArgs e)
        {
            btnDown.BackgroundImage = Properties.Resources.down;
            Cursor = Cursors.Arrow;
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
