using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using Sys = Cosmos.System;
using Cosmos.System.Graphics.Fonts;
using Cosmos.System.Graphics;
using System.Drawing;
using Cosmos.System.Network;
using Cosmos.Core.IOGroup;
namespace ToRun_OS
{
    public class Button
    {
        public static List<Button> bl = new List<Button>();
        public string text;
        public Canvas CANVAS;
        public Pen PEN;
        public int Width;
        public int Height;
        public GUIContext Context;
        public int X;
        public bool clicked = false;
        public int Y;
        public Button(GUIContext context, string text, Canvas canvas,Pen pen,int x,int y,int width,int height)
        {
            bl.Add(this);
            this.Context = context;
            this.CANVAS = canvas;
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
            this.PEN = pen;
            this.text = text;
        }
        public void Show()
        {
            CANVAS.DrawFilledRectangle(PEN, X, Y, Width, Height);
            PEN.Color = Color.LightGray;
            CANVAS.DrawRectangle(PEN, X, Y, Width, Height);
            PEN.Color = Color.White;
            CANVAS.DrawString(text,PCScreenFont.Default,PEN,X + Width / 2,Y + Height / 2);
        }
        public void Remove()
        {
            bl.Remove(this);
        }
        public void onClicked()
        {

        }
        public static void Refresh() //put this method on the while statement
        {
            foreach (Button B in bl)
            {
                if (Sys.MouseManager.MouseState == Sys.MouseState.Left /*&& Sys.MouseManager.X > (B.X - B.Width) && Sys.MouseManager.X < (B.X + B.Width) && Sys.MouseManager.Y > (B.Y - B.Height ) && Sys.MouseManager.Y < (B.Y + B.Height) */&& !B.clicked && GUIContext.isInContext)
                {
                    B.onClicked();
                    B.clicked = true;
                }
            }
        }
    }
}
