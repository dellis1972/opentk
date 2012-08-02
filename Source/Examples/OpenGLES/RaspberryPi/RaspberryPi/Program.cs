using System;
using System.Text;

using OpenTK.Graphics;
using OpenTK;

using GL = OpenTK.Graphics.ES20.GL;

namespace RaspberryPi
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SimpleES20Window example = new SimpleES20Window())
            {
                example.Run(30.0, 0.0);
            }
        }
    }

    public class SimpleES20Window : GameWindow
    {

        public SimpleES20Window()
            : base(320, 200, new GraphicsMode(16, 16), "", GameWindowFlags.Default, DisplayDevice.Default, 2, 0, GraphicsContextFlags.Embedded)
        { }


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.ClearColor(Color4.Red);
            GL.Clear(OpenTK.Graphics.ES20.ClearBufferMask.ColorBufferBit);

            SwapBuffers();            
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            if (Keyboard[OpenTK.Input.Key.Escape])
            {
                this.Exit();
                return;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
        }
    }
}
