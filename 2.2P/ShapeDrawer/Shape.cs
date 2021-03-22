using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Shape
    {
        private Color _color;
        private float _x, _y;
        private int _width, _height;
        
        public Shape()
        {
            _color = Color.Green;
            _x = 0;
            _y = 0;
            _height = 100;
            _width = 100;
        }

        /// <summary>
        /// property <c> X </c>
        /// Provides access to the X field through a getter and setter
        /// </summary>
        /// <returns> float - the value of _x which represents the x-coordinate of a shape </returns>
        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        /// <summary>
        /// property <c> Y </c>
        /// Provides access to the Y field through a getter and setter
        /// </summary>
        /// <returns> float - the value of _y which represents the y-coordinate of a shape </returns>
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public int Width()
        {

            return 0;
        }

        public int Height()
        {
            return 0;
        }

        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public Boolean IsAt(Point2D pt)
        {
            return true;
        }
    }
}