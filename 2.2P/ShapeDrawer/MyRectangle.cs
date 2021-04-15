namespace ShapeDrawer
{
    public class MyRectangle : Shape
    {
        private int _width, _height;
        
        
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