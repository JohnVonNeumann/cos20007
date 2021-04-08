using System.Collections.Generic;
using System.ComponentModel;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Drawing
    {

        private readonly List<Shape> _shapes;
        private readonly Color _background;

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
        
        public Color Background
        {
            get
            {
                return _background;
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