using System.IO;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        private float _length;

        public MyLine(Color color, float x, float y, int length) : base(color)
        {
            X = x;
            Y = y;
            _length = length;
        }

        public MyLine() : this(Color.Red, 0, 0, 100) {}

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(Color, X, Y, (X + _length), Y);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawCircle(
                clr: Color.Red,
                x: X,
                y: Y,
                radius: 5
                );
            SplashKit.DrawCircle(
                clr: Color.Red,
                x: (X + _length),
                y: Y,
                radius: 5
                );
        }

        public override bool IsAt(Point2D pt)
        {
            Point2D pointStart = new Point2D();
            pointStart.X = X;
            pointStart.Y = Y;

            Point2D pointEnd = new Point2D();
            pointEnd.X = X + _length;
            pointEnd.Y = Y;

            Line line = SplashKit.LineFrom(pointStart, pointEnd);
            return SplashKit.PointOnLine(pt, line);
        }
        
        public override void SaveTo(StreamWriter writer)
        {
            base.SaveTo(writer);
            writer.WriteLine(_length);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            _length = reader.ReadInteger();
        }
    }
}