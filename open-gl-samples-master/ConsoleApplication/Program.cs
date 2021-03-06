﻿

using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Threading;
using System.Drawing;
using OpenTK.Input;

namespace ConsoleApplication
{
    class MyApplication
    {
        
        [STAThread]
        public static void Main()
        {
            var game = new GameWindow(800, 600);
            game.RenderFrame += Game_RenderFrame;
            game.Resize += Game_Resize;
            game.UpdateFrame += Game_UpdateFrame;
            game.WindowBorder = WindowBorder.Hidden;
            game.Title = "OPEN TK Test";
            game.WindowState = WindowState.Fullscreen;
            game.Run(60.0);
        }

        private static void Game_UpdateFrame(object sender, FrameEventArgs e)
        {
            var game = (GameWindow)sender;
            if (game.Keyboard[Key.Escape])
            {
                game.Exit();
            }
        }

        private static void Game_Resize(object sender, EventArgs e)
        {
            var game = (GameWindow)sender;
            GL.Viewport(0, 0, game.Width, game.Height);
        }

        static float theta = 0.0f;
        static float x = 0.0f;
        static float y = 0.0f;

        private static void Game_RenderFrame(
            object sender, FrameEventArgs e)
        {            
            GL.ClearColor(Color.Black);
            GL.Clear(
                ClearBufferMask.ColorBufferBit | 
                ClearBufferMask.DepthBufferBit
            );
            GL.PushMatrix();

            //GL.Begin(BeginMode.Lines);
            //GL.Color3(Color.Blue);
            //for (int i = 0; i < 50; i++)
            //{
            //    GL.Vertex2(i * 0.01, 0.0f);
            //    GL.Vertex2(i * 0.01, 0.5f);
            //}
            GL.End();

            x += 0.001f;

            //GL.Begin(BeginMode.Quads);
            //GL.Color3(Color.Red);
            //GL.Vertex2(-0.5 + x, 0.5f + x);
            //GL.Vertex2(-0.5 + x, 0.8f + x);
            //GL.Vertex2(-0.8 + x, 0.8f + x);
            //GL.Vertex2(-0.8 + x, 0.5f + x);
            //GL.End();

            //GL.Begin(BeginMode.Quads);
            //GL.Color3(Color.Orange);
            //GL.Vertex2(-0.6 + x, 0.6f + x);
            //GL.Vertex2(-0.9 + x, 0.9f + x);
            //GL.Vertex2(-0.9 + x, 0.9f + x);
            //GL.Vertex2(-0.9 + x, 0.6f + x);
            //GL.End();


            //GL.Begin(BeginMode.Lines);
            //GL.Color3(Color.Yellow);
            //GL.Vertex2(0.0, 0.0f);
            //GL.Vertex2(0.0, 0.8f);

            //GL.Vertex2(0.0, 0.0f);
            //GL.Vertex2(0.5, 0.0f);

            //GL.End();


            //GL.Begin(BeginMode.Polygon);

            for (int i = 0; i <= 50; i++) {
                GL.Rotate(theta, 1.0f, 0.0f, 1.0f);
                GL.Begin(BeginMode.Triangles);
                GL.Color3(Color.Blue);
                GL.Vertex2(-0.2 + x, 0.2f + x);
                //GL.Vertex2(0.0f, 0.0f);
                GL.Color3(Color.Red);
                GL.Vertex2(-0.3f, 0.0f);
                GL.Color3(Color.Orange);
                GL.Vertex2(0.0f, 0.3f);
                GL.End();


                GL.Rotate(theta, 0.0f, 0.0f, 1.0f);
                GL.Begin(BeginMode.Triangles);
                GL.Color3(Color.Purple);
                GL.Vertex2(-0.1 + x, 0.1f + x);
                //GL.Vertex2(0.0f, 0.0f);
                GL.Color3(Color.Coral);
                GL.Vertex2(-0.3f, 0.0f);
                GL.Color3(Color.Blue);
                GL.Vertex2(0.0f, 0.3f);
                GL.End();

                GL.Rotate(theta, 1.0f, 0.0f, 1.0f);
                GL.Begin(BeginMode.Triangles);
                GL.Color3(Color.Blue);
                GL.Vertex2(-0.1 + x, 0.1f + x);
                //GL.Vertex2(0.0f, 0.0f);
                GL.Color3(Color.BlueViolet);
                GL.Vertex2(-0.3f, 0.0f);
                GL.Color3(Color.Orange);
                GL.Vertex2(0.0f, 0.3f);
                GL.End();

                GL.Rotate(theta, 1.0f, 0.0f, 1.0f);
                GL.Begin(BeginMode.Triangles);
                GL.Color3(Color.Tomato);
                GL.Vertex2(-0.1 + x, 0.1f + x);
                //GL.Vertex2(0.0f, 0.0f);
                GL.Color3(Color.Orange);
                GL.Vertex2(-0.3f, 0.0f);
                GL.Color3(Color.Red);
                GL.Vertex2(0.0f, 0.3f);
                GL.End();

                //////////////////////////////////////////////////

                GL.Rotate(theta, 0.0f, 0.0f, 1.0f);
                //GL.Begin(BeginMode.Triangles);
                //GL.Color3(Color.Blue);
                //GL.Vertex2(-0.2 + x, 0.2f + x);
                ////GL.Vertex2(0.0f, 0.0f);
                //GL.Color3(Color.Red);
                //GL.Vertex2(-0.3f, 0.0f);
                //GL.Color3(Color.Orange);
                //GL.Vertex2(0.0f, 0.3f);
                //GL.End();


                //GL.Rotate(theta, 0.0f, 0.0f, 1.0f);
                //GL.Begin(BeginMode.Triangles);
                //GL.Color3(Color.Purple);
                //GL.Vertex2(-0.1 + x, 0.1f + x);
                ////GL.Vertex2(0.0f, 0.0f);
                //GL.Color3(Color.Coral);
                //GL.Vertex2(-0.3f, 0.0f);
                //GL.Color3(Color.Blue);
                //GL.Vertex2(0.0f, 0.3f);
                //GL.End();

     

            }

            //GL.Begin(BeginMode.Triangles);
            //GL.Color3(Color.Blue);
            //GL.Vertex2(0.0f, 0.0f);
            //GL.Color3(Color.Red);
            //GL.Vertex2(0.3f, 0.3f);
            //GL.Color3(Color.Orange);
            //GL.Vertex2(0.0f, 0.3f);
            //GL.End();

            GL.PopMatrix();
            var game = (GameWindow)sender;
            game.SwapBuffers();
            x += 0.01f;
            y += 0.01f;
            theta += 1.0f;
            Thread.Sleep(10);
        }

    }
}