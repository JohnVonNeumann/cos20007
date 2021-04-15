using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyRectangle : Shape
    {
        private int _width, _height;

        public MyRectangle(Color color, float x, float y, int width, int height) : base(color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public MyRectangle() : this(Color.Green, 0, 0, 100, 100) {}

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(Color, X, Y, Width, Height);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(
                clr: Color.Black,
                x: (X - 2),
                y: (Y - 2),
                width: (Width + 4),
                height: (Height + 4)
                );
        }

        public override bool IsAt(Point2D pt)
        {
            bool pointWithinRange = false;
            double xMax = X + _width;
            double yMax = Y + _height;
            if ((pt.X > X) && (pt.X < xMax))
            {
                if ((pt.Y > Y) && (pt.Y < yMax))
                {
                    pointWithinRange = true;
                }
            }

            return pointWithinRange;
        }

        /// <summary>
        /// property <c> Width </c>
        /// Provides access to the Width field through a getter and setter
        /// </summary>
        /// <returns> int - the value of _width which represents the width of a shape </returns>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        /// <summary>
        /// property <c> Height </c>
        /// Provides access to the Height field through a getter and setter
        /// </summary>
        /// <returns> float - the value of _height which represents the height of a shape </returns>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
    }
}