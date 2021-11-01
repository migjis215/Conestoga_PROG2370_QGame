
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKimQGame
{
    public partial class DesignForm : Form
    {
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

        //public Image ToolImage { get => toolImage; set => toolImage = value; }
        //public int ToolNumber { get => toolNumber; set => toolNumber = value; }

        public DesignForm()
        {
            InitializeComponent();
        }

        private void DesignForm_Load(object sender, EventArgs e)
        {
            initialize();
        }
        private void initialize()
        {
            btnGenerate.Visible = true;
            toolImage = null;
            toolNumber = 0;


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
            dlgSave.FileName = "savegame_" + DateTime.Now.ToString("MMddyyHHmmss");

            DialogResult result = dlgSave.ShowDialog();

            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        save();

                        numberOfDoors = 0;
                        numberOfBoxes = 0;

                        for (int i = 2; i < countsOfTools.Length; i++)
                        {
                            if (i % 2 == 0)
                            {
                                numberOfDoors += countsOfTools[i];
                            }
                            else
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception trying to save the file: " + ex.Message,
                                        "Q-Game",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
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

        private void save()
        {
            countsOfTools = new int[imgToolbox.Images.Count];

            using (StreamWriter writer = new StreamWriter(dlgSave.FileName))
            {
                writer.WriteLine(rowLength + "\n" + columnLength);

                for (int row = 0; row < rowLength; row++)
                {
                    for (int column = 0; column < columnLength; column++)
                    {
                        writer.WriteLine(row + "\n" +
                                         column + "\n" +
                                         tools[row, column].ToolNumber);

                        countsOfTools[tools[row, column].ToolNumber]++;
                    }
                }

                string errorMessage = "";

                for (int i = 2; i < imgToolbox.Images.Count; i += 2)
                {
                    if (countsOfTools[i + 1] > 0 && countsOfTools[i] == 0)
                    {
                        ToolTypes door = (ToolTypes)i;
                        string missingDoor = door.ToString();

                        errorMessage += missingDoor.Insert(missingDoor.Length - 4, " ") + "\n";
                    }
                }

                if (errorMessage != "")
                {
                    throw new Exception("Every coloured box must have a matching coloured door. " +
                                        "Please add the doors below. \n\n" + errorMessage);
                }
            }
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
