using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using SplashKitSDK;

namespace ShapeDrawer
{
    public abstract class Shape
    {
        private Color _color;
        private float _x, _y;
        private bool _selected;
        private static Dictionary<string, Type> _shapeClassRegistry = new Dictionary<string, Type>();
        
        public Shape(Color color)
        {
            _color = color;
            _x = 0;
            _y = 0;
            _selected = false;
        }

        public Shape() : this(Color.Yellow)
        {
            
        }

        public static void RegisterShape(string name, Type t)
        {
            _shapeClassRegistry[name] = t;
        }

        public static Shape CreateShape(string name)
        {
            return (Shape) Activator.CreateInstance(_shapeClassRegistry[name]);
        }

        public bool Selected
        {
            get
            {
                return _selected;
            }

            set
            {
                _selected = value;
            }
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
        /// property <c> Color </c>
        /// Provides access to the Color field through a getter and setter
        /// </summary>
        /// <returns> Color - the colour value of the shape </returns>
        /// <remarks> The only issue I see here is passing a Colour to the setter if the object isn't passed. </remarks>
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        /// <summary>
        /// Method <c>Draw </c> - Simply uses the fields of the Shape to fill a rectangle on the screen.
        /// </summary>
        public abstract void Draw();

        public abstract void DrawOutline();

        public virtual void SaveTo(StreamWriter writer)
        {
            writer.WriteColor(_color);
            writer.WriteLine(_x);
            writer.WriteLine(_y);
        }

        public virtual void LoadFrom(StreamReader reader)
        {
            Color = reader.ReadColor();
            X = reader.ReadInteger();
            Y = reader.ReadInteger();
        }

        /// <summary>
        /// IsAt - Takes in a Point2D object and states it is within the boundaries of the Shape
        /// </summary>
        /// <param name="pt"> Point2D Object</param>
        /// <returns> boolean - true if the point is within the space of the Shape </returns>
        public abstract bool IsAt(Point2D pt);
    }
}