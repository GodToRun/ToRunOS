//import kernel namespaces
using System.Collections.Generic;
using Cosmos.System.Graphics.Fonts;
using Cosmos.System.Graphics;
using System.Drawing;
using CosmosKernel1;
namespace ToRun_OS
{
    public class GUIContext
    {
        public string name;
        Theme them;
        public bool inContext = false;
        public static List<GUIContext> contexts = new List<GUIContext>();
        public static bool isInContext = false;
        public Color DefaultUIColor = Color.Lime;
        public Color BGColor = Color.White;
        public static GUIContext context;
        public GUIContext(string Name,Kernel k)
        {
            if (!k.setup)
            {
                if (Kernel.Read(k.fs.GetFile(@"0:\Settings\theme.bool")) == "true")
                    them = Theme.Default;
                else
                    them = Theme.Classic;
            }
            contexts.Add(this);
            this.name = Name;
        }
        public void SetGUIContext(Canvas canvas)
        {
            context = this;
            inContext = true;
            isInContext = true;
            canvas.Clear(them.BGColor);
            Pen pen = new Pen(Color.LightGray);
            /*pen.Color = Color.White;
            canvas.DrawFilledRectangle(pen, 0, 0, 2000, 1000);*/
            pen.Color = them.UIColor;
            canvas.DrawFilledRectangle(pen, 0, 0, 2000, 35);
            pen.Color = Color.Black;
            canvas.DrawRectangle(pen, 0, 0, 2000, 35);
            pen.Color = Color.Red;
            canvas.DrawFilledRectangle(pen, 992, 1, 50, 34);
            pen.Color = Color.Black;
            canvas.DrawString(this.name, PCScreenFont.Default, pen, 400, 10);
            pen.Color = Color.White;
            canvas.DrawString("X", PCScreenFont.Default, pen, 1008, 5);
        }
        public void Close(CosmosKernel1.Kernel k,Canvas canvas,Pen pen)
        {
            isInContext = false;
            foreach (GUIContext c in contexts)
                c.inContext = false;
            k.DefaultDraw(canvas, pen);
        }
    }
}
