namespace _3dEditor
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Button_DrawLine = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Canvus_Box = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(62, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 35);
            this.button6.TabIndex = 5;
            this.button6.Text = "Erase";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = " Arc";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = " Shape";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Button_DrawLine
            // 
            this.Button_DrawLine.Location = new System.Drawing.Point(6, 16);
            this.Button_DrawLine.Name = "Button_DrawLine";
            this.Button_DrawLine.Size = new System.Drawing.Size(50, 35);
            this.Button_DrawLine.TabIndex = 1;
            this.Button_DrawLine.Text = "Line";
            this.Button_DrawLine.UseVisualStyleBackColor = true;
            this.Button_DrawLine.Click += new System.EventHandler(this.Button_DrawLine_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_DrawLine);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(138, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 57);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Draw";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(322, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 57);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(528, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 57);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Camera View";
            // 
            // Canvus_Box
            // 
            this.Canvus_Box.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Canvus_Box.Location = new System.Drawing.Point(12, 68);
            this.Canvus_Box.Name = "Canvus_Box";
            this.Canvus_Box.Size = new System.Drawing.Size(901, 384);
            this.Canvus_Box.TabIndex = 0;
            this.Canvus_Box.Click += new System.EventHandler(this.Button_DrawLine_Click);
            this.Canvus_Box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvus_Box_MouseClick);
            this.Canvus_Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvus_Box_MouseDown);
            this.Canvus_Box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvus_Box_MouseMove);
            this.Canvus_Box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvus_Box_MouseUp);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 461);
            this.Controls.Add(this.Canvus_Box);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Button_DrawLine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel Canvus_Box;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

