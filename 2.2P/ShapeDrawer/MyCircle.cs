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
            bool pointWithinRange = false;
            double xMax = X + _radius;
            double xMin = X - _radius;
            double yMax = Y + _radius;
            double yMin = Y - _radius;
            if ((pt.X > xMin) && (pt.X < xMax))
            {
                if ((pt.Y > yMin) && (pt.Y < yMax))
                {
                    pointWithinRange = true;
                }    
            } 
                
            return pointWithinRange;
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