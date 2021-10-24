
namespace JKimQGame
{
    partial class DesignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInputsAndGenerate = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.imgToolbox = new System.Windows.Forms.ImageList(this.components);
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBlueBox = new System.Windows.Forms.Button();
            this.btnBlueDoor = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.pnlInputsAndGenerate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1674, 42);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 38);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pnlInputsAndGenerate
            // 
            this.pnlInputsAndGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInputsAndGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.pnlInputsAndGenerate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInputsAndGenerate.Controls.Add(this.btnGenerate);
            this.pnlInputsAndGenerate.Controls.Add(this.txtColumns);
            this.pnlInputsAndGenerate.Controls.Add(this.label2);
            this.pnlInputsAndGenerate.Controls.Add(this.txtRows);
            this.pnlInputsAndGenerate.Controls.Add(this.label1);
            this.pnlInputsAndGenerate.Location = new System.Drawing.Point(0, 45);
            this.pnlInputsAndGenerate.Name = "pnlInputsAndGenerate";
            this.pnlInputsAndGenerate.Size = new System.Drawing.Size(1674, 93);
            this.pnlInputsAndGenerate.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackgroundImage = global::JKimQGame.Properties.Resources.generate;
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(700, -4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(279, 95);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            this.btnGenerate.MouseEnter += new System.EventHandler(this.btnGenerate_MouseEnter);
            this.btnGenerate.MouseLeave += new System.EventHandler(this.btnGenerate_MouseLeave);
            // 
            // txtColumns
            // 
            this.txtColumns.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumns.Location = new System.Drawing.Point(506, 24);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(157, 39);
            this.txtColumns.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Columns : ";
            // 
            // txtRows
            // 
            this.txtRows.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRows.Location = new System.Drawing.Point(144, 24);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(157, 39);
            this.txtRows.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows : ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnGreenBox);
            this.panel2.Controls.Add(this.btnGreenDoor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnBlueBox);
            this.panel2.Controls.Add(this.btnBlueDoor);
            this.panel2.Controls.Add(this.btnRedBox);
            this.panel2.Controls.Add(this.btnRedDoor);
            this.panel2.Controls.Add(this.btnWall);
            this.panel2.Controls.Add(this.btnNone);
            this.panel2.Location = new System.Drawing.Point(25, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 1185);
            this.panel2.TabIndex = 2;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.ImageIndex = 7;
            this.btnGreenBox.ImageList = this.imgToolbox;
            this.btnGreenBox.Location = new System.Drawing.Point(35, 824);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnGreenBox.Size = new System.Drawing.Size(283, 99);
            this.btnGreenBox.TabIndex = 8;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.toolboxButton_Click);
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
            // btnGreenDoor
            // 
            this.btnGreenDoor.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.ImageIndex = 6;
            this.btnGreenDoor.ImageList = this.imgToolbox;
            this.btnGreenDoor.Location = new System.Drawing.Point(35, 719);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnGreenDoor.Size = new System.Drawing.Size(283, 99);
            this.btnGreenDoor.TabIndex = 7;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.toolboxButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toolbox";
            // 
            // btnBlueBox
            // 
            this.btnBlueBox.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlueBox.ImageIndex = 5;
            this.btnBlueBox.ImageList = this.imgToolbox;
            this.btnBlueBox.Location = new System.Drawing.Point(35, 614);
            this.btnBlueBox.Name = "btnBlueBox";
            this.btnBlueBox.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBlueBox.Size = new System.Drawing.Size(283, 99);
            this.btnBlueBox.TabIndex = 6;
            this.btnBlueBox.Text = "Blue Box";
            this.btnBlueBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBlueBox.UseVisualStyleBackColor = true;
            this.btnBlueBox.Click += new System.EventHandler(this.toolboxButton_Click);
            // 
            // btnBlueDoor
            // 
            this.btnBlueDoor.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlueDoor.ImageIndex = 4;
            this.btnBlueDoor.ImageList = this.imgToolbox;
            this.btnBlueDoor.Location = new System.Drawing.Point(35, 509);
            this.btnBlueDoor.Name = "btnBlueDoor";
            this.btnBlueDoor.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBlueDoor.Size = new System.Drawing.Size(283, 99);
            this.btnBlueDoor.TabIndex = 5;
            this.btnBlueDoor.Text = "Blue Door";
            this.btnBlueDoor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBlueDoor.UseVisualStyleBackColor = true;
            this.btnBlueDoor.Click += new System.EventHandler(this.toolboxButton_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.ImageIndex = 3;
            this.btnRedBox.ImageList = this.imgToolbox;
            this.btnRedBox.Location = new System.Drawing.Point(35, 404);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRedBox.Size = new System.Drawing.Size(283, 99);
            this.btnRedBox.TabIndex = 4;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.toolboxButton_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.ImageIndex = 2;
            this.btnRedDoor.ImageList = this.imgToolbox;
            this.btnRedDoor.Location = new System.Drawing.Point(35, 299);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRedDoor.Size = new System.Drawing.Size(283, 99);
            this.btnRedDoor.TabIndex = 3;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.toolboxButton_Click);
            // 
            // btnWall
            // 
            this.btnWall.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.ImageIndex = 1;
            this.btnWall.ImageList = this.imgToolbox;
            this.btnWall.Location = new System.Drawing.Point(35, 194);
            this.btnWall.Name = "btnWall";
            this.btnWall.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnWall.Size = new System.Drawing.Size(283, 99);
            this.btnWall.TabIndex = 2;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.toolboxButton_Click);
            // 
            // btnNone
            // 
            this.btnNone.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.ImageIndex = 0;
            this.btnNone.ImageList = this.imgToolbox;
            this.btnNone.Location = new System.Drawing.Point(35, 89);
            this.btnNone.Name = "btnNone";
            this.btnNone.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnNone.Size = new System.Drawing.Size(283, 99);
            this.btnNone.TabIndex = 1;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.toolboxButton_Click);
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "qgame";
            this.dlgSave.Filter = "QGAME File|*.qgame|All Files|*.*";
            this.dlgSave.InitialDirectory = "C:\\";
            this.dlgSave.RestoreDirectory = true;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(356, 6);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(177)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(1674, 1329);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlInputsAndGenerate);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "DesignForm";
            this.Text = "Design";
            this.Load += new System.EventHandler(this.DesignForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlInputsAndGenerate.ResumeLayout(false);
            this.pnlInputsAndGenerate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlInputsAndGenerate;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBlueBox;
        private System.Windows.Forms.Button btnBlueDoor;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ImageList imgToolbox;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}