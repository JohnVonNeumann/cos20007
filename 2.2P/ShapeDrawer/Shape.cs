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