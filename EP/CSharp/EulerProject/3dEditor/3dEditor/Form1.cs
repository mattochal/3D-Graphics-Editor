using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Media3D;


namespace _3dEditor
{
    public partial class Form1 : Form
    {
        bool DrawLine;
        bool mouseUp = true;
        bool fdm = true; //fisrt down mouse clisk
        Point point;
        Point firstpoint;


        public Form1()
        {
            InitializeComponent();
        }

        private void Canvus_Box_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Button_DrawLine_Click(object sender, EventArgs e)
        {
            DrawLine = true; 
        }

        private void Canvus_Box_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void Canvus_Box_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;

            if (DrawLine == true)
            {
                if (fdm == true)
                {    
                    firstpoint = Canvus_Box.PointToClient(Cursor.Position);
                    fdm = false;
                };
            }
            /// the first coordinate

        }

        private void Canvus_Box_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseUp == false)
            {
                point = Canvus_Box.PointToClient(Cursor.Position);
                SolidBrush sb = new SolidBrush(System.Drawing.Color.Red);
                System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Black, 5);
                Graphics g = Canvus_Box.CreateGraphics();

                g.DrawLine(p, firstpoint, point);
            }
        }

        private void Canvus_Box_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp = true;
            fdm = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Viewport3D myViewport3D = new Viewport3D();
            //Model3DGroup myModel3DGroup = new Model3DGroup();
            //GeometryModel3D myGeometryModel = new GeometryModel3D();
            //ModelVisual3D myModelVisual3D = new ModelVisual3D();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
