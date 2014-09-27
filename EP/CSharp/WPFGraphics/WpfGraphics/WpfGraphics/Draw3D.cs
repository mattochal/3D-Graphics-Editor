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
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGraphics
{
    class DrawGraphics
    {

    }

    class DrawTriangle
    {
        Viewport3D myViewport3D;
        Model3DGroup myModel3DGroup;
        GeometryModel3D myGeometryModel;
        ModelVisual3D myModelVisual3D;
        PerspectiveCamera myPCamera;
        DirectionalLight myDirectionalLight;


        private Point3D p1;
        private Point3D p2;
        private Point3D p3;

        public ModelVisual3D Triangle(Point3D p1, Point3D p2, Point3D p3)
        {
            myViewport3D = new Viewport3D();
            myModel3DGroup = new Model3DGroup();
            myGeometryModel = new GeometryModel3D();
            myModelVisual3D = new ModelVisual3D();

            myDirectionalLight = new DirectionalLight();
            myDirectionalLight.Color = Colors.White;
            myDirectionalLight.Direction = new Vector3D(-0.61, -0.5, -0.61);

            myModel3DGroup.Children.Add(myDirectionalLight);

            // The geometry specifes the shape of the 3D plane. In this sample, a flat sheet 
            // is created.
            MeshGeometry3D myMeshGeometry3D = new MeshGeometry3D();
            /**/
            // Create a collection of normal vectors for the MeshGeometry3D.
            Vector3DCollection myNormalCollection = new Vector3DCollection();
            myNormalCollection.Add(new Vector3D(0, 0, 1));
            myNormalCollection.Add(new Vector3D(0, 0, 1));
            myNormalCollection.Add(new Vector3D(0, 0, 1));

            myMeshGeometry3D.Normals = myNormalCollection;
            /**/

            // Create a collection of vertex positions for the MeshGeometry3D. 
            Point3DCollection myPositionCollection = new Point3DCollection();
            myPositionCollection.Add(new Point3D(p1.X, p1.Y, p1.Z));
            myPositionCollection.Add(new Point3D(p2.X, p2.Y, p2.Z));
            myPositionCollection.Add(new Point3D(p3.X, p3.Y, p3.Z));

            myMeshGeometry3D.Positions = myPositionCollection;

            // Create a collection of texture coordinates for the MeshGeometry3D.
            PointCollection myTextureCoordinatesCollection = new PointCollection();
            myTextureCoordinatesCollection.Add(new Point(0, 0));
            myTextureCoordinatesCollection.Add(new Point(1, 0));
            myTextureCoordinatesCollection.Add(new Point(1, 1));

            /****/
            myMeshGeometry3D.TextureCoordinates = myTextureCoordinatesCollection;

            // Create a collection of triangle indices for the MeshGeometry3D.
            Int32Collection myTriangleIndicesCollection = new Int32Collection();
            myTriangleIndicesCollection.Add(0);
            myTriangleIndicesCollection.Add(1);
            myTriangleIndicesCollection.Add(2);

            /****/
            myMeshGeometry3D.TriangleIndices = myTriangleIndicesCollection;

            // Apply the mesh to the geometry model.
            myGeometryModel.Geometry = myMeshGeometry3D;

            // The material specifies the material applied to the 3D object. In this sample a  
            // linear gradient covers the surface of the 3D object.

            // Create a horizontal linear gradient with four stops.   
            LinearGradientBrush myHorizontalGradient = new LinearGradientBrush();
            myHorizontalGradient.StartPoint = new Point(0, 0.5);
            myHorizontalGradient.GradientStops.Add(new GradientStop(Colors.Blue, 0.0));

            // Define material and apply to the mesh geometries.
            DiffuseMaterial myMaterial = new DiffuseMaterial(myHorizontalGradient);
            myGeometryModel.Material = myMaterial;
            
            // Add the geometry model to the model group.
            myModel3DGroup.Children.Add(myGeometryModel);

            // Add the group of models to the ModelVisual3d.
            myModelVisual3D.Content = myModel3DGroup;

            // Apply the viewport to the page so it will be rendered.
            return myModelVisual3D;
        }
        public ModelVisual3D Rectangle(Point3D p1, Point3D p2, Point3D p3, Point3D p4)
        {
         /*   ModelVisual3D t1 = new DrawTriangle;
            ModelVisual3D t2 = new DrawTriangle;
            t1.DrawTriangleTriangle(p1, p2, p3);
            t2.DrawTriangleTriangle(p1, p2, p3);
            
            ModelVisual3D rec = 
            return */
        }
    }
}
