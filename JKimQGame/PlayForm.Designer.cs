
namespace JKimQGame
{
    partial class PlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtNumberOfRemainingBoxes = new System.Windows.Forms.TextBox();
            this.txtNumberOfMoves = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTiles = new System.Windows.Forms.Panel();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.imgToolbox = new System.Windows.Forms.ImageList(this.components);
            this.tmrMatch = new System.Windows.Forms.Timer(this.components);
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1674, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(355, 44);
            this.loadGameToolStripMenuItem.Text = "&Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(352, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(355, 44);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControl.Controls.Add(this.btnDown);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.btnLeft);
            this.pnlControl.Controls.Add(this.btnRight);
            this.pnlControl.Controls.Add(this.btnUp);
            this.pnlControl.Controls.Add(this.txtNumberOfRemainingBoxes);
            this.pnlControl.Controls.Add(this.txtNumberOfMoves);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Location = new System.Drawing.Point(26, 75);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(355, 1228);
            this.pnlControl.TabIndex = 1;
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = global::JKimQGame.Properties.Resources.down;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Enabled = false;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Location = new System.Drawing.Point(116, 923);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(120, 96);
            this.btnDown.TabIndex = 4;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.controller_Click);
            this.btnDown.MouseEnter += new System.EventHandler(this.btnDown_MouseEnter);
            this.btnDown.MouseLeave += new System.EventHandler(this.btnDown_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(129, 873);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "MOVE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = global::JKimQGame.Properties.Resources.left;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Enabled = false;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Location = new System.Drawing.Point(15, 832);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(96, 120);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.controller_Click);
            this.btnLeft.MouseEnter += new System.EventHandler(this.btnLeft_MouseEnter);
            this.btnLeft.MouseLeave += new System.EventHandler(this.btnLeft_MouseLeave);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = global::JKimQGame.Properties.Resources.right;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Enabled = false;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Location = new System.Drawing.Point(243, 832);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(96, 120);
            this.btnRight.TabIndex = 5;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.controller_Click);
            this.btnRight.MouseEnter += new System.EventHandler(this.btnRight_MouseEnter);
            this.btnRight.MouseLeave += new System.EventHandler(this.btnRight_MouseLeave);
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = global::JKimQGame.Properties.Resources.up;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Enabled = false;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUp.Location = new System.Drawing.Point(116, 762);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(120, 96);
            this.btnUp.TabIndex = 2;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.controller_Click);
            this.btnUp.MouseEnter += new System.EventHandler(this.btnUp_MouseEnter);
            this.btnUp.MouseLeave += new System.EventHandler(this.btnUp_MouseLeave);
            // 
            // txtNumberOfRemainingBoxes
            // 
            this.txtNumberOfRemainingBoxes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfRemainingBoxes.Location = new System.Drawing.Point(18, 393);
            this.txtNumberOfRemainingBoxes.Name = "txtNumberOfRemainingBoxes";
            this.txtNumberOfRemainingBoxes.ReadOnly = true;
            this.txtNumberOfRemainingBoxes.Size = new System.Drawing.Size(320, 44);
            this.txtNumberOfRemainingBoxes.TabIndex = 1;
            this.txtNumberOfRemainingBoxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumberOfMoves
            // 
            this.txtNumberOfMoves.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfMoves.Location = new System.Drawing.Point(18, 213);
            this.txtNumberOfMoves.Name = "txtNumberOfMoves";
            this.txtNumberOfMoves.ReadOnly = true;
            this.txtNumberOfMoves.Size = new System.Drawing.Size(320, 44);
            this.txtNumberOfMoves.TabIndex = 0;
            this.txtNumberOfMoves.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Remaining Boxes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Moves:";
            // 
            // pnlTiles
            // 
            this.pnlTiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTiles.Location = new System.Drawing.Point(425, 75);
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.Size = new System.Drawing.Size(1249, 1253);
            this.pnlTiles.TabIndex = 2;
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "qgame";
            this.dlgOpen.Filter = "QGAME File|*.qgame|All Files|*.*";
            this.dlgOpen.InitialDirectory = "C:\\";
            this.dlgOpen.RestoreDirectory = true;
            // 
            // imgToolbox
            // 
            this.imgToolbox.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgToolbox.ImageStream")));
            this.imgToolbox.TransparentColor = System.Drawing.Color.Transparent;
            this.imgToolbox.Images.SetKeyName(0, "none.png");
            this.imgToolbox.Images.SetKeyName(1, "wall.png");
            this.imgToolbox.Images.SetKeyName(2, "reddoor.png");
            this.imgToolbox.Images.SetKeyName(3, "redbox.png");
            this.imgToolbox.Images.SetKeyName(4, "bluedoor.png");
            this.imgToolbox.Images.SetKeyName(5, "bluebox.png");
            this.imgToolbox.Images.SetKeyName(6, "greendoor.png");
            this.imgToolbox.Images.SetKeyName(7, "greenbox.png");
            // 
            // tmrMatch
            // 
            this.tmrMatch.Interval = 1;
            this.tmrMatch.Tick += new System.EventHandler(this.tmrMatch_Tick);
            // 
            // tmrMove
            // 
            this.tmrMove.Interval = 80;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(177)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(1674, 1329);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlTiles);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PlayForm";
            this.Text = "Play";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtNumberOfRemainingBoxes;
        private System.Windows.Forms.TextBox txtNumberOfMoves;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTiles;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ImageList imgToolbox;
        private System.Windows.Forms.Timer tmrMatch;
        private System.Windows.Forms.Timer tmrMove;
    }
}