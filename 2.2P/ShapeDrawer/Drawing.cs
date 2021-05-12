using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Drawing
    {

        private readonly List<Shape> _shapes;
        private Color _background;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this(Color.White)
        {
            
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape shape in _shapes)
            {
                shape.Draw();
            }
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape shape in _shapes)
            {
                shape.Selected = shape.IsAt(pt);
            }
        }

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();
                foreach (Shape shape in _shapes)
                {
                    if (shape.Selected)
                    {
                        result.Add(shape);
                    }
                }

                return result;
            }
        }
        
        public void DeleteShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                _shapes.Remove(shape);
            }
        }

        public void Save(string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            try
            {
                writer.WriteColor(_background);
                writer.WriteLine(ShapeCount);

                foreach (Shape shape in _shapes)
                {
                    shape.SaveTo(writer);
                }
            }
            finally
            {
                writer.Close();
            }
        }

        public void Load(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            try
            {
                Shape s;
                _background = reader.ReadColor();
                int count = reader.ReadInteger();

                _shapes.Clear();

                for (int i = 0; i < count; i++)
                {
                    string kind = reader.ReadLine();

                    s = Shape.CreateShape(kind);

                    s.LoadFrom(reader);
                    AddShape(s);
                }
            }
            finally
            {
                reader.Close();
            }
        }
        
        public Color Background
        {
            get
            {
                return _background;
            }

            set
            {
                _background = value;
            }
        }

        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }

    }
}