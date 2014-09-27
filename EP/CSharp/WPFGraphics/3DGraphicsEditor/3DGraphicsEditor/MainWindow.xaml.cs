using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit; 

namespace _3DGraphicsEditor
{

    public partial class MainWindow : Window
    {
        //Model3DGroup shape;
        //List<ModelVisual3D> shapes;

        List<ShapeInfo> shapeInfoList;

        List<string> shapesNames;

        //Initialising basic variables such as the camera, including directions and position
        private PerspectiveCamera camera;
        private double camera_PosX = 9;
        private double camera_PosY = 8;
        private double camera_PosZ = 10;
        private double camera_DirX = -9;
        private double camera_DirY = -8;
        private double camera_DirZ = -10;

        //These variables will keep track of the shapes
        private int cuboidcount = 0;
        private int prismcount = 0;
        private int cylindercount = 0;

        public MainWindow()
        {
            InitializeComponent();


            //This list will enable to keep a copy of the shapes so that it is possible to find the selected shapes
            //shapes = new List<ModelVisual3D>();
            shapesNames = new List<string>();
            shapeInfoList = new List<ShapeInfo>();

            syncShapeNames();

            CreateBackground();

            ViewportListBox.SelectedIndex = 0;
            addShapelistBox.SelectedIndex = 0;
            AddColorNListbox();
        }

        private void AddColorNListbox() 
        {
                        
        }

        // Get the position and choose an appropiate method for drawing objects.
        private void addShapeButtonClick(object sender, RoutedEventArgs e)
        {
            if (addShapelistBox.SelectedItem.Equals(null) == true)
            {
                System.Windows.MessageBox.Show("No item selected", "Error");
            }
            else
            {
                double xPos = Convert.ToDouble(shapePositionXTextBox.Text);
                double yPos = Convert.ToDouble(shapePositionYTextBox.Text);
                double zPos = Convert.ToDouble(shapePositionZTextBox.Text);

                ListBoxItem s = (ListBoxItem)addShapelistBox.SelectedItem;
                Color color = ClrPckerShpe.SelectedColor;
                Material material = new DiffuseMaterial(new SolidColorBrush(color));

                if (s.Content.ToString() == "Cuboid")
                {//add cube
                    AddCube(xPos, yPos, zPos, 1, 1, 1, material);
                }

                if (s.Content.ToString() == "Prism")
                {// add triange
                    AddPrism(xPos, yPos, zPos, 1, 0.7, 1, material);

                }

                if (s.Content.ToString() == "Cylinder")
                {// add triange
                    AddCylinder(xPos, yPos, zPos, 1, 1, 1, 10, material);

                }

                if (s.Content.ToString() == "Background")
                {
                    if (shapesNames.IndexOf("Background") <= 0)
                    {
                        CreateBackground();
                    }
                    else {
                        System.Windows.MessageBox.Show("Background already exists", "Error");
                     }
                }

                updateViewportListBox();
            }
        }

       

        //Add a Cube. This method has been borrowed and adapted to pass paramiters to set shapes properties//--------
        private void AddCube(double x_offset, double y_offset, double z_offset, double x_size, double y_size, double z_size, Material material)
        {
            ShapeInfo shapeI = new ShapeInfo();
            
            cuboidcount += 1;
            string str = "Cuboid " + cuboidcount.ToString();
            shapesNames.Add(str);

            shapeI.name = str;
            shapeI.x = x_offset;
            shapeI.y = y_offset;
            shapeI.z = z_offset;
            shapeI.sizeX = x_size;
            shapeI.sizeY = y_size;
            shapeI.sizeZ = z_size;
            shapeI.material = material;

            Point3D p0 = new Point3D(0, 0, 0);
            Point3D p1 = new Point3D(x_size, 0, 0);
            Point3D p2 = new Point3D(x_size, 0, z_size);
            Point3D p3 = new Point3D(0, 0, z_size);
            Point3D p4 = new Point3D(0, y_size, 0);
            Point3D p5 = new Point3D(x_size, y_size, 0);
            Point3D p6 = new Point3D(x_size, y_size, z_size);
            Point3D p7 = new Point3D(0, y_size, z_size);

            Model3DGroup shape;
            shape = new Model3DGroup();
            //front side triangles
            shape.Children.Add(CreateTriangleModel(p3, p2, p6, material));
            shape.Children.Add(CreateTriangleModel(p3, p6, p7, material));
            //right side triangles
            shape.Children.Add(CreateTriangleModel(p2, p1, p5, material));
            shape.Children.Add(CreateTriangleModel(p2, p5, p6, material));
            //back side triangles
            shape.Children.Add(CreateTriangleModel(p1, p0, p4, material));
            shape.Children.Add(CreateTriangleModel(p1, p4, p5, material));
            //left side triangles
            shape.Children.Add(CreateTriangleModel(p0, p3, p7, material));
            shape.Children.Add(CreateTriangleModel(p0, p7, p4, material));
            //top side triangles
            shape.Children.Add(CreateTriangleModel(p7, p6, p5, material));
            shape.Children.Add(CreateTriangleModel(p7, p5, p4, material));
            //bottom side triangles
            shape.Children.Add(CreateTriangleModel(p2, p3, p0, material));
            shape.Children.Add(CreateTriangleModel(p2, p0, p1, material));

            ModelVisual3D model = new ModelVisual3D();
            model.Content = shape;

            Transform3DGroup myTransform3DGroup = new Transform3DGroup();
            TranslateTransform3D myTransform3D = new TranslateTransform3D();
            myTransform3D.OffsetY = y_offset;
            myTransform3D.OffsetX = x_offset;
            myTransform3D.OffsetZ = z_offset;

            // Add the scale transform to the Transform3DGroup.
            myTransform3DGroup.Children.Add(myTransform3D);

            model.Transform = myTransform3DGroup;
            //shapes.Add(shape);
            this.mainViewport.Children.Add(model);

            shapeI.shape = model;

            shapeInfoList.Add(shapeI);
        }

        private void AddPrism(double x_offset, double y_offset, double z_offset, double x_size, double y_size, double z_size, Material material)
        {


            ShapeInfo shapeI = new ShapeInfo();

            prismcount += 1;
            string str = "Prism " + prismcount.ToString();
            shapesNames.Add(str);

            shapeI.name = str;
            shapeI.x = x_offset;
            shapeI.y = y_offset;
            shapeI.z = z_offset;
            shapeI.sizeX = x_size;
            shapeI.sizeY = y_size;
            shapeI.sizeZ = z_size;
            shapeI.material = material;

            Point3D p0 = new Point3D(0, 0, 0);
            Point3D p1 = new Point3D(x_size, 0, 0);
            Point3D p2 = new Point3D(x_size, 0, z_size);
            Point3D p3 = new Point3D(0, 0, z_size);
            Point3D p4 = new Point3D(x_size / 2, y_size, z_size / 2);
            
            Model3DGroup shape;
            shape = new Model3DGroup();

            //bottom side triangles
            shape.Children.Add(CreateTriangleModel(p2, p3, p0, material));
            shape.Children.Add(CreateTriangleModel(p2, p0, p1, material));
            
            //front side triangle
            shape.Children.Add(CreateTriangleModel(p4, p3, p2, material));

            //right side triangle
            shape.Children.Add(CreateTriangleModel(p4, p2, p1, material));
            
            //back side triangle
            shape.Children.Add(CreateTriangleModel(p4, p1, p0, material));
            
            //left side triangle
            shape.Children.Add(CreateTriangleModel(p4, p0, p3, material));

            ModelVisual3D model = new ModelVisual3D();
            model.Content = shape;

            Transform3DGroup myTransform3DGroup = new Transform3DGroup();
            TranslateTransform3D myTransform3D = new TranslateTransform3D();
            myTransform3D.OffsetY = y_offset;
            myTransform3D.OffsetX = x_offset;
            myTransform3D.OffsetZ = z_offset;

            // Add the scale transform to the Transform3DGroup.
            myTransform3DGroup.Children.Add(myTransform3D);

            model.Transform = myTransform3DGroup;
            //shapes.Add(shape);
            this.mainViewport.Children.Add(model);
            
            shapeI.shape = model;
            shapeInfoList.Add(shapeI);


        }

        private void AddCylinder(double x_offset, double y_offset, double z_offset, double x_size, double y_size, double z_size, int Nofsides, Material material)
        {
            ShapeInfo shapeI = new ShapeInfo();

            cylindercount += 1;
            string str = "Cylinder " + cylindercount.ToString();
            shapesNames.Add(str);

            shapeI.name = str;
            shapeI.x = x_offset;
            shapeI.y = y_offset;
            shapeI.z = z_offset;
            shapeI.sizeX = x_size;
            shapeI.sizeY = y_size;
            shapeI.sizeZ = z_size;
            shapeI.material = material;

            double innerAngle = (2 * Math.PI / Nofsides); //+ 0.00001; 
            double x;
            double z;

            //set up an array for the number of sides which will give the shape.
            Point3D[] p = new Point3D[(2 * Nofsides + 4)];


            int Nofp = 0;

            Model3DGroup shape;
            shape = new Model3DGroup();

            for (int y = 0; y < 2; y++)
            {
                p[Nofp] = new Point3D((x_size / 2), y, (z_size / 2));
                Nofp++;

                for (int i = 1; i <= Nofsides; i++)
                {
                    x = Math.Cos((i - 1) * innerAngle);
                    z = Math.Sin((i - 1) * innerAngle);

                    //i + (Nofsides + 1) * y
                    p[Nofp] = new Point3D((x / 2) + (x_size / 2), y, (z / 2) + (z_size / 2));
                    Nofp++;

                    if (i != 1)
                    {
                        shape.Children.Add(CreateTriangleModel(p[0 + (Nofsides + 1) * y], p[i + y - 1 + (Nofsides + 1) * y], p[i + (y * -1) + (Nofsides + 1) * y], material));
                    }
                }
                //Material material = new DiffuseMaterial(new SolidColorBrush(color));
                Material mat = new DiffuseMaterial(new SolidColorBrush(Colors.Orange));
                shape.Children.Add(CreateTriangleModel(p[0 + (Nofsides + 1) * y], p[Nofsides + 2*y], p[1 + (Nofsides * y)], mat));
                
                for (int i = 1; i < Nofsides; i++)
                {
                    
                }

            }

            shapePositionYTextBox.Text = (Nofp).ToString();

            ModelVisual3D model = new ModelVisual3D();
            model.Content = shape;

            Transform3DGroup myTransform3DGroup = new Transform3DGroup();
            TranslateTransform3D myTransform3D = new TranslateTransform3D();
            myTransform3D.OffsetY = y_offset;
            myTransform3D.OffsetX = x_offset;
            myTransform3D.OffsetZ = z_offset;

            // Add the scale transform to the Transform3DGroup.
            myTransform3DGroup.Children.Add(myTransform3D);

            model.Transform = myTransform3DGroup;
            //shapes.Add(shape);
            this.mainViewport.Children.Add(model);
            
            shapeI.shape = model;
            shapeInfoList.Add(shapeI);

        }

        //Sync all components
        private void syncShapeNames()
        {
            

            ModelVisual3D m;
            int i = 0;
            while (mainViewport.Children.Count - shapeInfoList.Count > 0)
            {
                ShapeInfo shapeI = new ShapeInfo();
                m = (ModelVisual3D)mainViewport.Children[i];
                shapeI.shape = m;
                if (m.Content is DirectionalLight == true)
                { 
                    shapesNames.Add("Light");
                    shapeI.name = "Light"; 
                }
                else 
                { 
                    shapesNames.Add("Some Shape"); 
                    shapeI.name = "Some Shape"; 
                }
                shapeInfoList.Add(shapeI);
                i++;
            }
        }

        private void updateViewportListBox()
        {
            int i;

            for (i = ViewportListBox.Items.Count - 1; i >= 0; i--)
            {
                ViewportListBox.Items.RemoveAt(i);
            }

            for (i = 0; i <= shapesNames.Count - 1; i++)
            {
                ViewportListBox.Items.Add(shapesNames[i]);
            }
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            ListBoxItem s = (ListBoxItem)addShapelistBox.SelectedItem;
            int Itemindex = ViewportListBox.SelectedIndex;

            if (Itemindex == -1) 
            {
                System.Windows.MessageBox.Show("No shape to delete", "Selection Error");
            }
            else
            {
                DeleteItem(Itemindex);
            }
        }

        private void DeleteItem(int index)
        {
            //ShapeInfo shapeI = new ShapeInfo();
            ModelVisual3D m;
            m = (ModelVisual3D)mainViewport.Children[index];
            if (m.Content is DirectionalLight == false)
            {
                mainViewport.Children.Remove(m);
                shapeInfoList.Remove(shapeInfoList[index]);
                shapesNames.Remove(shapesNames[index]);
            }
            updateViewportListBox();
        }

        private void updateListButtonClick(object sender, RoutedEventArgs e)
        {
            string str;

            ModelVisual3D m;
            for (int i = mainViewport.Children.Count - 1; i >= 0; i--)
            {
                ShapeInfo shapeI = new ShapeInfo();
                m = (ModelVisual3D)mainViewport.Children[i];
                shapeI.shape = m;
                if (m.Content is DirectionalLight == true) { str = "Light";}
                else { str = "Shape"; }
                shapesNames.Add(str);
                shapeI.name = (str);
                shapeInfoList.Add(shapeI);
            }
            updateViewportListBox();
        }

        private void setBackground(double size, Material material)
        {
            ShapeInfo shapeI = new ShapeInfo();
            Model3DGroup Background = new Model3DGroup();
            Point3D p0 = new Point3D(-size, 0, -size);
            Point3D p1 = new Point3D(size, 0, -size);
            Point3D p2 = new Point3D(size, 0, size);
            Point3D p3 = new Point3D(-size, 0, size);

            Background.Children.Add(CreateTriangleModel(p2, p1, p0, material));
            Background.Children.Add(CreateTriangleModel(p0, p3, p2, material));

            ModelVisual3D model = new ModelVisual3D();
            model.Content = Background;
            this.mainViewport.Children.Add(model);

            shapeI.x = -size;
            shapeI.y = 0;
            shapeI.z = -size;

            shapeI.sizeX = size * 2;
            shapeI.sizeZ = size * 2;

            shapeI.shape = model;
 
            shapesNames.Add("Background");
            shapeI.name = "Background";
            shapeInfoList.Add(shapeI);
        }

        private void CreateBackground()
        {
            Material material = new DiffuseMaterial(new SolidColorBrush(Colors.MediumSeaGreen));
            setBackground(160, material);
        }

        private Vector3D CalculateNormal(Point3D p0, Point3D p1, Point3D p2)
        {
            Vector3D v0 = new Vector3D(
                p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z);
            Vector3D v1 = new Vector3D(
                p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z);
            return Vector3D.CrossProduct(v0, v1);
        }

        private void ClearViewport()
        {
            ModelVisual3D m;
            for (int i = mainViewport.Children.Count - 1; i >= 0; i--)
            {
                m = (ModelVisual3D)mainViewport.Children[i];
                if (m.Content is DirectionalLight == false)
                {
                    mainViewport.Children.Remove(m);
                    shapeInfoList.Remove(shapeInfoList[i]);
                    shapesNames.Remove(shapesNames[i]);
                }
            }
            updateViewportListBox();
        }


        private void iniCamPosButtonClick(object sender, RoutedEventArgs e)
        {
            camera_PosX = 9;
            camera_PosY = 8;
            camera_PosZ = 10;

            SetCamera();
        }


        private void SetCamera()
        {
            camera = (PerspectiveCamera)mainViewport.Camera;
            Point3D position = new Point3D(camera_PosX, camera_PosY, camera_PosZ);
            camera_DirX = -camera_PosX;
            camera_DirY = -camera_PosY;
            camera_DirZ = -camera_PosZ;
            Vector3D lookDirection = new Vector3D(camera_DirX, camera_DirY, camera_DirZ);

            camera.Position = position;
            camera.LookDirection = lookDirection;
        }

        private void mainViewport_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            double h;
            double ratio = 1;
            h = Math.Sqrt(camera_PosX * camera_PosX + camera_PosY * camera_PosY + camera_PosZ * camera_PosZ);

            if (e.Delta > 0)
            {
                ratio = h / (h + 1);
            }

            else if (e.Delta < 0)
            {
                ratio = (h + 1) / h;
            }

            camera_PosX *= ratio;
            camera_PosY *= ratio;
            camera_PosZ *= ratio;

            SetCamera();
        }

        //********************************************************************************************************************************
        private void simpleButtonClick(object sender, RoutedEventArgs e)
        {
            Model3DGroup triangle = new Model3DGroup();
            Point3D p0 = new Point3D(0, 1, 0);
            Point3D p1 = new Point3D(5, 1, 0);
            Point3D p2 = new Point3D(0, 1, 5);

            Point3D p3 = new Point3D(0, 10, 0);
            Point3D p4 = new Point3D(5, 10, 0);
            Point3D p5 = new Point3D(0, 10, 5);
            /**/

            ScaleTransform3D s = new ScaleTransform3D();
            s.CenterX = 1;
            s.CenterY = 1;
            s.CenterZ = 1;
            s.ScaleX = 2;
            s.ScaleY = 4;
            s.ScaleZ = 14;
            s.Transform(p0);
            s.Transform(p1);
            s.Transform(p2);

            Material material = new DiffuseMaterial(new SolidColorBrush(Colors.DarkKhaki));
            triangle.Children.Add(CreateTriangleModel(p2, p1, p0, material));
            triangle.Children.Add(CreateTriangleModel(p5, p4, p3, material));

            ModelVisual3D model = new ModelVisual3D();
            model.Content = triangle;
            this.mainViewport.Children.Add(model);
        }



        private void cameraButtonClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void cubeButtonClick(object sender, RoutedEventArgs e)
        {
            Point3D p0 = new Point3D(0, 0, 0);
            Point3D p1 = new Point3D(5, 0, 0);
            Point3D p2 = new Point3D(5, 0, 5);
            Point3D p3 = new Point3D(0, 0, 5);
            Point3D p4 = new Point3D(0, 5, 0);
            Point3D p5 = new Point3D(5, 5, 0);
            Point3D p6 = new Point3D(5, 5, 5);
            Point3D p7 = new Point3D(0, 5, 5);

            Model3DGroup shape;
            shape = new Model3DGroup();
            Material material = new DiffuseMaterial(new SolidColorBrush(Colors.SkyBlue));
            //front side triangles
            shape.Children.Add(CreateTriangleModel(p3, p2, p6, material));
            shape.Children.Add(CreateTriangleModel(p3, p6, p7, material));
            //right side triangles
            shape.Children.Add(CreateTriangleModel(p2, p1, p5, material));
            shape.Children.Add(CreateTriangleModel(p2, p5, p6, material));
            //back side triangles
            shape.Children.Add(CreateTriangleModel(p1, p0, p4, material));
            shape.Children.Add(CreateTriangleModel(p1, p4, p5, material));
            //left side triangles
            shape.Children.Add(CreateTriangleModel(p0, p3, p7, material));
            shape.Children.Add(CreateTriangleModel(p0, p7, p4, material));
            //top side triangles
            shape.Children.Add(CreateTriangleModel(p7, p6, p5, material));
            shape.Children.Add(CreateTriangleModel(p7, p5, p4, material));
            //bottom side triangles
            shape.Children.Add(CreateTriangleModel(p2, p3, p0, material));
            shape.Children.Add(CreateTriangleModel(p2, p0, p1, material));

            ModelVisual3D model = new ModelVisual3D();
            model.Content = shape;
            //shapes.Add(shape);
            this.mainViewport.Children.Add(model);
        }

        private Model3DGroup CreateTriangleModel(Point3D p0, Point3D p1, Point3D p2, Material material)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();
            mesh.Positions.Add(p0);
            mesh.Positions.Add(p1);
            mesh.Positions.Add(p2);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            Vector3D normal = CalculateNormal(p0, p1, p2);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);
            GeometryModel3D model = new GeometryModel3D(mesh, material);
            Model3DGroup group = new Model3DGroup();
            group.Children.Add(model);
            return group;
        }

        private void mainViewport_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void StackPanel_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void StackPanel_KeyDown(object sender, KeyEventArgs e)
        {
            //Camera controls
            if (e.Key == Key.NumPad4) { camera_PosX -= 1; }
            if (e.Key == Key.NumPad7) { camera_PosX += 1; }
            if (e.Key == Key.NumPad5) { camera_PosY -= 1; }
            if (e.Key == Key.NumPad8) { camera_PosY += 1; }
            if (e.Key == Key.NumPad6) { camera_PosZ -= 1; }
            if (e.Key == Key.NumPad9) { camera_PosZ += 1; }
            if (e.Key == Key.NumPad1) { NewCameraPos(ref camera_PosX, ref camera_PosY, ref camera_PosZ, 1); }
            if (e.Key == Key.NumPad3) { NewCameraPos(ref camera_PosX, ref camera_PosY, ref camera_PosZ, -1);  }

            //Next Shape section
            if (e.Key == Key.Delete)
            {
                DeleteItem(ViewportListBox.SelectedIndex);
            }
            /**
            if ((e.Key == Key.E) || (e.Key == Key.R) || (e.Key == Key.F) || (e.Key == Key.D))
            {

                //rotate around y-axis
                double h = Math.Sqrt(camera_PosX*camera_PosX + camera_PosZ*camera_PosZ);
                double angle_theta = 0.1;
                double angle_alpha = Math.Atan(camera_PosX/camera_PosZ) - angle_theta;

                double angle_beta1 = ((Math.PI - angle_theta) / 2) - (angle_alpha + angle_theta);
                double angle_beta2 = ((Math.PI - angle_theta) / 2) - angle_alpha;

                double small_h = 2 * h * Math.Sin(angle_theta / 2);
                double delta_x = 1;
                double delta_z = 1;


                if ((camera_PosX < camera_PosZ) & (camera_PosX > 0)) 
                    { delta_x = -delta_x; }
                
                if ((camera_PosZ < -h) || (camera_PosZ > h)) { delta_z = -delta_z; }


                if (e.Key == Key.E)
                {
                    //delta_x = small_h * Math.Cos(angle_beta2);
                    //delta_z = -small_h * Math.Sin(angle_beta2);

                }

                if (e.Key == Key.R)
                {
                    //delta_x = -small_h * Math.Cos(angle_beta1);
                    //delta_z = small_h * Math.Sin(angle_beta1);
                }

                //if ((camera_PosX < -h) || (camera_PosX > h)) { delta_x = -delta_x; }
                //if ((camera_PosZ < -h) || (camera_PosZ > h)) { delta_z = -delta_z; }
                
                camera_PosX += delta_x;
                camera_PosZ += delta_z;
            **/



            if (e.Key == Key.D1)
            {
                //create triange 
            }

            if (e.Key == Key.D2)
            {
                //create square 
            }

            if (e.Key == Key.D3)
            {
                //create cube
            }


            SetCamera();
        }

        private void NewCameraPos(ref double x, ref double y, ref double z, int dir)
        {
            double tsize = 2 * Math.PI / 16; // in radians

            double h = Math.Sqrt(camera_PosX * camera_PosX + camera_PosZ * camera_PosZ);

            double theta = Convert.ToInt32(Math.Acos((x)/(Math.Pow(x*x+z*z, 0.5))));
            double tcur;

            tcur = Math.Round(theta / tsize);


            if (dir == -1)
            {
                x = Math.Cos((tcur + 1) * tsize);
                z = Math.Sin((tcur + 1) * tsize);
            }
            else
            {
                x = Math.Cos((tcur - 1) * tsize);
                z = Math.Sin((tcur - 1) * tsize);
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clearButtonClick(object sender, RoutedEventArgs e)
        {
            ClearViewport();
        }

        private void BackgroundButtonClick(object sender, RoutedEventArgs e)
        {
            CreateBackground();
        }

        private void Transform()
        {
            Transform3DGroup myTransform3DGroup = new Transform3DGroup();

            // Create and apply a scale transformation that stretches the object along the local x-axis   
            // by 200 percent and shrinks it along the local y-axis by 50 percent.
            ScaleTransform3D myScaleTransform3D = new ScaleTransform3D();
            myScaleTransform3D.ScaleX = 2;
            myScaleTransform3D.ScaleY = 0.5;
            myScaleTransform3D.ScaleZ = 1;

            // Add the scale transform to the Transform3DGroup.
            myTransform3DGroup.Children.Add(myScaleTransform3D);

            // Set the Transform property of the GeometryModel to the Transform3DGroup which includes  
            // both transformations. The 3D object now has two Transformations applied to it.
            //mainViewport.c = myTransform3DGroup;

            Model3DGroup mg = new Model3DGroup();

            ModelVisual3D m;
            for (int i = mainViewport.Children.Count - 1; i >= 0; i--)
            {
                m = (ModelVisual3D)mainViewport.Children[i];
                if (m.Content is DirectionalLight == false)
                {
                    //if (m.Content == shape)
                    //{
                        m.Transform = myScaleTransform3D;
                    //}
                }

            }
        }


        //Selection change//-------------------------------
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ListBoxItem s = (ListBoxItem)addShapelistBox.SelectedItem;
            int Itemindex = ViewportListBox.SelectedIndex;
            if (Itemindex < 0) { System.Windows.MessageBox.Show("No item selected", "Error"); }
            else 
            {
                displayEditShapeMenu(Itemindex);
            }
        }

        //Display all infromation on about the object//-------------------------------
        private void displayEditShapeMenu(int itemIndex)
        {
            shapeNameTextBlock.Text = shapeInfoList[itemIndex].name;

            EditShapePosXTextBox.Text = Convert.ToString(shapeInfoList[itemIndex].x);
            EditShapePosYTextBox.Text = Convert.ToString(shapeInfoList[itemIndex].y);
            EditShapePosZTextBox.Text = Convert.ToString(shapeInfoList[itemIndex].z);

            if (updateEditInfoRadBut.IsChecked == true)
            {
                EditShapeSizeXTextBox.Text = Convert.ToString(shapeInfoList[itemIndex].sizeX);
                EditShapeSizeYTextBox.Text = Convert.ToString(shapeInfoList[itemIndex].sizeY);
                EditShapeSizeZTextBox.Text = Convert.ToString(shapeInfoList[itemIndex].sizeZ);

                EditShapeRotXTextBox.Text = Convert.ToString(shapeInfoList[itemIndex].rot_x);
                EditShapeRotZTextBox.Text = Convert.ToString(shapeInfoList[itemIndex].rot_z);
                EditShapeRotYTextBox.Text = Convert.ToString(shapeInfoList[itemIndex].rot_y);

                EditShapeAngleTextBox.Text = Convert.ToString(shapeInfoList[itemIndex].RotAngle);
            }
        }

        //When the edit button is clicked//----------------------------------
        private void editShapeButtonClick(object sender, RoutedEventArgs e)
        {
            int ItemIndex = ViewportListBox.SelectedIndex;

            double posX = Convert.ToDouble(EditShapePosXTextBox.Text);
            double posY = Convert.ToDouble(EditShapePosYTextBox.Text);
            double posZ = Convert.ToDouble(EditShapePosZTextBox.Text);
            double sizeX = Convert.ToDouble(EditShapeSizeXTextBox.Text);
            double sizeY = Convert.ToDouble(EditShapeSizeYTextBox.Text);
            double sizeZ = Convert.ToDouble(EditShapeSizeZTextBox.Text);
            double rotX = Convert.ToDouble(EditShapeRotXTextBox.Text);
            double rotY = Convert.ToDouble(EditShapeRotYTextBox.Text);
            double rotZ = Convert.ToDouble(EditShapeRotZTextBox.Text);
            double rotangle = Convert.ToDouble(EditShapeAngleTextBox.Text);

            Transform3DGroup myTransform3DGroup = new Transform3DGroup();
            ScaleTransform3D myScaleTransform3D = new ScaleTransform3D();
            myScaleTransform3D.ScaleX = sizeX;
            myScaleTransform3D.ScaleY = sizeY;
            myScaleTransform3D.ScaleZ = sizeZ;

            TranslateTransform3D myTranslateTransform3D = new TranslateTransform3D();
            myTranslateTransform3D.OffsetY = posY;
            myTranslateTransform3D.OffsetX = posX;
            myTranslateTransform3D.OffsetZ = posZ;

            RotateTransform3D myRotateTransform3D = new RotateTransform3D();
            AxisAngleRotation3D ax3d = new AxisAngleRotation3D(new Vector3D(rotX, rotY, rotZ), rotangle);
            myRotateTransform3D.Rotation = ax3d;
            
            // Add the scale transform to the Transform3DGroup.
            myTransform3DGroup.Children.Add(myScaleTransform3D);
            myTransform3DGroup.Children.Add(myTranslateTransform3D);
            myTransform3DGroup.Children.Add(myRotateTransform3D);

            ModelVisual3D m = (ModelVisual3D)mainViewport.Children[ItemIndex];
            m.Transform = myTransform3DGroup;

            shapeInfoList[ItemIndex].x = posX;
            shapeInfoList[ItemIndex].y = posY;
            shapeInfoList[ItemIndex].z = posZ;

            shapeInfoList[ItemIndex].sizeX = sizeX;
            shapeInfoList[ItemIndex].sizeY = sizeY;
            shapeInfoList[ItemIndex].sizeZ = sizeZ;

            shapeInfoList[ItemIndex].rot_x = rotX;
            shapeInfoList[ItemIndex].rot_x = rotY;
            shapeInfoList[ItemIndex].rot_y = rotZ;
            shapeInfoList[ItemIndex].RotAngle = rotangle;
           
            shapeInfoList[ItemIndex].shape = m;
        }


        private void colorButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void colorButtonClick(object sender, RoutedEventArgs e)
        {

            
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ClrPcker_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void destroyButtonClick(object sender, RoutedEventArgs e)
        {

        }

        //Math.Sqrt((Math.Pow((x_size/2),2)/(1+Math.Pow((1/Math.Tan(innerAngle*(i+1))),2))));
        //Math.Pow(-1, i) * Math.Sqrt((Math.Pow((x_size / 2), 2) / (1 + Math.Pow(Math.Tan(innerAngle * (i + 1)), 2))));

        /**
        if ((innerAngle * (i + 1) > Math.PI) & (innerAngle * (i + 1) < Math.PI*2))
        {
            z = -z;
        }
        if ((innerAngle * (i + 1) > Math.PI / 2) & (innerAngle * (i + 1) < Math.PI * 1.5))
        {
            x = -x;
        }
        **/
    }

    public class ShapeInfo
    {
        public string name = "";
        public double x = 0;
        public double y = 0;
        public double z = 0;
        public double sizeX = 0;
        public double sizeY = 0;
        public double sizeZ = 0;
        public double rot_x = 0;
        public double rot_y = 0;
        public double rot_z = 0;
        public double RotAngle = 0;

        public Material material = null;
        public ModelVisual3D shape = null;
    }
}