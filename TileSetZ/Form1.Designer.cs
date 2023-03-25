using System.Windows.Forms;

namespace TileSetZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_Roof = new System.Windows.Forms.RadioButton();
            this.btn_TrimColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.rdb_wall = new System.Windows.Forms.RadioButton();
            this.rdb_floor = new System.Windows.Forms.RadioButton();
            this.pbx_original = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTilesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbx_main = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Color1 = new System.Windows.Forms.Button();
            this.btn_Color2 = new System.Windows.Forms.Button();
            this.btn_Color4 = new System.Windows.Forms.Button();
            this.btn_Color3 = new System.Windows.Forms.Button();
            this.btn_Color5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_original)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_main)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_Roof);
            this.groupBox1.Controls.Add(this.btn_TrimColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Generate);
            this.groupBox1.Controls.Add(this.rdb_wall);
            this.groupBox1.Controls.Add(this.rdb_floor);
            this.groupBox1.Controls.Add(this.pbx_original);
            this.groupBox1.Location = new System.Drawing.Point(3, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tile";
            // 
            // rdb_Roof
            // 
            this.rdb_Roof.AutoSize = true;
            this.rdb_Roof.Location = new System.Drawing.Point(78, 139);
            this.rdb_Roof.Name = "rdb_Roof";
            this.rdb_Roof.Size = new System.Drawing.Size(48, 17);
            this.rdb_Roof.TabIndex = 9;
            this.rdb_Roof.Text = "Roof";
            this.rdb_Roof.UseVisualStyleBackColor = true;
            this.rdb_Roof.CheckedChanged += new System.EventHandler(this.rdb_Roof_CheckedChanged);
            // 
            // btn_TrimColor
            // 
            this.btn_TrimColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btn_TrimColor.Location = new System.Drawing.Point(80, 201);
            this.btn_TrimColor.Name = "btn_TrimColor";
            this.btn_TrimColor.Size = new System.Drawing.Size(46, 22);
            this.btn_TrimColor.TabIndex = 8;
            this.btn_TrimColor.UseVisualStyleBackColor = false;
            this.btn_TrimColor.Click += new System.EventHandler(this.btn_TrimColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Trim Color :";
            // 
            // btn_Generate
            // 
            this.btn_Generate.Enabled = false;
            this.btn_Generate.Location = new System.Drawing.Point(17, 228);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(110, 20);
            this.btn_Generate.TabIndex = 5;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // rdb_wall
            // 
            this.rdb_wall.AutoSize = true;
            this.rdb_wall.Checked = true;
            this.rdb_wall.Location = new System.Drawing.Point(8, 139);
            this.rdb_wall.Name = "rdb_wall";
            this.rdb_wall.Size = new System.Drawing.Size(46, 17);
            this.rdb_wall.TabIndex = 3;
            this.rdb_wall.TabStop = true;
            this.rdb_wall.Text = "Wall";
            this.rdb_wall.UseVisualStyleBackColor = true;
            // 
            // rdb_floor
            // 
            this.rdb_floor.AutoSize = true;
            this.rdb_floor.Location = new System.Drawing.Point(9, 162);
            this.rdb_floor.Name = "rdb_floor";
            this.rdb_floor.Size = new System.Drawing.Size(48, 17);
            this.rdb_floor.TabIndex = 2;
            this.rdb_floor.Text = "Floor";
            this.rdb_floor.UseVisualStyleBackColor = true;
            // 
            // pbx_original
            // 
            this.pbx_original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_original.Location = new System.Drawing.Point(20, 19);
            this.pbx_original.Name = "pbx_original";
            this.pbx_original.Size = new System.Drawing.Size(110, 111);
            this.pbx_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_original.TabIndex = 0;
            this.pbx_original.TabStop = false;
            this.toolTip1.SetToolTip(this.pbx_original, "Original Texture");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1053, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.saveTilesetToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openImageToolStripMenuItem.Text = "&Open image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // saveTilesetToolStripMenuItem
            // 
            this.saveTilesetToolStripMenuItem.Enabled = false;
            this.saveTilesetToolStripMenuItem.Name = "saveTilesetToolStripMenuItem";
            this.saveTilesetToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveTilesetToolStripMenuItem.Text = "&Save Tileset...";
            this.saveTilesetToolStripMenuItem.Click += new System.EventHandler(this.saveTilesetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            // 
            // pbx_main
            // 
            this.pbx_main.Location = new System.Drawing.Point(3, 3);
            this.pbx_main.Name = "pbx_main";
            this.pbx_main.Size = new System.Drawing.Size(878, 1775);
            this.pbx_main.TabIndex = 3;
            this.pbx_main.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.pbx_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(155, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 584);
            this.panel1.TabIndex = 4;
            // 
            // btn_Color1
            // 
            this.btn_Color1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Color1.BackColor = System.Drawing.Color.Black;
            this.btn_Color1.Location = new System.Drawing.Point(31, 576);
            this.btn_Color1.Name = "btn_Color1";
            this.btn_Color1.Size = new System.Drawing.Size(21, 22);
            this.btn_Color1.TabIndex = 12;
            this.btn_Color1.UseVisualStyleBackColor = false;
            this.btn_Color1.Click += new System.EventHandler(this.btn_Color1_Click);
            // 
            // btn_Color2
            // 
            this.btn_Color2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Color2.BackColor = System.Drawing.Color.Lime;
            this.btn_Color2.Location = new System.Drawing.Point(57, 576);
            this.btn_Color2.Name = "btn_Color2";
            this.btn_Color2.Size = new System.Drawing.Size(21, 22);
            this.btn_Color2.TabIndex = 9;
            this.btn_Color2.UseVisualStyleBackColor = false;
            this.btn_Color2.Click += new System.EventHandler(this.btn_Color2_Click);
            // 
            // btn_Color4
            // 
            this.btn_Color4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Color4.BackColor = System.Drawing.Color.White;
            this.btn_Color4.Location = new System.Drawing.Point(111, 576);
            this.btn_Color4.Name = "btn_Color4";
            this.btn_Color4.Size = new System.Drawing.Size(21, 22);
            this.btn_Color4.TabIndex = 10;
            this.btn_Color4.UseVisualStyleBackColor = false;
            this.btn_Color4.Click += new System.EventHandler(this.btn_Color4_Click);
            // 
            // btn_Color3
            // 
            this.btn_Color3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Color3.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_Color3.Location = new System.Drawing.Point(84, 576);
            this.btn_Color3.Name = "btn_Color3";
            this.btn_Color3.Size = new System.Drawing.Size(21, 22);
            this.btn_Color3.TabIndex = 11;
            this.btn_Color3.UseVisualStyleBackColor = false;
            this.btn_Color3.Click += new System.EventHandler(this.btn_Color3_Click);
            // 
            // btn_Color5
            // 
            this.btn_Color5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Color5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Color5.Location = new System.Drawing.Point(4, 576);
            this.btn_Color5.Name = "btn_Color5";
            this.btn_Color5.Size = new System.Drawing.Size(21, 22);
            this.btn_Color5.TabIndex = 13;
            this.btn_Color5.UseVisualStyleBackColor = false;
            this.btn_Color5.Click += new System.EventHandler(this.btn_Color5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 608);
            this.Controls.Add(this.btn_Color5);
            this.Controls.Add(this.btn_Color1);
            this.Controls.Add(this.btn_Color3);
            this.Controls.Add(this.btn_Color4);
            this.Controls.Add(this.btn_Color2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1069, 1822);
            this.MinimumSize = new System.Drawing.Size(1069, 647);
            this.Name = "Form1";
            this.Text = "TileSetZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_original)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_main)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdb_wall;
        private RadioButton rdb_floor;
        private PictureBox pbx_original;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openImageToolStripMenuItem;
        private ToolStripMenuItem saveTilesetToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolTip toolTip1;
        private PictureBox pbx_main;
        private Panel panel1;
        private Button btn_Generate;
        private Button btn_TrimColor;
        private Label label1;
        private Button btn_Color2;
        private Button btn_Color4;
        private Button btn_Color3;
        private Button btn_Color1;
        private RadioButton rdb_Roof;
        private Button btn_Color5;
    }
}