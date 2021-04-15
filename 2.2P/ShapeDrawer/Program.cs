using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle
        }
        
        public static void Main()
        {
            ShapeKind kindToAdd = ShapeKind.Circle;
            Drawing drawing = new Drawing();
            new Window("Shape Drawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    MyRectangle rectangle = new MyRectangle();
                    rectangle.X = SplashKit.MouseX();
                    rectangle.Y = SplashKit.MouseY();
                    drawing.AddShape(rectangle);
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    drawing.Background = Color.RandomRGB(255);
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    drawing.SelectShapesAt(SplashKit.MousePosition());
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    drawing.SelectShapesAt(SplashKit.MousePosition());
                    drawing.DeleteShapes(drawing.SelectedShapes);
                }

                drawing.Draw();
                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}