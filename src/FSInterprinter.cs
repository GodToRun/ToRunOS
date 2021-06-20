using System;
using System.Collections.Generic;
using System.Text;

namespace ToRun_OS
{
    class FSInterprinter
    {
        public static void Interprint(string line, string parameter,CosmosKernel1.Kernel k)
        {
            string[] arg = line.Split(' ');
            string[] targ = line.Split('\"');
            if (arg[0] == "newfile" || arg[0] == "new")
            {
                if (arg[1] == "<arg>")
                {
                    k.fs.CreateFile(parameter);
                }
                else
                    try { k.fs.CreateFile(targ[1]); } catch { }
            }
            if (arg[0] == "newdir")
            {
                if (arg[1] == "<arg>")
                {
                    k.fs.CreateDirectory(parameter);
                }
                else
                    try { k.fs.CreateDirectory(targ[1]); } catch { }
            }
            else if (arg[0] == "delfile" || arg[0] == "del")
            {
                if (arg[1] == "<arg>")
                {
                    k.fs.DeleteFile(k.fs.GetFile(parameter));
                }
                else
                    try { k.fs.DeleteFile(k.fs.GetFile(targ[1])); } catch { }
            }
            else if (arg[0] == "deldir")
            {
                if (arg[1] == "<arg>")
                {
                    k.fs.DeleteDirectory(k.fs.GetDirectory(parameter));
                }
                else
                    try { k.fs.DeleteDirectory(k.fs.GetDirectory(targ[1])); } catch { }
            }
        }
    }
}
