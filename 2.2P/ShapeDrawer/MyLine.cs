using System.Runtime.CompilerServices;
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
            throw new System.NotImplementedException();
        }

        public override bool IsAt(Point2D pt)
        {
            throw new System.NotImplementedException();
        }
    }
}