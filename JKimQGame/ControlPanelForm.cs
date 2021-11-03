/* ControlPanelForm.cs
 * Assignment 2
 * Revision Histroy
 *      Jisung Kim, 2021.11.02: Created
 *      
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace JKimQGame
{
    /// <summary>
    /// A class to choose a level design or game play
    /// </summary>
    public partial class ControlPanelForm : Form
    {
        // Declaring class variables
        private Image[] logos = {
            Properties.Resources.logo_red,
            Properties.Resources.logo_yellow,
            Properties.Resources.logo_green,
            Properties.Resources.logo_blue,
            Properties.Resources.logo_purple
        };

        private int imageIndex = 0;


        /// <summary>
        /// Default constructor of the ControlPanelForm class
        /// </summary>
        public ControlPanelForm()
        {
            InitializeComponent();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            picLogo.Image = logos[imageIndex];
            imageIndex++;

            if (imageIndex > logos.Length - 1)
            {
                imageIndex = 0;
            }
        }


        private void btnDesign_MouseEnter(object sender, EventArgs e)
        {
            btnDesign.BackgroundImage = Properties.Resources.design_hover;
            Cursor = Cursors.Hand;
        }


        private void btnDesign_MouseLeave(object sender, EventArgs e)
        {
            btnDesign.BackgroundImage = Properties.Resources.design;
            Cursor = Cursors.Arrow;
        }


        private void btnDesign_Click(object sender, EventArgs e)
        {
            DesignForm designForm = new DesignForm();
            designForm.Show();
        }


        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.BackgroundImage = Properties.Resources.play_hover;
            Cursor = Cursors.Hand;
        }


        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.BackgroundImage = Properties.Resources.play;
            Cursor = Cursors.Arrow;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
