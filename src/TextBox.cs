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
    public class TextBox
    {
        public string text;
        public Sys.ConsoleKeyEx LastKey;
        public string name;
        public bool GetKeyDown(Sys.ConsoleKeyEx key)
        {
            return false;
        }
    }
}
