using System;
using SFML.System;
using SFML.Window;
using SFML.Graphics;

namespace platformer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var Window = new RenderWindow(
                new VideoMode(800,600), "Platformer"))
            {
                Window.Closed+= (o, e) => Window.Close();
                Clock clock= new Clock();
                while(Window.IsOpen) {
                    Window.DispatchEvents();
                    float deltaTime= clock.Restart().AsSeconds();
                    Window.Clear();
                    Window.Display();

                }
            }
        }
    }
}
