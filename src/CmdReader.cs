using System;
using System.Collections.Generic;
using System.Text;

namespace ToRun_OS
{
    public class CmdReader
    {
        public string CurrentDirectory = @"0:\";
        public void ReadCommand(CosmosKernel1.Kernel k,string line)
        {
            line = line.ToLower();
            string[] arg = line.Split(' ');
            if (line.Contains("shutdown -s -t") || line.Contains("shutdown /s /t"))
            {
                Cosmos.HAL.Global.PIT.Wait((uint)Convert.ToInt32(arg[3]));
            }
            else if (line == "shutdown -a" || line == "shutdown /a")
                Cosmos.System.Power.Shutdown();
            else if (arg[0] == "echo")
                Console.WriteLine(arg[1]);
            else if (arg[0] == "ver")
                Console.WriteLine("ToRun OS");
            else if (arg[0] == "md" || arg[0] == "mkdir")
            {
                k.fs.CreateDirectory(CurrentDirectory + arg[1]);
            }
            else if (arg[0] == "copy" || arg[0] == "copy")
            {
                if (arg[1] == "con")
                    k.fs.CreateFile(CurrentDirectory + arg[2]);
            }
            else if (arg[0] == "cd")
            {
                CurrentDirectory = k.fs.GetDirectory(CurrentDirectory + arg[1]).mName;
            }
        }
    }
}
