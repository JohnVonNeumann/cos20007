using System;
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
            bool pointWithinRange = false;
            double xMax = X + _length;
            double xMin = X;
            if ((pt.X > xMin) && (pt.X < xMax))
            {
                if (Math.Abs(pt.Y - Y) < 5)
                {
                    pointWithinRange = true;
                }
            }

            return pointWithinRange;
        }
        
        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Line");
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