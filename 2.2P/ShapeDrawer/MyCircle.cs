using System.IO;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyCircle : Shape
    {
        private int _radius;

        public MyCircle(Color colour, int radius)
        {
            _radius = radius;
        }
        
        public MyCircle() : this(Color.Blue, 50) {}

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillCircle(Color, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawCircle(
                clr: Color.Black,
                x: X,
                y: Y,
                radius: _radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            Point2D point = new Point2D();
            point.X = X;
            point.Y = Y;
            Circle circle = SplashKit.CircleAt(point, _radius);
            return SplashKit.PointInCircle(pt, circle);
        }
        
        public override void SaveTo(StreamWriter writer)
        {
            base.SaveTo(writer);
            writer.WriteLine(_radius);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            _radius = reader.ReadInteger();
        }

        public int Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                _radius = value;
            }
        }
    }
}