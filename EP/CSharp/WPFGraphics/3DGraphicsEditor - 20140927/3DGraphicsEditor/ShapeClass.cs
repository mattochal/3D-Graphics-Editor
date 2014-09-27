using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Windows.Media.Imaging;

namespace _3DGraphicsEditor
{
    struct ShapeStruct
    {
        abstract private int X;
        abstract private int Y;
        abstract private int Z;
        abstract public Point3D Pos
        {
            get
            {
                Point3D p;
                p = new Point3D(X, Y, Z);
                return p;
            }

            set
            {
                
            }
        }
        abstract public int Xsize;
        abstract public int Ysize;
        abstract public int Zsize;
        abstract public Material Material;
        abstract public Model3DGroup Model;
    }

    struct Cuboid
    {

        public override Point3D Pos
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
