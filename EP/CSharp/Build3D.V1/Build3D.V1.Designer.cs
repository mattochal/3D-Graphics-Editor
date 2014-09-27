namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Toolbar = new System.Windows.Forms.Panel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Draw_line = new System.Windows.Forms.Button();
            this.button_Draw_Shape = new System.Windows.Forms.Button();
            this.button_Select = new System.Windows.Forms.Button();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel_Toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.cameraToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShowShortcutKeys = false;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.drawLinesToolStripMenuItem,
            this.drawShapeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // panel_Toolbar
            // 
            this.panel_Toolbar.Controls.Add(this.button_Select);
            this.panel_Toolbar.Controls.Add(this.button_Draw_Shape);
            this.panel_Toolbar.Controls.Add(this.button_Draw_line);
            this.panel_Toolbar.Controls.Add(this.button_Delete);
            this.panel_Toolbar.Location = new System.Drawing.Point(12, 27);
            this.panel_Toolbar.Name = "panel_Toolbar";
            this.panel_Toolbar.Size = new System.Drawing.Size(780, 50);
            this.panel_Toolbar.TabIndex = 1;
            // 
            // button_Delete
            // 
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Delete.Image = global::WindowsFormsApplication1.Properties.Resources.Eraser_icon_Small;
            this.button_Delete.Location = new System.Drawing.Point(56, 0);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(50, 50);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Draw_line
            // 
            this.button_Draw_line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Draw_line.Image = global::WindowsFormsApplication1.Properties.Resources.Pencil_icon_Small;
            this.button_Draw_line.Location = new System.Drawing.Point(112, 0);
            this.button_Draw_line.Name = "button_Draw_line";
            this.button_Draw_line.Size = new System.Drawing.Size(50, 50);
            this.button_Draw_line.TabIndex = 2;
            this.button_Draw_line.UseVisualStyleBackColor = true;
            // 
            // button_Draw_Shape
            // 
            this.button_Draw_Shape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Draw_Shape.Image = global::WindowsFormsApplication1.Properties.Resources.shape_handles_icon;
            this.button_Draw_Shape.Location = new System.Drawing.Point(168, 0);
            this.button_Draw_Shape.Name = "button_Draw_Shape";
            this.button_Draw_Shape.Size = new System.Drawing.Size(50, 50);
            this.button_Draw_Shape.TabIndex = 3;
            this.button_Draw_Shape.UseVisualStyleBackColor = true;
            // 
            // button_Select
            // 
            this.button_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Select.Image = global::WindowsFormsApplication1.Properties.Resources.Very_Basic_Cursor_icon_Small;
            this.button_Select.Location = new System.Drawing.Point(0, 0);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(50, 50);
            this.button_Select.TabIndex = 0;
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // drawLinesToolStripMenuItem
            // 
            this.drawLinesToolStripMenuItem.Name = "drawLinesToolStripMenuItem";
            this.drawLinesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.drawLinesToolStripMenuItem.Text = "Draw Lines";
            // 
            // drawShapeToolStripMenuItem
            // 
            this.drawShapeToolStripMenuItem.Name = "drawShapeToolStripMenuItem";
            this.drawShapeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.drawShapeToolStripMenuItem.Text = "Draw Shape";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 367);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_Toolbar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Build 3D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Toolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Toolbar;
        private System.Windows.Forms.Button button_Draw_Shape;
        private System.Windows.Forms.Button button_Draw_line;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawShapeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

