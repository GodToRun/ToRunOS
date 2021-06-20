//import namespaces
using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using Sys = Cosmos.System;
using Cosmos.System.Graphics.Fonts;
using Cosmos.System.Graphics;
using System.Drawing;
using Cosmos.Core.IOGroup;
using ToRun_OS;
namespace CosmosKernel1
{
    public class Kernel : Sys.Kernel
    {


        public static Mouse m = new Mouse();
        Canvas canvas;
        public static int what = 0;
        public static string input;
        public static string EnvPath = @"0:\";
        string content = "";
        public static bool godtorun = false;
        public static bool adstrator = false;
        bool isMenu = false;
        Sys.FileSystem.Listing.DirectoryEntry hal;
        Sys.FileSystem.Listing.DirectoryEntry pal;
        bool booted = true;
        public bool setup;
        bool setting1 = false;
        static Theme CurrentTheme = Theme.Default;
        GUIContext n;
        GUIContext f;
        GUIContext control;
        public CosmosVFS fs = new CosmosVFS();
        protected override void BeforeRun() //booted
        {
            VFSManager.RegisterVFS(fs);
            //Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            try
            {
                fs.CreateFile(@"0:\userpass.txt");
                fs.CreateFile(@"0:\userid.txt");
                hal = fs.GetFile(@"0:\userid.txt");
                pal = fs.GetFile(@"0:\userpass.txt");
                var hello_file = fs.GetFile(@"0:\userid.txt");
                var hello_file_stream = hello_file.GetFileStream();
                if (hello_file_stream.CanRead)
                {
                    byte[] text_to_read = new byte[hello_file_stream.Length];
                    hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                    var value = Encoding.Default.GetString(text_to_read);

                    if (value == "")
                    {
                        setup = true;
                        start();
                            /*Console.ForegroundColor = ConsoleColor.DarkRed;
                            printf(@"
                                                                                
                                                                               
__________   ____   ________  ____     _____      ___         ____      ____   
MMMMMMMMMM  6MMMMb  `MMMMMMMb.`MM'     `M`MM\     `M'        6MMMMb    6MMMMb\ 
/   MM   \ 8P    Y8  MM    `Mb MM       M MMM\     M        8P    Y8  6M'    ` 
    MM    6M      Mb MM     MM MM       M M\MM\    M       6M      Mb MM       
    MM    MM      MM MM     MM MM       M M \MM\   M       MM      MM YM.      
    MM    MM      MM MM    .M9 MM       M M  \MM\  M       MM      MM  YMMMMb  
    MM    MM      MM MMMMMMM9' MM       M M   \MM\ M       MM      MM      `Mb 
    MM    MM      MM MM  \M\   MM       M M    \MM\M       MM      MM       MM 
    MM    YM      M9 MM   \M\  YM       M M     \MMM       YM      M9       MM 
    MM     8b    d8  MM    \M\  8b     d8 M      \MM        8b    d8  L    ,M9 
   _MM_     YMMMM9  _MM_    \M\_ YMMMMM9 _M_      \M         YMMMM9   MYMMMM9  
                                                                               
                                                                               
                                                                               ");
                            Console.BackgroundColor = ConsoleColor.Black;*/
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Made By RunToRun. RunToRun All Rights Reserved.\n          Version 2.0.0          ");
                            Console.ForegroundColor = ConsoleColor.White;

                        

                    }
                    else
                    {
                        var hello_fileaa = fs.GetFile(@"0:\logaccount.hdn");
                        var hello_file_streamaa = hello_fileaa.GetFileStream();

                        if (hello_file_streamaa.CanRead)
                        {
                            byte[] text_to_readaa = new byte[hello_file_streamaa.Length];
                            hello_file_streamaa.Read(text_to_readaa, 0, (int)hello_file_streamaa.Length);
                            var value222 = Encoding.Default.GetString(text_to_readaa);
                            if (value222 == "true")
                            {
                                //ToLogin();
                            }
                            //Console.WriteLine("");
                            //Console.ForegroundColor = ConsoleColor.DarkRed;
                            //printf("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                            /*printf(@"
                                                                                
                                                                               
__________   ____   ________  ____     _____      ___         ____      ____   
MMMMMMMMMM  6MMMMb  `MMMMMMMb.`MM'     `M`MM\     `M'        6MMMMb    6MMMMb\ 
/   MM   \ 8P    Y8  MM    `Mb MM       M MMM\     M        8P    Y8  6M'    ` 
    MM    6M      Mb MM     MM MM       M M\MM\    M       6M      Mb MM       
    MM    MM      MM MM     MM MM       M M \MM\   M       MM      MM YM.      
    MM    MM      MM MM    .M9 MM       M M  \MM\  M       MM      MM  YMMMMb  
    MM    MM      MM MMMMMMM9' MM       M M   \MM\ M       MM      MM      `Mb 
    MM    MM      MM MM  \M\   MM       M M    \MM\M       MM      MM       MM 
    MM    YM      M9 MM   \M\  YM       M M     \MMM       YM      M9       MM 
    MM     8b    d8  MM    \M\  8b     d8 M      \MM        8b    d8  L    ,M9 
   _MM_     YMMMM9  _MM_    \M\_ YMMMMM9 _M_      \M         YMMMM9   MYMMMM9  
                                                                               
                                                                               
                                                                               ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            */
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Made By RunToRun. RunToRun All Rights Reserved.\n          Version 2.0.0          ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }



                    }
                }
            }
            catch (Exception error)
            {
                printf(error.ToString());

            }


        }

        void WriteFile(Sys.FileSystem.Listing.DirectoryEntry f,string msg)
        {
            var FILE_STREAM = f.GetFileStream();
            if (FILE_STREAM.CanWrite)
            {
                byte[] text_to_writed = Encoding.ASCII.GetBytes(msg);
                FILE_STREAM.Write(text_to_writed, 0, text_to_writed.Length);
            }
        }
        protected override void Run() //running (infinite loop)
        {

            try
            {
                //system input
                if (booted) // autoexec.cmd
                    input = /*Console.ReadLine();*/ "os";
                else
                {
                    Console.Write(@"0>");
                    input = Console.ReadLine();
                }
                booted = false;
                List<string> files = new List<string>(5);
                if (input == "about")
                {
                    Console.WriteLine("     ToRunOS     \nOS name: ToRunOS\nVersion: 2.0.0\nUsing FAT File System.\nThanks for Using!");
                }
                else if (input == "game")
                {
                    game();
                }
                else if (input == "color a")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (input == "color b")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (input == "color d")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (input == "color f")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (input == "color c")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (input == "color e")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (input == "shutdown")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("shutdown all process...");
                    Console.WriteLine("Saving All Files...");
                    printf("Debuging...");
                    Console.WriteLine("Shutting down...");
                    Sys.Power.Shutdown();
                }
                else if (input == "exit")
                {
                    Sys.Power.Shutdown();
                }
                else if (input == "reboot")
                {
                    Console.WriteLine("Rebooting...");
                    Sys.Power.Reboot();
                }
                else if (input == "logoff" || input == "log off" || input == "logout" || input == "log out")
                {
                    ToLogin();
                }
                else if (input == "help")
                {
                    Console.WriteLine("- about  about ToRun OS\n- shutdown  shutting down computer.\n- reboot  rebooting computer.\n- help  view help.\n- newfile  create new file.\n- newdir create new directory \n- dir <directory>  view directory in files.\n- rd  delete directory.\n- system  open system manager \n- write  write .txt file.\n- open  open file.\n- os  open GUI root\n- ctrlpanel  open Control Panel.\n- rn  rename file.\n- print \"<msg>\"  print message.\n- delete  delete file file.\n- os.option  open os option\n- logout  log out your account.");
                }
                else if (input == "cmd")
                {
                    printf("--All .cmd commands\nBackgroundColor = <ColorName>\ndel <filename>\nnewfile <filename>\nprint \"<msg>\"");
                }
                else if (input == "Kernel")
                {

                }
                else if (input == "consolegui")
                {
                    consolegui();
                }
                else if (input == "newdir")
                {
                    Console.Write("file name: ");
                    var name = Console.ReadLine();
                    fs.CreateDirectory(EnvPath + name);
                }
                else if (input.Contains("newdir "))
                {
                    var name2 = input.Split(' ');
                    var name = name2[1];
                    fs.CreateDirectory(EnvPath + name);
                }
                else if (input == "rd")
                {
                    Console.Write("dir name: ");
                    var name = Console.ReadLine();
                    var d = fs.GetDirectory(EnvPath + name);
                    fs.DeleteDirectory(d);
                }
                else if (input.Contains("rd "))
                {
                    var name2 = input.Split(' ');
                    var name = name2[1];
                    var d = fs.GetDirectory(EnvPath + name);
                    fs.DeleteDirectory(d);
                }
                else if (input == "<3")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    printf(@"
   d88P  .d8888b.  
  d88P  d88P  Y88b 
 d88P        .d88P 
d88P        8888'
Y88b         'Y8b. 
 Y88b   888    888
  Y88b  Y88b  d88P
   Y88b  'Y8888P'
                   ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (input.Contains("loop all"))
                {
                    var subal = input.Split(' ');
                    while (true)
                    {
                        printf(subal[2]);
                    }
                }
                else if (input == ",")
                {
                    printf("ToRunOS don't support multi tasking.");
                }
                else if (input == "newfile")
                {
                    Console.Write("file name: ");
                    var file_name = Console.ReadLine();
                    try
                    {
                        fs.CreateFile(EnvPath + file_name);


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    Console.WriteLine($"created file '{file_name}'.");
                }
                else if (input.Contains("newfile "))
                {
                    var filenme = input.Split(' ');
                    var file_name = filenme[1];
                    try
                    {
                        fs.CreateFile(EnvPath + file_name);


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    Console.WriteLine($"created file '{file_name}'.");
                }
                else if (input == @"delete 0:\")
                {
                    if (adstrator == false)
                    {
                        Console.Write(@"Are You Sure? (Y\N)");
                        var real = Console.ReadLine();
                        if (real == "Y")
                        {
                            var directory_list = fs.GetDirectoryListing("0:/");
                            long available_space = fs.GetAvailableFreeSpace("0:/");
                            Console.WriteLine("Available Free Space: " + available_space + "byte");
                            foreach (var directoryEntry in directory_list)
                            {
                                Console.WriteLine("Deleted " + directoryEntry.mName);
                                fs.DeleteFile(directoryEntry);
                            }
                            Console.WriteLine("Deleted all files.");
                        }
                        else if (real == "y")
                        {
                            var directory_list = fs.GetDirectoryListing("0:/");
                            long available_space = fs.GetAvailableFreeSpace("0:/");
                            Console.WriteLine("Available Free Space: " + available_space + "byte");
                            foreach (var directoryEntry in directory_list)
                            {
                                Console.WriteLine("Deleted " + directoryEntry.mName);
                                fs.DeleteFile(directoryEntry);
                            }

                            Console.WriteLine("Deleted all files.");
                        }

                    }
                    else if (adstrator == true)
                    {
                        var directory_list = fs.GetDirectoryListing("0:/");
                        long available_space = fs.GetAvailableFreeSpace("0:/");
                        Console.WriteLine("Available Free Space: " + available_space + "byte");
                        foreach (var directoryEntry in directory_list)
                        {
                            Console.WriteLine("Deleted " + directoryEntry.mName);
                            fs.DeleteFile(directoryEntry);
                        }

                        Console.WriteLine("Deleted all files.");
                    }

                }
                else if (input == "st /f")
                {
                    Sys.Power.Shutdown();
                }
                else if (input == "/0" || input == "/0:")
                {
                    printf("System Disk (FAT32) 0:\\ type 'delete 0:\\' to delete all files.");
                }
                else if (input.Contains("calc "))
                {
                    var asas = input.Split(' ');
                    string v0 = asas[1];
                    string v1 = asas[3];
                    if (asas[2] == "+")
                    {
                        Console.WriteLine(Convert.ToInt32(v0) + Convert.ToInt32(v1));
                    }
                    else if (asas[2] == "-")
                    {
                        Console.WriteLine(Convert.ToInt32(v0) - Convert.ToInt32(v1));
                    }
                    else if (asas[2] == "*")
                    {
                        Console.WriteLine(Convert.ToInt32(v0) * Convert.ToInt32(v1));
                    }
                    else if (asas[2] == "/")
                    {
                        Console.WriteLine(Convert.ToInt32(v0) / Convert.ToInt32(v1));
                    }
                    else if (asas[2] == "%")
                    {
                        Console.WriteLine(Convert.ToInt32(v0) % Convert.ToInt32(v1));
                    }
                }
                else if (input == "calc")
                {
                    Console.Write(">>>");
                    var input2 = Console.ReadLine();
                    var asas = input2.Split(' ');
                    string v0 = asas[0];
                    string v1 = asas[2];
                    if (asas[1] == "+")
                    {
                        Console.WriteLine(Convert.ToInt32(v0) + Convert.ToInt32(v1));
                    }
                    else if (asas[1] == "-")
                    {
                        Console.WriteLine(Convert.ToInt32(v0) - Convert.ToInt32(v1));
                    }
                    else if (asas[1] == "*")
                    {
                        Console.WriteLine(Convert.ToInt32(v0) * Convert.ToInt32(v1));
                    }
                    else if (asas[1] == "/")
                    {
                        Console.WriteLine(Convert.ToInt32(v0) / Convert.ToInt32(v1));
                    }
                    else if (asas[1] == "%")
                    {
                        Console.WriteLine(Convert.ToInt32(v0) % Convert.ToInt32(v1));
                    }
                }
                else if (input == "copyright")
                {
                    Console.WriteLine("RunToRun All Rights Reserved.");
                }
                else if (input == "protect" || input == "pt")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    printf("\n\n\n\n\n\n\n\n\n\n\n                       now Your computer is Protect mode.                                  ");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();

                }
                else if (input == "write")
                {
                    Console.Write("file name: ");
                    var write_name = Console.ReadLine();
                    if (write_name.Contains(".txt") || write_name.Contains(".wrt") || write_name.Contains(".cmd"))
                    {
                        Console.Write(">>>");
                        var texts = Console.ReadLine();
                        try
                        {
                            var hello_file = fs.GetFile(EnvPath + write_name);
                            var hello_file_stream = hello_file.GetFileStream();

                            if (hello_file_stream.CanWrite)
                            {
                                byte[] text_to_write = Encoding.ASCII.GetBytes(texts);
                                hello_file_stream.Write(text_to_write, 0, text_to_write.Length);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("this file is not .txt or .wrt or .cmd file.");
                    }

                }
                else if (input.Contains("write "))
                {
                    var write_name_ = input.Split(' ');
                    var write_name = write_name_[1];
                    if (write_name.Contains(".txt") || write_name.Contains(".wrt") || write_name.Contains(".cmd"))
                    {
                        Console.Write(">>>");
                        var texts = Console.ReadLine();
                        try
                        {
                            var hello_file = fs.GetFile(EnvPath + write_name);
                            var hello_file_stream = hello_file.GetFileStream();

                            if (hello_file_stream.CanWrite)
                            {
                                byte[] text_to_write = Encoding.ASCII.GetBytes(texts);
                                hello_file_stream.Write(text_to_write, 0, text_to_write.Length);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("this file is not .txt or .wrt or .cmd file.");
                    }

                }

                else if (input == "open")
                {
                    Console.Write("file name: ");
                    var location = Console.ReadLine();
                    if (location.Contains(".cmd"))
                    {
                        try
                        {
                            var hello_file = fs.GetFile(EnvPath + location);
                            var hello_file_stream = hello_file.GetFileStream();

                            if (hello_file_stream.CanRead)
                            {
                                byte[] text_to_read = new byte[hello_file_stream.Length];
                                hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                                var value = Encoding.Default.GetString(text_to_read);
                                if (value == "BackgroundColor = Blue")
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.Clear();
                                }
                                else if (value == "BackgroundColor = White")
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.Clear();
                                }
                                else if (value == "BackgroundColor = Black")
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                }
                                else if (value == "BackgroundColor = Red")
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                }
                                else if (value == "BackgroundColor = Yellow")
                                {
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.Clear();
                                }
                                else if (value == "BackgroundColor = Green")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.Clear();
                                }
                                else if (value.Contains("print"))
                                {
                                    var d = value.Split('"');
                                    printf(d[1]);
                                }
                                else if (value.Contains("del"))
                                {
                                    var d = value.Split(' ');
                                    var ss = fs.GetFile($"0:\\{d[1]}");
                                    fs.DeleteFile(ss);
                                    printf("Deleted " + ss + ".");
                                }
                                else if (value.Contains("newfile"))
                                {
                                    var d = value.Split(' ');
                                    fs.CreateFile($"0:\\{d[1]}");
                                    printf("Downloaded " + d[1] + ".");
                                }
                                else if (value == "shutdown")
                                {
                                    Sys.Power.Shutdown();
                                }
                                else if (value == "logout")
                                {
                                    ToLogin();
                                }
                                else if (value.Contains("sys."))
                                {
                                    if (value.Contains("sys.rn"))
                                    {
                                        var dozzin = value.Split(' ');
                                        var file = fs.GetFile(dozzin[1]);
                                        file.SetName(dozzin[2]);
                                    }
                                    else
                                    {
                                        printf("unknown system command.");
                                    }
                                }
                                else if (value == "format")
                                {
                                    fs.Format(EnvPath, EnvPath, true);
                                    printf("successfully formated.");
                                }
                                else if (value == "reboot")
                                {
                                    Sys.Power.Reboot();
                                }
                                else
                                {
                                    printf("Faild To Open file.");
                                }
                            }
                        }
                        catch (OutOfMemoryException out_of_memory)
                        {
                            printf($"{out_of_memory}");
                        }
                        catch (Exception e)
                        {
                            bluescreen($"{e}");
                        }
                    }
                    else
                    {
                        try
                        {
                            var hello_file = fs.GetFile(EnvPath + location);
                            var hello_file_stream = hello_file.GetFileStream();

                            if (hello_file_stream.CanRead)
                            {
                                byte[] text_to_read = new byte[hello_file_stream.Length];
                                hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                                Console.WriteLine(Encoding.Default.GetString(text_to_read));
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }

                }
                else if (input.Contains("open "))
                {
                    var location2 = input.Split(' ');
                    var location = location2[1];
                    if (location.Contains(".cmd"))
                    {
                        try
                        {
                            var hello_file = fs.GetFile(EnvPath + location);
                            var hello_file_stream = hello_file.GetFileStream();

                            if (hello_file_stream.CanRead)
                            {
                                byte[] text_to_read = new byte[hello_file_stream.Length];
                                hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                                var value = Encoding.Default.GetString(text_to_read);
                                if (value == "BackgroundColor = Blue")
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.Clear();
                                }
                                else if (value == "BackgroundColor = White")
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.Clear();
                                }
                                else if (value == "BackgroundColor = Black")
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                }
                                else if (value == "BackgroundColor = Red")
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                }
                                else if (value == "BackgroundColor = Yellow")
                                {
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.Clear();
                                }
                                else if (value == "BackgroundColor = Green")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.Clear();
                                }
                                else if (value.Contains("print"))
                                {
                                    var d = value.Split('"');
                                    printf(d[1]);
                                }
                                else if (value.Contains("del"))
                                {
                                    var d = value.Split(' ');
                                    var ss = fs.GetFile($"0:\\{d[1]}");
                                    fs.DeleteFile(ss);
                                    printf("Deleted " + ss + ".");
                                }
                                else if (value.Contains("newfile"))
                                {
                                    var d = value.Split(' ');
                                    fs.CreateFile($"0:\\{d[1]}");
                                    printf("Downloaded " + d[1] + ".");
                                }
                                else if (value == "shutdown")
                                {
                                    Sys.Power.Shutdown();
                                }
                                else if (value == "logout")
                                {
                                    ToLogin();
                                }
                                else if (value.Contains("sys."))
                                {
                                    if (value.Contains("sys.rn"))
                                    {
                                        var dozzin = value.Split(' ');
                                        var file = fs.GetFile(dozzin[1]);
                                        file.SetName(dozzin[2]);
                                    }
                                    else
                                    {
                                        printf("unknown system command.");
                                    }
                                }
                                else if (value == "format")
                                {
                                    fs.Format(EnvPath, EnvPath, true);
                                    printf("successfully formated.");
                                }
                                else if (value == "reboot")
                                {
                                    Sys.Power.Reboot();
                                }
                                else
                                {
                                    printf("Faild To Open file.");
                                }
                            }
                        }
                        catch (OutOfMemoryException out_of_memory)
                        {
                            printf($"{out_of_memory}");
                        }
                        catch (Exception e)
                        {
                            bluescreen($"{e}");
                        }
                    }
                    else
                    {
                        try
                        {
                            var hello_file = fs.GetFile(EnvPath + location);
                            var hello_file_stream = hello_file.GetFileStream();

                            if (hello_file_stream.CanRead)
                            {
                                byte[] text_to_read = new byte[hello_file_stream.Length];
                                hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                                Console.WriteLine(Encoding.Default.GetString(text_to_read));
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }

                }
                else if (input == "disk")
                {
                    printf("Disk Type: 0:\nFileSystem Type: FAT32");
                    long available_space = fs.GetAvailableFreeSpace("0:/");
                    Console.WriteLine("Available Free Space: " + available_space + "byte");
                    long free_space = fs.GetTotalSize("0:/") / 1000;
                    long all_space = fs.GetTotalSize("0:/");
                    Console.WriteLine($"Disk Size: {free_space}KB");

                }
                else if (input == "")
                {

                }
                else if (input == "ctrlpanel")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    printf("\n\n\n\n\n     Control Panel     ");
                    Console.ForegroundColor = ConsoleColor.White;
                    printf("\n1: System and Process");
                    printf("\n2: Exit");
                    var num = Console.ReadKey();


                    if (num.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        sysprocess();

                    }
                    else if (num.Key == ConsoleKey.D2)
                    {
                        printf("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                        Console.Clear();

                    }
                    else
                    {
                        printf("invaild selection.");
                        return;
                    }


                }
                else if (input == "setting" || input == "settings")
                {
                    printf("1. show icon on viewing file. (1.off / 1.on)");
                    Console.Write(": ");
                    var yy = Console.ReadLine();
                    if (yy == "1.on")
                    {
                        setting1 = true;
                    }
                    else if (yy == "1.off")
                    {
                        setting1 = false;
                    }
                    else
                    {
                        printf("invaild selection.");
                    }
                }
                else if (input == "testd")
                {
                    var directory_list = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(EnvPath);
                    foreach (var directoryEntry in directory_list)
                    {
                        Console.WriteLine(directoryEntry.mName);
                    }
                }
                else if (input.Contains("dir "))
                {
                    var sip = input.Split(' ');
                    var directory_list = fs.GetDirectoryListing($"0:\\{sip[1]}");
                    long available_space = fs.GetAvailableFreeSpace($"0:\\{sip[1]}");
                    printf("---------------------");
                    foreach (var directoryEntry in directory_list)
                    {
                        if (directoryEntry.mName.Contains(".cmd") && setting1 == true)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.WriteLine("         ");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("         \n         \n         ");

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("         ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (directoryEntry.mName.Contains(".txt") || directoryEntry.mName.Contains(".wrt"))
                        {
                            if (setting1 == true)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine("     \n     \n     \n     ");

                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(directoryEntry.mName);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("         ");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(directoryEntry.mName);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    printf("---------------------");
                }
                else if (input == "dir") //than have error. i'll catch this anytime
                {
                    var directory_list = fs.GetDirectoryListing(EnvPath);
                    long available_space = fs.GetAvailableFreeSpace(EnvPath);
                    printf("---------------------");
                    foreach (var directoryEntry in directory_list)
                    {
                        if (directoryEntry.mName.Contains(".cmd") && setting1 == true)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.WriteLine("         ");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("         \n         \n         ");

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("         ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (directoryEntry.mName.Contains(".txt") || directoryEntry.mName.Contains(".wrt"))
                        {
                            if (setting1 == true)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine("     \n     \n     \n     ");

                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(directoryEntry.mName);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("         ");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(directoryEntry.mName);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    printf("---------------------");
                }
                else if (input == "os.option") //than have error. i'll catch this anytime
                {
                    system_manager();
                }
                else if (input.Contains("print"))
                {
                    var subal = input.Split('"');
                    printf(subal[1]);
                }
                else if (input == "system") //system gui
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;

                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("               \nStarting System... Please wait.\n               ");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("                         \n                         \n                         \n                         \n   Welcome To ToRunOS!   \n                         \n                         \n                         \n                         \n");
                    Console.ReadLine();

                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("                         \n                         \n                         \n                         \n   It's SystemManager.   \n                         \n                         \n                         \n                         \n");
                    Console.ReadLine();

                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("                         \n                         \n                         \n                         \n   very easy to using.   \n                         \n                         \n                         \n                         \n");
                    Console.ReadLine();

                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("                         \n                         \n                         \n                         \n    press enter to on.   \n                         \n                         \n                         \n                         \n");

                    Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    while (true)
                    {
                        Console.WriteLine("4: explorer\n5: Notepad\n6: Back To Terminal\n7: Rebooting\n8: Shutting down");
                        var selected = Console.ReadKey();
                        if (selected.Key == ConsoleKey.D8)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                            Console.WriteLine("                         \n                         \n                         \n     Are You Sure To     \n      Shutting down      \n                         \n                         \n                         \n                         \n");
                            Console.ReadLine();
                            Sys.Power.Shutdown();
                        }
                        else if (selected.Key == ConsoleKey.D7)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                            Console.WriteLine("                         \n                         \n                         \n     Are You Sure To     \n        Rebooting?       \n                         \n                         \n                         \n                         \n");
                            Console.ReadLine();
                            Sys.Power.Reboot();
                        }
                        else if (selected.Key == ConsoleKey.D6)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                            Console.WriteLine("                         \n                         \n                         \n      are you sure       \n    Back To Terminal?    \n                         \n                         \n                         \n                         \n");
                            Console.ReadLine();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();

                            return;

                        }
                        else if (selected.Key == ConsoleKey.D5)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                            Console.WriteLine("                         \n                         \n                         \n     Are You Sure To     \n      Open Notepad?      \n                         \n                         \n                         \n                         \n");
                            Console.ReadLine();
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                            bool dalla = false;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("[type 'notepad.quit' to exit notepad.]");
                            Console.WriteLine("[type 'notepad.save' to save file.]");
                            var zatx = "";
                            var realvalue = "";
                            while (dalla == false)
                            {
                                var value = Console.ReadLine();
                                if (value == "notepad.quit")
                                {
                                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                                    dalla = true;
                                    break;
                                }
                                else if (value == "notepad.save")
                                {
                                    Console.Write(">>>");
                                    var filename = Console.ReadLine();
                                    try
                                    {
                                        var hello_file = fs.GetFile(EnvPath + filename);
                                        var hello_file_stream = hello_file.GetFileStream();

                                        if (hello_file_stream.CanWrite)
                                        {
                                            byte[] text_to_write = Encoding.ASCII.GetBytes(realvalue);
                                            hello_file_stream.Write(text_to_write, 0, text_to_write.Length);
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                }
                                else
                                {
                                    zatx = Console.ReadLine();
                                    realvalue = realvalue + $"\n{zatx}" + value;
                                }
                            }


                        }
                        else if (selected.Key == ConsoleKey.D4)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                            Console.WriteLine("                         \n                         \n                         \n       are you sure      \n      open explorer?     \n                         \n                         \n                         \n                         \n");
                            Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            var directory_list = fs.GetDirectoryListing("0:/");
                            long available_space = fs.GetAvailableFreeSpace("0:/");
                            Console.WriteLine("Available Free Space: " + available_space + "bytes");
                            foreach (var directoryEntry in directory_list)
                            {
                                Console.WriteLine(directoryEntry.mName);
                            }
                            Console.Write("Open:");
                            var a = Console.ReadLine();
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                            try
                            {
                                var hello_file = fs.GetFile(EnvPath + a);
                                var hello_file_stream = hello_file.GetFileStream();

                                if (hello_file_stream.CanRead)
                                {
                                    byte[] text_to_read = new byte[hello_file_stream.Length];
                                    hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                                    Console.WriteLine(Encoding.Default.GetString(text_to_read));
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                            Console.ReadLine();
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                            Console.WriteLine("                         \n                         \n                         \n     Invaild    \n       Selection!       \n                         \n                         \n                         \n                         \n");
                        }
                    }
                }
                else if (input == "systeminfo")
                {
                    Console.WriteLine("OS: ToRunOS\ndisk type: fat32, 0:/");
                }
                else if (input == "info")
                {
                    Console.WriteLine("OS: ToRunOS\ndisk type: fat32, 0:/");
                }
                else if (input == "ver" || input == "version" || input == "Ver" || input == "Version")
                {
                    printf("ToRunOS [Version 2.0.0]");
                }
                else if (input == "clear")
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                }
                else if (input == "format" || input == "Format")
                {
                    Console.Write("Are You Sure? (Y/N)>");
                    var real = Console.ReadLine();
                    if (real == "Y" || real == "y")
                    {
                        fs.Format(EnvPath, EnvPath, true);
                        Sys.Power.Reboot();
                    }
                }
                else if (input == "boot")
                {
                    boot();
                }
                else if (input == "delete" || input == "Del" || input == "del" || input == "Delete")
                {
                    try
                    {
                        Console.Write("file name: ");
                        var file_name = Console.ReadLine();
                        var ss = fs.GetFile(EnvPath + file_name);
                        fs.DeleteFile(ss);
                        Console.WriteLine("Deleted " + file_name + ".");
                    }
                    catch (Exception error_)
                    {
                        printf($"{error_}");
                    }

                }
                else if (input.Contains("del ") || input.Contains("delete "))
                {
                    try
                    {
                        var filename = input.Split(' ');
                        var file_name = filename[1];
                        var ss = fs.GetFile(EnvPath + file_name);
                        fs.DeleteFile(ss);
                        Console.WriteLine("Deleted " + file_name + ".");
                    }
                    catch (Exception error_)
                    {
                        printf($"{error_}");
                    }

                }
                else if (input == "rename" || input == "rn")
                {
                    try
                    {
                        Console.Write("file name: ");
                        var file_name = Console.ReadLine();
                        Console.Write(">>>");
                        var name = Console.ReadLine();
                        var ss = fs.GetFile(EnvPath + file_name);
                        ss.SetName(name);
                        Console.WriteLine("Renamed to " + name + ".");
                    }
                    catch (Exception an)
                    {
                        printf($"{an}");
                    }

                }
                else if (input.Contains("rn ") || input.Contains("rename "))
                {
                    try
                    {
                        var filename = input.Split(' ');
                        var file_name = filename[1];
                        Console.Write(">>>");
                        var name = Console.ReadLine();
                        var ss = fs.GetFile(EnvPath + file_name);
                        ss.SetName(name);
                        Console.WriteLine("Renamed to " + name + ".");
                    }
                    catch (Exception an)
                    {
                        printf($"{an}");
                    }

                }
                else if (input == "os")
                {
                    godtorun = false;
                    while (godtorun == false)
                    {
                        start();
                    }

                }
                else //catch unknown command error
                {
                    Console.WriteLine("Unknown command. type 'help' to view commands.");

                }
            }
            catch (Exception err)
            {
                bluescreen($"{err}");
            }
        }
        void sysprocess()
        {

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                printf("\n\n     System and Process     ");
                Console.ForegroundColor = ConsoleColor.White;
                printf("\n1: Process manager");
                printf("\n2: Exit");
                var num = Console.ReadKey();
                if (num.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    var directory_list = fs.GetDirectoryListing("0:/");
                    long available_space = fs.GetAvailableFreeSpace("0:/");
                    foreach (var directoryEntry in directory_list)
                    {
                        if (directoryEntry.mName.Contains(".cmd") && setting1 == true)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.WriteLine("         ");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("         \n         \n         ");

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("         ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (directoryEntry.mName.Contains(".txt") || directoryEntry.mName.Contains(".wrt"))
                        {
                            if (setting1 == true)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine("     \n     \n     \n     ");

                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(directoryEntry.mName);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("         ");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(directoryEntry.mName);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                if (num.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    break;

                }

            }
        }
        void system_manager()
        {
            bool exit = false;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            while (exit == false)
            {
                Console.WriteLine("User Option\n1:Shutdown\n2:Rebooting\n3:OS recovery\n4:delete all files\n5:Exit User Option");
                var hisekky = Console.ReadLine();
                if (hisekky == "1")
                {
                    Sys.Power.Shutdown();
                }
                else if (hisekky == "2")
                {
                    Sys.Power.Reboot();
                }
                else if (hisekky == "3")
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("if your computer is destroyed,\nyou may need format.\nwe can't support you. sorry.\nbut we know how to format.\nUser Option -> delete all files.\nand re-install ToRunOS");
                    Console.ReadLine();
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    exit = true;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    return;
                }
                else if (hisekky == "4")
                {
                    Console.Write(@"Are You Sure? (Y\N)");
                    var real = Console.ReadLine();
                    if (real == "Y")
                    {
                        var directory_list = fs.GetDirectoryListing("0:/");
                        long available_space = fs.GetAvailableFreeSpace("0:/");
                        Console.WriteLine("Available Free Space: " + available_space + "byte");
                        foreach (var directoryEntry in directory_list)
                        {
                            Console.WriteLine("Deleted " + directoryEntry.mName);
                            fs.DeleteFile(directoryEntry);
                        }
                        Console.WriteLine("Deleted all files.");
                    }
                    else if (real == "y")
                    {
                        var directory_list = fs.GetDirectoryListing("0:/");
                        long available_space = fs.GetAvailableFreeSpace("0:/");
                        Console.WriteLine("Available Free Space: " + available_space + "byte");
                        foreach (var directoryEntry in directory_list)
                        {
                            Console.WriteLine("Deleted " + directoryEntry.mName);
                            fs.DeleteFile(directoryEntry);
                        }

                        Console.WriteLine("Deleted all files.");
                    }
                }
                else if (hisekky == "5")
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    exit = true;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    return;

                }
            }
        }
        void start()
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Pen pen = new Pen(Color.White);
            string notepad_value = "";
            GUIContext paint = new GUIContext("Paint",this);
            WarnMessageBox warn = new WarnMessageBox(canvas, pen, "Warning", $"Your Memory is to Large.",this);
            canvas.Clear(Color.Blue);
            if (!setup)
            {
                n = new GUIContext("Notepad", this);
                f = new GUIContext("File explorer", this);
                control = new GUIContext("Control Panel", this);
                if (Read(fs.GetFile(@"0:\Settings\theme.bool")) == "true")
                    CurrentTheme = Theme.Default;
                else
                    CurrentTheme = Theme.Classic;
                EnvPath = Read(fs.GetFile(@"0:\Settings\env.txt"));
                canvas.DrawString("Version 2.0.0", PCScreenFont.Default, pen, 400, 300);
                canvas.DrawFilledCircle(pen, 450, 150, 80);
                pen.Color = Color.Blue;
                canvas.DrawString("ToRun OS ", PCScreenFont.Default, pen, 415, 145);
                Cosmos.HAL.Global.PIT.Wait(2000);
                //Sign Up
                SIGN:
                var hello_fileaa = fs.GetFile(@"0:\logaccount.hdn");
                var hello_file_streamaa = hello_fileaa.GetFileStream();

                if (hello_file_streamaa.CanRead)
                {
                    byte[] text_to_readaa = new byte[hello_file_streamaa.Length];
                    hello_file_streamaa.Read(text_to_readaa, 0, (int)hello_file_streamaa.Length);
                    var value222 = Encoding.Default.GetString(text_to_readaa);
                    if (value222 == "true")
                    {
                        GUIContext login = new GUIContext("Login",this);
                        string accname = "";
                        string accpass = "";
                        login.SetGUIContext(canvas);
                        pen.Color = Color.White;
                        canvas.DrawFilledRectangle(pen, 300, 100, 150, 50);
                        pen.Color = Color.Black;
                        canvas.DrawRectangle(pen, 300, 100, 150, 50);
                        pen.Color = Color.White;
                        canvas.DrawFilledRectangle(pen, 400, 100, 150, 50);
                        pen.Color = Color.Black;
                        canvas.DrawRectangle(pen, 400, 100, 150, 50);
                        canvas.DrawString("Name", PCScreenFont.Default, pen, 320, 120);
                        pen.Color = Color.White;
                        canvas.DrawFilledRectangle(pen, 300, 300, 150, 50);
                        pen.Color = Color.Black;
                        canvas.DrawRectangle(pen, 300, 300, 150, 50);
                        pen.Color = Color.White;
                        canvas.DrawFilledRectangle(pen, 400, 300, 150, 50);
                        pen.Color = Color.Black;
                        canvas.DrawRectangle(pen, 400, 300, 150, 50);
                        canvas.DrawString("Password", PCScreenFont.Default, pen, 320, 320);
                        MessageBox invaild = new MessageBox(canvas, pen, "Login Manager", "Invaild User Name!",this);
                        var hello_file_id = fs.GetFile(@"0:\userid.txt");
                        var hello_file_pass = fs.GetFile(@"0:\userpass.txt");
                        var hello_file_stream = hello_file_id.GetFileStream();
                        var pass_file_stream = hello_file_pass.GetFileStream();
                        string pass_ = "";
                        string id = "";
                        if (hello_file_stream.CanRead && pass_file_stream.CanRead)
                        {
                            byte[] text_to_read = new byte[hello_file_stream.Length];
                            hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                            id = Encoding.Default.GetString(text_to_read);
                            byte[] text_to_read2 = new byte[pass_file_stream.Length];
                            pass_file_stream.Read(text_to_read2, 0, (int)pass_file_stream.Length);
                            pass_ = Encoding.Default.GetString(text_to_read2);
                        }
                        while (true)
                        {
                            var CHAR = Sys.KeyboardManager.ReadKey();
                            if (CHAR.Key == Sys.ConsoleKeyEx.Enter)
                            {
                                if (accname == id)
                                {
                                    break;
                                }
                                else
                                {
                                    invaild.Draw();
                                    invaild.WaitForClick(canvas, pen, this);
                                    goto SIGN;
                                }
                            }
                            else
                            {
                                accname += CHAR.KeyChar;
                                canvas.DrawString(accname, PCScreenFont.Default, pen, 420, 120);
                            }
                        }
                        while (true)
                        {
                            var CHAR = Sys.KeyboardManager.ReadKey();
                            if (CHAR.Key == Sys.ConsoleKeyEx.Enter)
                            {
                                if (accpass == pass_)
                                {
                                    break;
                                }
                                else
                                {
                                    invaild.text = "Invaild Password!";
                                    invaild.Draw();
                                    invaild.WaitForClick(canvas, pen, this);
                                    goto SIGN;
                                }
                            }
                            else
                            {
                                accpass += CHAR.KeyChar;
                                canvas.DrawString(accpass, PCScreenFont.Default, pen, 420, 320);
                            } 
                        }
                        login.Close(this,canvas,pen);
                    }
                }
                goto DEFAULT;
            DEFAULT:
                //윈도우로 치면 부팅 하고 나온 바탕화면 그 콘텍스트.
                DrawGraphicFile(fs.GetFile(@"0:\Settings\Desktop.ges"),canvas,pen);
                if (Cosmos.Core.CPU.GetAmountOfRAM() > 3998)
                {
                    warn.text = "Your Memory is to Large.\nThe maximum memory is 4GB.";
                    warn.Draw();
                    warn.WaitForClick(canvas, pen, this);
                    Sys.Power.Shutdown();
                }
                if (Cosmos.Core.CPU.GetAmountOfRAM() < 62)
                {
                    warn.text = "Your Memory is to Small.\nMake it at least 64MB.";
                    warn.Draw();
                    warn.WaitForClick(canvas, pen, this);
                    Sys.Power.Shutdown();
                }
                string CurrentDirectory = EnvPath;
                try
                {
                    /*
                    pen.Color = Color.Gray;
                    canvas.DrawFilledRectangle(pen, 100, 365, 300, 35);
                    pen.Color = Color.White;
                    canvas.DrawFilledRectangle(pen, 100, 400, 300, 250);
                                                                     Window   */
                    DefaultDraw(canvas, pen);
                    while (true)
                    {
                        try
                        {
                            Button.Refresh();
                            pen.Color = Color.Black;
                            Sys.MouseManager.ScreenWidth = (uint)canvas.Mode.Columns;
                            Sys.MouseManager.ScreenHeight = (uint)canvas.Mode.Rows;
                            int X = (int)Sys.MouseManager.X;
                            int Y = (int)Sys.MouseManager.Y;
                            canvas.DrawLine(pen, X, Y, X + 5, Y);
                            canvas.DrawLine(pen, X, Y, X, Y - 5);
                            canvas.DrawLine(pen, X, Y, X + 5, Y - 5);
                            if (X > 25 && X < 100 && Y > 680 && Y < 730 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext)
                            {
                                isMenu = true;
                                pen.Color = CurrentTheme.MsgBoxUIColor;
                                canvas.DrawFilledRectangle(pen, 250, 300, 500, 50);
                                pen.Color = CurrentTheme.MsgBoxBGColor;
                                canvas.DrawFilledRectangle(pen, 250, 350, 500, 200);
                                pen.Color = Color.Red;
                                canvas.DrawFilledRectangle(pen, 300, 400, 100, 100);
                                pen.Color = Color.Lime;
                                canvas.DrawFilledRectangle(pen, 450, 400, 100, 100);
                                pen.Color = Color.Black;
                                canvas.DrawFilledRectangle(pen, 600, 400, 100, 100);
                                canvas.DrawRectangle(pen,250,300,500,50);
                                canvas.DrawRectangle(pen,250,350,500,200);
                                canvas.DrawRectangle(pen,300,400,100,100);
                                canvas.DrawRectangle(pen,450,400,100,100);
                                pen.Color = Color.LightGray;
                                canvas.DrawRectangle(pen,600,400,100,100);
                            }
                            else if (X > 550 && X < 700 && Y > 440 && Y < 550 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext && isMenu)
                            { //Menu
                                godtorun = true;
                                canvas.Disable();
                                break;
                            }
                            else if (X > 250 && X < 400 && Y > 440 && Y < 550 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext && isMenu)
                            { //Menu
                                Sys.Power.Shutdown();
                                break;
                            }
                            else if (X > 400 && X < 550 && Y > 440 && Y < 550 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext && isMenu)
                            { //Menu
                                Sys.Power.Reboot();
                                break;
                            }
                            else if (X > 145 && X < 190 && Y > 630 && Y < 800 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext)
                            {
                                godtorun = true;
                                canvas.Disable();
                                break;
                            }
                            else if (X > 780 && X < 890 && Y > 640 && Y < 790 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext)
                            {
                                control.SetGUIContext(canvas);
                            }
                            else if (X > 42 && X < 72 && Y > 6 && Y < 25 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext)
                            {
                                TextMessageBox tm = new TextMessageBox(canvas,pen,"Run","Insert and Press Enter.",this);
                                tm.Draw(this);
                                Excutable(fs.GetFile(EnvPath + tm.inputtext),canvas,pen);
                            }
                            else if (X > 110 && X < 180 && Y > 6 && Y < 25 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext)
                            {
                                TextMessageBox tm = new TextMessageBox(canvas, pen, "New", "Insert and Press Enter.\nCreate a directory if you want to put\n a backslash in the last letter.",this);
                                tm.Draw(this);
                                if (tm.inputtext[tm.inputtext.Length - 1] == '\\')
                                    fs.CreateDirectory(EnvPath + tm.inputtext);
                                else
                                    fs.CreateFile(EnvPath + tm.inputtext);
                            }
                            else if (X > 190 && X < 260 && Y > 6 && Y < 25 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext)
                            {
                                TextMessageBox tm = new TextMessageBox(canvas, pen, "Delete", "Insert and Press Enter To \nDelete File Or Directory.",this);
                                tm.Draw(this);
                                try { fs.DeleteFile(fs.GetFile(EnvPath + tm.inputtext)); } catch { fs.DeleteDirectory(fs.GetDirectory(EnvPath + tm.inputtext)); }
                            }
                            else if (X > 265 && X < 335 && Y > 640 && Y < 800 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext)
                            {
                                GUIContext g = new GUIContext("About",this);
                                g.SetGUIContext(canvas);
                                pen.Color = Color.Red;
                                canvas.DrawFilledCircle(pen, 400, 400, 100);
                                pen.Color = Color.White;
                                canvas.DrawString("ToRun OS", PCScreenFont.Default, pen, 380, 400);
                                pen.Color = Color.Black;
                                canvas.DrawString("Code Name Cosmos", PCScreenFont.Default, pen, 600, 500);
                                canvas.DrawString("Version 2.0.0", PCScreenFont.Default, pen, 600, 520);
                                canvas.DrawString("Thanks For Using ToRunOS! ", PCScreenFont.Default, pen, 600, 540);

                            }
                            else if (X > 390 && X < 460 && Y > 640 && Y < 800 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext)
                            {
                                paint.SetGUIContext(canvas);
                                pen.Color = Color.Black;
                                canvas.DrawString("Comming Soon!", PCScreenFont.Default, pen, 400, 400);
                            }
                            else if (X > 520 && X < 610 && Y > 640 && Y < 800 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext)
                            {
                                n.SetGUIContext(canvas);
                            }
                            else if (X > 650 && X < 760 && Y > 640 && Y < 800 && Sys.MouseManager.MouseState == Sys.MouseState.Left && !GUIContext.isInContext)
                            {
                                f.SetGUIContext(canvas);
                            }
                            else if (X > 950 && Y < 40 && Sys.MouseManager.MouseState == Sys.MouseState.Left && GUIContext.isInContext)
                            {
                                GUIContext.isInContext = false;
                                foreach (GUIContext c in GUIContext.contexts)
                                    c.inContext = false;
                                DefaultDraw(canvas, pen);
                            }
                            if (GUIContext.isInContext && control.inContext)
                            {
                                string name = "";
                                ControlRefresh(canvas,pen);
                                MessageBox realfor = new MessageBox(canvas,pen,"format", "Are you sure you want to format it?",true,this);
                                while(true)
                                {
                                    var LAST = Sys.KeyboardManager.ReadKey();
                                    if (LAST.Key == Sys.ConsoleKeyEx.Escape)
                                    {
                                        control.Close(this, canvas, pen);
                                        break;
                                    }
                                    else if (LAST.Key == Sys.ConsoleKeyEx.Enter)
                                    {
                                        ControlRefresh(canvas,pen);
                                        pen.Color = Color.Black;
                                        canvas.DrawString(name, PCScreenFont.Default, pen, 420, 120);
                                        if (name.ToLower() == "format")
                                        {
                                            realfor.Draw();
                                            while(!realfor.clicked)
                                            {
                                                Sys.MouseManager.ScreenWidth = (uint)canvas.Mode.Columns;
                                                Sys.MouseManager.ScreenHeight = (uint)canvas.Mode.Rows;
                                                int XZ = (int)Sys.MouseManager.X;
                                                int YZ = (int)Sys.MouseManager.Y;
                                                pen.Color = Color.Black;
                                                canvas.DrawLine(pen, XZ, YZ, XZ + 5, YZ);
                                                canvas.DrawLine(pen, XZ, YZ, XZ, YZ - 5);
                                                canvas.DrawLine(pen, XZ, YZ, XZ + 5, YZ - 5);
                                                realfor.Refresh(canvas,pen,this,(int)Sys.MouseManager.X,(int)Sys.MouseManager.Y);
                                            }
                                            if (realfor.yesno_result)
                                            {
                                                fs.Format(EnvPath,EnvPath,true);
                                                Sys.Power.Reboot();
                                            }
                                            control.Close(this, canvas, pen);
                                            break;
                                        }
                                        else if (name.ToLower() == "info")
                                        {
                                            control.Close(this, canvas, pen);
                                            GUIContext g = new GUIContext("Computer Info",this);
                                            pen.Color = Color.Blue;
                                            canvas.DrawFilledCircle(pen,300,500,100);
                                            pen.Color = Color.White;
                                            canvas.DrawString("Info",PCScreenFont.Default,pen,300,500);
                                            break;
                                        }
                                        else if (name.ToLower() == "themes")
                                        {
                                            TextMessageBox TM = new TextMessageBox(canvas, pen, "Themes", "Set Theme\n1.Default\n2.Classic",this);
                                            TM.Draw(this);
                                            if (TM.inputtext.ToLower() == "default")
                                            {
                                                fs.DeleteFile(fs.GetFile(@"0:\Settings\theme.bool"));
                                                WriteFile(fs.CreateFile(@"0:\Settings\theme.bool"),"true");
                                            }
                                            else
                                            {
                                                fs.DeleteFile(fs.GetFile(@"0:\Settings\theme.bool"));
                                                WriteFile(fs.CreateFile(@"0:\Settings\theme.bool"), "false");
                                            }
                                            control.Close(this,canvas,pen);
                                            break;
                                        }
                                        else if (name.ToLower() == "environments")
                                        {
                                            TextMessageBox TM = new TextMessageBox(canvas,pen,"Environment Path","Set Environment Path: ",this);
                                            TM.Draw(this);
                                            fs.DeleteFile(fs.GetFile(@"0:\Settings\env.txt"));
                                            fs.CreateFile(@"0:\Settings\env.txt");
                                            WriteFile(fs.GetFile(@"0:\Settings\env.txt"),TM.inputtext);
                                            EnvPath = TM.inputtext;
                                            control.Close(this,canvas,pen);
                                            break;
                                        }
                                        name = "";
                                    }
                                    else
                                        name += LAST.KeyChar;
                                    pen.Color = Color.Black;
                                    canvas.DrawString(name, PCScreenFont.Default, pen, 420, 120);
                                }
                            }
                            if (GUIContext.isInContext && f.inContext)
                            {
                                f.SetGUIContext(canvas);
                                pen.Color = Color.Black;
                                int XX = 20;
                                int YY = 40;
                                var directory_list = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(CurrentDirectory);
                                foreach (var directoryEntry in directory_list)
                                {
                                    if (directoryEntry.mName.ToLower().Contains(".hdn"))
                                        continue;
                                    if (YY > 700)
                                    {
                                        YY = 40;
                                        XX += 180;
                                    }
                                    if (directoryEntry.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                                    {
                                        pen.Color = Color.DarkOrange;
                                        canvas.DrawFilledRectangle(pen,XX,YY,50,50);
                                        pen.Color = Color.Orange;
                                        canvas.DrawFilledRectangle(pen, XX, YY + 20, 50, 30);
                                    }
                                    else
                                    {
                                        DrawFileIcon(directoryEntry,canvas,pen,XX,YY);
                                        /*pen.Color = Color.Black;
                                        canvas.DrawLine(pen,30,YY + 15,55,YY + 15);
                                        canvas.DrawLine(pen,30,YY + 7.5f,55,YY + 7.5f);*/
                                    }
                                    pen.Color = Color.Black;
                                    canvas.DrawString(CurrentDirectory, PCScreenFont.Default, pen, 400, 700);
                                    canvas.DrawString(directoryEntry.mName, PCScreenFont.Default, pen, XX + 65, YY);
                                    YY += 60;
                                }
                                string filename = "";
                                pen.Color = Color.White;
                                canvas.DrawFilledRectangle(pen, 300, 100, 150, 50);
                                pen.Color = Color.Black;
                                canvas.DrawRectangle(pen, 300, 100, 150, 50);
                                pen.Color = Color.White;
                                canvas.DrawFilledRectangle(pen, 400, 100, 150, 50);
                                pen.Color = Color.Black;
                                canvas.DrawRectangle(pen, 400, 100, 150, 50);
                                canvas.DrawString("Search", PCScreenFont.Default, pen, 320, 120);
                                while (true)
                                {
                                    Sys.KeyEvent filechar = Sys.KeyboardManager.ReadKey();
                                    if (filechar.Key == Sys.ConsoleKeyEx.Backspace)
                                    {
                                        filename = filename.Remove(filename.Length - 1);
                                        f.SetGUIContext(canvas);
                                        pen.Color = Color.Black;
                                        int YY2 = 40;
                                        int XX2 = 20;
                                        var directory_list2 = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(CurrentDirectory);
                                        if (CurrentDirectory != @"0:\\" && CurrentDirectory != EnvPath)
                                        {
                                            canvas.DrawString("..", PCScreenFont.Default, pen, /*150*/ XX2 + 65, YY2);
                                            pen.Color = Color.DarkOrange;
                                            canvas.DrawFilledRectangle(pen, 20, YY2, 50, 50);
                                            pen.Color = Color.Orange;
                                            canvas.DrawFilledRectangle(pen, 20, YY2 + 20, 50, 30);
                                            YY2 += 60;
                                        }
                                        foreach (var directoryEntry in directory_list2)
                                        {
                                            if (directoryEntry.mName.ToLower().Contains(".hdn"))
                                                continue;
                                            if (YY2 > 700)
                                            {
                                                YY2 = 40;
                                                XX2 += 180;
                                            }
                                            if (directoryEntry.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                                            {
                                                pen.Color = Color.DarkOrange;
                                                canvas.DrawFilledRectangle(pen, XX2, YY2, 50, 50);
                                                pen.Color = Color.Orange;
                                                canvas.DrawFilledRectangle(pen, XX2, YY2 + 20, 50, 30);
                                            }
                                            else
                                            {
                                                DrawFileIcon(directoryEntry, canvas, pen, XX2, YY2);
                                                /*pen.Color = Color.Black;
                                                canvas.DrawLine(pen,30,YY + 15,55,YY + 15);
                                                canvas.DrawLine(pen,30,YY + 7.5f,55,YY + 7.5f);*/
                                            }
                                            pen.Color = Color.Black;
                                            canvas.DrawString(CurrentDirectory, PCScreenFont.Default, pen, 400, 700);
                                            canvas.DrawString(directoryEntry.mName, PCScreenFont.Default, pen, XX2 + 65, YY2);
                                            YY2 += 60;
                                        }
                                        pen.Color = Color.White;
                                        canvas.DrawFilledRectangle(pen, 300, 100, 150, 50);
                                        pen.Color = Color.Black;
                                        canvas.DrawRectangle(pen, 300, 100, 150, 50);
                                        pen.Color = Color.White;
                                        canvas.DrawFilledRectangle(pen, 400, 100, 150, 50);
                                        pen.Color = Color.Black;
                                        canvas.DrawRectangle(pen, 400, 100, 150, 50);
                                        canvas.DrawString("Search", PCScreenFont.Default, pen, 320, 120);
                                        canvas.DrawString(filename, PCScreenFont.Default, pen, 420, 120);
                                    }
                                    else if (filechar.Key == Sys.ConsoleKeyEx.F1)
                                    {
                                        fs.CreateFile(CurrentDirectory + filename);
                                    }
                                    else if (filechar.Key == Sys.ConsoleKeyEx.F2)
                                    {
                                        fs.CreateDirectory(CurrentDirectory + filename);
                                    }
                                    else if (filechar.Key == Sys.ConsoleKeyEx.F3)
                                    {
                                        try { fs.DeleteFile(fs.GetFile(CurrentDirectory + filename)); } catch { fs.DeleteDirectory(fs.GetDirectory(CurrentDirectory + filename)); }
                                    }
                                    else if (filechar.Key == Sys.ConsoleKeyEx.F5)
                                    {
                                        f.SetGUIContext(canvas);
                                        pen.Color = Color.Black;
                                        int YY2 = 40;
                                        int XX2 = 20;
                                        var directory_list2 = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(CurrentDirectory);
                                        if (CurrentDirectory != @"0:\\" && CurrentDirectory != EnvPath)
                                        {
                                            canvas.DrawString("..", PCScreenFont.Default, pen, /*150*/ XX2 + 65, YY2);
                                            pen.Color = Color.DarkOrange;
                                            canvas.DrawFilledRectangle(pen, XX2, YY2, 50, 50);
                                            pen.Color = Color.Orange;
                                            canvas.DrawFilledRectangle(pen, XX2, YY2 + 20, 50, 30);
                                            YY2 += 60;
                                        }
                                        foreach (var directoryEntry in directory_list2)
                                        {
                                            if (directoryEntry.mName.ToLower().Contains(".hdn"))
                                                continue;
                                            if (YY2 > 700)
                                            {
                                                YY2 = 40;
                                                XX2 += 180;
                                            }
                                            if (directoryEntry.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                                            {
                                                pen.Color = Color.DarkOrange;
                                                canvas.DrawFilledRectangle(pen, XX2, YY2, 50, 50);
                                                pen.Color = Color.Orange;
                                                canvas.DrawFilledRectangle(pen, XX2, YY2 + 20, 50, 30);
                                            }
                                            else
                                            {
                                                DrawFileIcon(directoryEntry, canvas, pen, XX2, YY2);
                                                /*pen.Color = Color.Black;
                                                canvas.DrawLine(pen,30,YY + 15,55,YY + 15);
                                                canvas.DrawLine(pen,30,YY + 7.5f,55,YY + 7.5f);*/
                                            }
                                            pen.Color = Color.Black;
                                            canvas.DrawString(CurrentDirectory, PCScreenFont.Default, pen, 400, 700);
                                            canvas.DrawString(directoryEntry.mName, PCScreenFont.Default, pen, XX2 + 65, YY2);
                                            YY2 += 60;
                                        }
                                        pen.Color = Color.White;
                                        canvas.DrawFilledRectangle(pen, 300, 100, 150, 50);
                                        pen.Color = Color.Black;
                                        canvas.DrawRectangle(pen, 300, 100, 150, 50);
                                        pen.Color = Color.White;
                                        canvas.DrawFilledRectangle(pen, 400, 100, 150, 50);
                                        pen.Color = Color.Black;
                                        canvas.DrawRectangle(pen, 400, 100, 150, 50);
                                        canvas.DrawString("Search", PCScreenFont.Default, pen, 320, 120);
                                        canvas.DrawString(filename, PCScreenFont.Default, pen, 420, 120);
                                    }
                                    else if (filechar.Key == Sys.ConsoleKeyEx.Enter)
                                    {
                                        Sys.FileSystem.Listing.DirectoryEntry FILE = null;
                                        if (filename == "..")
                                            FILE = fs.GetDirectory(CurrentDirectory).mParent;
                                        else
                                            try {  FILE = fs.GetFile(CurrentDirectory + filename); } catch {  FILE = fs.GetDirectory(CurrentDirectory + filename); }
                                        if (FILE.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
                                        {
                                            Excutable(FILE, canvas, pen);
                                            break;
                                        }
                                        else if (FILE.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                                        {
                                            CurrentDirectory = FILE.mFullPath + @"\";
                                            filename = "";
                                            f.SetGUIContext(canvas);
                                            pen.Color = Color.Black;
                                            int YY3 = 40;
                                            int XX3 = 20;
                                            directory_list = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(CurrentDirectory);
                                            if (CurrentDirectory != @"0:\\" && CurrentDirectory != EnvPath)
                                            {
                                                canvas.DrawString("..", PCScreenFont.Default, pen, /*150*/ XX3 + 65, YY3);
                                                pen.Color = Color.DarkOrange;
                                                canvas.DrawFilledRectangle(pen, XX3, YY3, 50, 50);
                                                pen.Color = Color.Orange;
                                                canvas.DrawFilledRectangle(pen, XX3, YY3 + 20, 50, 30);
                                                YY3 += 60;
                                            }
                                            foreach (var directoryEntry in directory_list)
                                            {
                                                if (directoryEntry.mName.ToLower().Contains(".hdn"))
                                                    continue;
                                                if (YY3 > 700)
                                                {
                                                    YY3 = 40;
                                                    XX3 += 180;
                                                }
                                                if (directoryEntry.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                                                {
                                                    pen.Color = Color.DarkOrange;
                                                    canvas.DrawFilledRectangle(pen, XX3, YY3, 50, 50);
                                                    pen.Color = Color.Orange;
                                                    canvas.DrawFilledRectangle(pen, XX3, YY3 + 20, 50, 30);
                                                }
                                                else
                                                {
                                                    DrawFileIcon(directoryEntry, canvas, pen, XX3, YY3);
                                                    /*pen.Color = Color.Black;
                                                    canvas.DrawLine(pen,30,YY + 15,55,YY + 15);
                                                    canvas.DrawLine(pen,30,YY + 7.5f,55,YY + 7.5f);*/
                                                }
                                                pen.Color = Color.Black;
                                                canvas.DrawString(CurrentDirectory, PCScreenFont.Default, pen, 400, 700);
                                                canvas.DrawString(directoryEntry.mName, PCScreenFont.Default, pen, XX3 + 65, YY3);
                                                YY3 += 60;
                                            }
                                            pen.Color = Color.White;
                                            canvas.DrawFilledRectangle(pen, 300, 100, 150, 50);
                                            pen.Color = Color.Black;
                                            canvas.DrawRectangle(pen, 300, 100, 150, 50);
                                            pen.Color = Color.White;
                                            canvas.DrawFilledRectangle(pen, 400, 100, 150, 50);
                                            pen.Color = Color.Black;
                                            canvas.DrawRectangle(pen, 400, 100, 150, 50);
                                            canvas.DrawString("Search", PCScreenFont.Default, pen, 320, 120);
                                        }
                                    }
                                    else if (filechar.Key == Sys.ConsoleKeyEx.Escape)
                                    {
                                        GUIContext.isInContext = false;
                                        foreach (GUIContext c in GUIContext.contexts)
                                            c.inContext = false;
                                        goto DEFAULT;
                                    }
                                    else
                                    {
                                        filename += filechar.KeyChar;
                                    }
                                    canvas.DrawString(filename, PCScreenFont.Default, pen, 420, 120);
                                }
                            }
                            if (n.inContext)
                            {
                                if (content != "")
                                {
                                    notepad_value = content;
                                    content = "";
                                    int yY = 40;
                                    foreach (string S in notepad_value.Split('\n'))
                                    {
                                        canvas.DrawString(S, PCScreenFont.Default, pen, 0, yY);
                                        yY += 15;
                                    }
                                }
                                Sys.KeyEvent key = Sys.KeyboardManager.ReadKey();
                                if (key.Key == Sys.ConsoleKeyEx.Escape)
                                {
                                    GUIContext.isInContext = false;
                                    foreach (GUIContext c in GUIContext.contexts)
                                        c.inContext = false;
                                    n.inContext = false;
                                    notepad_value = null;
                                    //DefaultDraw(canvas, pen);
                                    goto DEFAULT;
                                }
                                else if (key.Key == Sys.ConsoleKeyEx.F1)
                                {
                                    string filename = "";
                                    pen.Color = Color.White;
                                    canvas.DrawFilledRectangle(pen, 300, 100, 150, 50);
                                    pen.Color = Color.Black;
                                    canvas.DrawRectangle(pen, 300, 100, 150, 50);
                                    pen.Color = Color.White;
                                    canvas.DrawFilledRectangle(pen, 400, 100, 150, 50);
                                    pen.Color = Color.Black;
                                    canvas.DrawRectangle(pen, 400, 100, 150, 50);
                                    canvas.DrawString("File name", PCScreenFont.Default, pen, 320, 120);
                                    while (true)
                                    {
                                        Sys.KeyEvent filechar = Sys.KeyboardManager.ReadKey();
                                        if (filechar.Key == Sys.ConsoleKeyEx.Backspace)
                                        {
                                            filename = filename.Remove(filename.Length - 1);
                                            n.SetGUIContext(canvas);
                                            int yy = 40;
                                            foreach (string S in notepad_value.Split('\n'))
                                            {
                                                canvas.DrawString(S, PCScreenFont.Default, pen, 0, yy);
                                                yy += 15;
                                            }
                                            pen.Color = Color.White;
                                            canvas.DrawFilledRectangle(pen, 300, 100, 150, 50);
                                            pen.Color = Color.Black;
                                            canvas.DrawRectangle(pen, 300, 100, 150, 50);
                                            pen.Color = Color.White;
                                            canvas.DrawFilledRectangle(pen, 400, 100, 150, 50);
                                            pen.Color = Color.Black;
                                            canvas.DrawRectangle(pen, 400, 100, 150, 50);
                                            canvas.DrawString("File name", PCScreenFont.Default, pen, 320, 120);
                                            canvas.DrawString(filename, PCScreenFont.Default, pen, 420, 120);
                                        }
                                        else if (filechar.Key == Sys.ConsoleKeyEx.Enter)
                                        {
                                            GUIContext.isInContext = false;
                                            foreach (GUIContext c in GUIContext.contexts)
                                                c.inContext = false;
                                            n.inContext = false;
                                            //DefaultDraw(canvas, pen);
                                            fs.DeleteFile(fs.GetFile(EnvPath + filename));
                                            Sys.FileSystem.Listing.DirectoryEntry file = fs.CreateFile(EnvPath + filename);
                                            var stream = file.GetFileStream();
                                            if (stream.CanWrite)
                                            {
                                                byte[] text_to_write = Encoding.ASCII.GetBytes(notepad_value);
                                                stream.Write(text_to_write, 0, text_to_write.Length);
                                            }
                                            notepad_value = null;
                                            goto DEFAULT;
                                            //break;
                                        }
                                        else
                                        {
                                            filename += filechar.KeyChar;
                                        }
                                        canvas.DrawString(filename, PCScreenFont.Default, pen, 420, 120);
                                    }
                                }
                                else if (key.Key == Sys.ConsoleKeyEx.F2)
                                {
                                    string filename = "";
                                    pen.Color = Color.White;
                                    canvas.DrawFilledRectangle(pen, 300, 100, 150, 50);
                                    pen.Color = Color.Black;
                                    canvas.DrawRectangle(pen, 300, 100, 150, 50);
                                    pen.Color = Color.White;
                                    canvas.DrawFilledRectangle(pen, 400, 100, 150, 50);
                                    pen.Color = Color.Black;
                                    canvas.DrawRectangle(pen, 400, 100, 150, 50);
                                    canvas.DrawString("File name", PCScreenFont.Default, pen, 320, 120);
                                    while (true)
                                    {
                                        Sys.KeyEvent filechar = Sys.KeyboardManager.ReadKey();
                                        if (filechar.Key == Sys.ConsoleKeyEx.Backspace)
                                        {
                                            filename = filename.Remove(filename.Length - 1);
                                            n.SetGUIContext(canvas);
                                            int yy = 40;
                                            foreach (string S in notepad_value.Split('\n'))
                                            {
                                                canvas.DrawString(S, PCScreenFont.Default, pen, 0, yy);
                                                yy += 15;
                                            }
                                            pen.Color = Color.White;
                                            canvas.DrawFilledRectangle(pen, 300, 100, 150, 50);
                                            pen.Color = Color.Black;
                                            canvas.DrawRectangle(pen, 300, 100, 150, 50);
                                            pen.Color = Color.White;
                                            canvas.DrawFilledRectangle(pen, 400, 100, 150, 50);
                                            pen.Color = Color.Black;
                                            canvas.DrawRectangle(pen, 400, 100, 150, 50);
                                            canvas.DrawString("File name", PCScreenFont.Default, pen, 320, 120);
                                            canvas.DrawString(filename, PCScreenFont.Default, pen, 420, 120);
                                        }
                                        else if (filechar.Key == Sys.ConsoleKeyEx.Enter)
                                        {
                                            GUIContext.isInContext = false;
                                            foreach (GUIContext c in GUIContext.contexts)
                                                c.inContext = false;
                                            n.inContext = false;
                                            //DefaultDraw(canvas, pen);
                                            Sys.FileSystem.Listing.DirectoryEntry file = fs.GetFile(EnvPath + filename);
                                            var stream = file.GetFileStream();
                                            if (stream.CanRead)
                                            {
                                                byte[] text_to_read = new byte[stream.Length];
                                                stream.Read(text_to_read, 0, (int)stream.Length);
                                                notepad_value = Encoding.Default.GetString(text_to_read);
                                            }
                                            n.SetGUIContext(canvas);
                                            break;
                                        }
                                        else
                                        {
                                            filename += filechar.KeyChar;
                                        }
                                        canvas.DrawString(filename, PCScreenFont.Default, pen, 420, 120);
                                    }
                                }
                                else if (key.Key == Sys.ConsoleKeyEx.Enter)
                                {
                                    notepad_value += '\n';
                                }
                                else if (key.Key == Sys.ConsoleKeyEx.Backspace)
                                {
                                    notepad_value = notepad_value.Remove(notepad_value.Length - 1);
                                    n.SetGUIContext(canvas);
                                }
                                else
                                    notepad_value += key.KeyChar;
                                int y = 40;
                                foreach (string S in notepad_value.Split('\n'))
                                {
                                    canvas.DrawString(S, PCScreenFont.Default, pen, 0, y);
                                    y += 15;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox errorbox = new MessageBox(canvas, pen, "Error", ex.ToString(),this);
                            errorbox.Draw();
                            while (!errorbox.clicked)
                            {
                                Sys.MouseManager.ScreenWidth = (uint)canvas.Mode.Columns;
                                Sys.MouseManager.ScreenHeight = (uint)canvas.Mode.Rows;
                                int X = (int)Sys.MouseManager.X;
                                int Y = (int)Sys.MouseManager.Y;
                                canvas.DrawLine(pen, X, Y, X + 5, Y);
                                canvas.DrawLine(pen, X, Y, X, Y - 5);
                                canvas.DrawLine(pen, X, Y, X + 5, Y - 5);
                                errorbox.Refresh(canvas,pen,this,(int)Sys.MouseManager.X,(int)Sys.MouseManager.Y);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox errorbox = new MessageBox(canvas, pen, "Fatal Error", e.ToString(),this);
                    errorbox.Draw();
                    while (!errorbox.clicked)
                    {
                        Sys.MouseManager.ScreenWidth = (uint)canvas.Mode.Columns;
                        Sys.MouseManager.ScreenHeight = (uint)canvas.Mode.Rows;
                        int X = (int)Sys.MouseManager.X;
                        int Y = (int)Sys.MouseManager.Y;
                        canvas.DrawLine(pen, X, Y, X + 5, Y);
                        canvas.DrawLine(pen, X, Y, X, Y - 5);
                        canvas.DrawLine(pen, X, Y, X + 5, Y - 5);
                        errorbox.Refresh(canvas, pen, this, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y);
                    }
                }
            }
            else if (setup)
            {
                MessageBox log = new MessageBox(canvas,pen,"ToRunOS","Install Ended! Do You Want to Login?",true,this);
                MessageBox needreboot = new MessageBox(canvas, pen, "ToRunOS", "you need to restart os.",this);
                MessageBox areyouformat = new MessageBox(canvas, pen, "ToRunOS", "Do you want to format it?",true,this);
                canvas.DrawString("Please wait a moment.", PCScreenFont.Default, pen, 400, 300);
                canvas.DrawFilledCircle(pen, 450, 150, 80);
                pen.Color = Color.Blue;
                canvas.DrawString("ToRun OS", PCScreenFont.Default, pen, 415, 145);
                Cosmos.HAL.Global.PIT.Wait(2000);
                canvas.Clear(Color.Blue);
                canvas.DrawFilledCircle(pen, 450, 150, 80);
                pen.Color = Color.Blue;
                canvas.DrawString("ToRun OS ", PCScreenFont.Default, pen, 450, 150);
                /*areyouformat.DrawAndShow(canvas,pen,this);
                /*while (!areyouformat.clicked)
                {
                    Sys.MouseManager.ScreenWidth = (uint)canvas.Mode.Columns;
                    Sys.MouseManager.ScreenHeight = (uint)canvas.Mode.Rows;
                    int X = (int)Sys.MouseManager.X;
                    int Y = (int)Sys.MouseManager.Y;
                    canvas.DrawLine(pen, X, Y, X + 5, Y);
                    canvas.DrawLine(pen, X, Y, X, Y - 5);
                    canvas.DrawLine(pen, X, Y, X + 5, Y - 5);
                    areyouformat.Refresh(canvas, pen, this, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y);
                }
                //
                canvas.Clear(Color.Blue);
                if (areyouformat.yesno_result)
                {
                    canvas.DrawString("Formatting...", PCScreenFont.Default, pen, 350, 300);
                    canvas.DrawString("Installing ToRunOS is considered to have accepted the license.", PCScreenFont.Default, pen, 350, 500);
                    fs.Format(EnvPath, EnvPath, true);
                }*/
                canvas.Clear(Color.Blue);
                pen.Color = Color.White;
                canvas.DrawFilledCircle(pen, 450, 150, 80);
                pen.Color = Color.Blue;
                canvas.DrawString("ToRun OS ", PCScreenFont.Default, pen, 430, 150);
                pen.Color = Color.White;
                canvas.DrawString("ToRunOS is copying files...", PCScreenFont.Default, pen, 400, 300);
                fs.CreateFile(@"0:\logaccount.hdn");
                fs.CreateDirectory(@"0:\Main");
                fs.CreateDirectory(@"0:\Settings");
                var DESKTOP = fs.CreateFile(@"0:\Settings\Desktop.ges");
                WriteFile(DESKTOP,"#this is Desktop Image\ncolor lightblue\nclear");
                var THEME = fs.CreateFile(@"0:\Settings\theme.bool");
                WriteFile(THEME,"true");
                var ENV = fs.CreateFile(@"0:\Settings\env.txt");
                WriteFile(ENV,@"0:\");
                fs.CreateDirectory(@"0:\Documents");
                var README = fs.CreateFile(@"0:\Documents\README.txt");
                var FILE = fs.CreateFile(@"0:\Documents\abc.txt");
                var BIN = fs.CreateFile(@"0:\Documents\Binary.bin");
                WriteFile(README, "ToRunOS\n\n---License---\nYou cannot deploy or modify this operating system.\nInstalling ToRunOS is considered\n to have accepted the license.\n\n---HOW TO USE---\n\nMove Mouse Cursor. And Mouse Click.");
                WriteFile(FILE,"A B C\nD E F\nG H I\nJ K L\nN M O\nP Q R\n S T U\nV W X\nY Z");
                WriteFile(BIN, "01010100011011110101001001110101011011100100111101010011");
                fs.DeleteFile(hal);
                fs.DeleteFile(pal);
                fs.CreateFile(@"0:\userid.txt");
                fs.CreateFile(@"0:\userpass.txt");
                log.Draw();
                while (!log.clicked)
                {
                    Sys.MouseManager.ScreenWidth = (uint)canvas.Mode.Columns;
                    Sys.MouseManager.ScreenHeight = (uint)canvas.Mode.Rows;
                    int X = (int)Sys.MouseManager.X;
                    int Y = (int)Sys.MouseManager.Y;
                    canvas.DrawLine(pen, X, Y, X + 5, Y);
                    canvas.DrawLine(pen, X, Y, X, Y - 5);
                    canvas.DrawLine(pen, X, Y, X + 5, Y - 5);
                    log.Refresh(canvas,pen,this,(int)Sys.MouseManager.X,(int)Sys.MouseManager.Y);
                }
                canvas.Clear(Color.Blue);
                if (log.yesno_result)
                    WriteFile(fs.GetFile(@"0:\logaccount.hdn"),"true");
                var hello_filea = fs.GetFile(@"0:\logaccount.hdn");
                var hello_file_streama = hello_filea.GetFileStream();
                if (hello_file_streama.CanRead)
                {
                    byte[] text_to_reada = new byte[hello_file_streama.Length];
                    hello_file_streama.Read(text_to_reada, 0, (int)hello_file_streama.Length);
                    var value22 = Encoding.Default.GetString(text_to_reada);
                    if (value22 == "true")
                    {
                        canvas.Disable();
                        ToSingUp();
                        printf("You need rebooting.");
                        Sys.Power.Reboot();
                    }
                    else
                    {
                        try
                        {
                            var hello_filed = fs.GetFile(@"0:\userid.txt");
                            var hello_file_streamd = hello_filed.GetFileStream();

                            if (hello_file_streamd.CanWrite)
                            {
                                byte[] text_to_writed = Encoding.ASCII.GetBytes("NotSetToLogin");
                                hello_file_streamd.Write(text_to_writed, 0, text_to_writed.Length);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    //Console.WriteLine("");
                    //Console.ForegroundColor = ConsoleColor.DarkRed;
                    //printf("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    //printf("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    needreboot.Draw();
                    while (!needreboot.clicked)
                    {
                        Sys.MouseManager.ScreenWidth = (uint)canvas.Mode.Columns;
                        Sys.MouseManager.ScreenHeight = (uint)canvas.Mode.Rows;
                        int X = (int)Sys.MouseManager.X;
                        int Y = (int)Sys.MouseManager.Y;
                        canvas.DrawLine(pen, X, Y, X + 5, Y);
                        canvas.DrawLine(pen, X, Y, X, Y - 5);
                        canvas.DrawLine(pen, X, Y, X + 5, Y - 5);
                        needreboot.Refresh(canvas, pen, this, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y);
                    }
                    Sys.Power.Reboot();
                }

            }
        }
        void ControlRefresh(Canvas canvas,Pen pen)
        {
            pen.Color = Color.White;
            canvas.DrawFilledRectangle(pen, 300, 100, 150, 50);
            pen.Color = Color.Black;
            canvas.DrawRectangle(pen, 300, 100, 150, 50);
            pen.Color = Color.White;
            canvas.DrawFilledRectangle(pen, 400, 100, 150, 50);
            pen.Color = Color.Black;
            canvas.DrawRectangle(pen, 400, 100, 150, 50);
            canvas.DrawString("Search", PCScreenFont.Default, pen, 320, 120);
            canvas.DrawString("Format", PCScreenFont.Default, pen, 150, 400);
            canvas.DrawString("Environments", PCScreenFont.Default, pen, 150, 430);
            canvas.DrawString("Themes", PCScreenFont.Default, pen, 150, 490);
            canvas.DrawString("Info", PCScreenFont.Default, pen, 150, 460);
            }
        public void Excutable(Sys.FileSystem.Listing.DirectoryEntry FILE, Canvas canvas, Pen pen)
        {
            if (FILE.mName.ToLower().Contains(".txt") && FILE.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
            {
                var stream = FILE.GetFileStream();
                if (stream.CanRead)
                {
                    byte[] text_to_read = new byte[stream.Length];
                    stream.Read(text_to_read, 0, (int)stream.Length);
                    content = Encoding.Default.GetString(text_to_read);
                }
                GUIContext.isInContext = false;
                foreach (GUIContext c in GUIContext.contexts)
                    c.inContext = false;
                n.SetGUIContext(canvas);
            }
            else if (FILE.mName.Contains(".ges") && FILE.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
            {
                f.Close(this, canvas, pen);
                OpenGraphicFile(FILE, canvas, pen);
            }
            else if (FILE.mName.ToLower().Contains(".bmp") && FILE.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
            {
                f.Close(this, canvas, pen);
                canvas.DrawImage(new Bitmap(FILE.mFullPath),0,0);
            }
            else if (FILE.mName.Contains(".lfv") && FILE.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
            {
                TextMessageBox text = new TextMessageBox(canvas,pen,"Video Player", "How many seconds do you \nwant to wait until the \nnext frame?",this);
                text.Draw();
                f.Close(this, canvas, pen);
                OpenGraphicVideo(FILE, canvas, pen, (uint)Convert.ToInt32(text.inputtext));
            }
            else if (FILE.mName.Contains(".fin") || FILE.mName.Contains(".final") && FILE.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
            {
                f.Close(this, canvas, pen);
                /*foreach (string LINE in Read(FILE).Split('\n'))
                    Finalc.Interprint(LINE);*/
            }
            else if (FILE.mName.Contains(".cmd") && FILE.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
            {
                godtorun = true;
                canvas.Disable();
                CmdReader reader = new CmdReader();
                foreach (string S in Read(FILE).Split('\n'))
                    reader.ReadCommand(this, S);
            }
            else if (FILE.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
            {
                MessageBox error = new MessageBox(canvas, pen, "Error", "Cannot open the file.\nDo you want to open with notepad?", true,this);
                error.Draw();
                while (!error.clicked)
                {
                    Sys.MouseManager.ScreenWidth = (uint)canvas.Mode.Columns;
                    Sys.MouseManager.ScreenHeight = (uint)canvas.Mode.Rows;
                    int X_ = (int)Sys.MouseManager.X;
                    int Y_ = (int)Sys.MouseManager.Y;
                    canvas.DrawLine(pen, X_, Y_, X_ + 5, Y_);
                    canvas.DrawLine(pen, X_, Y_, X_, Y_ - 5);
                    error.Refresh(canvas, pen, this, X_, Y_);
                }
                GUIContext.isInContext = false;
                foreach (GUIContext c in GUIContext.contexts)
                    c.inContext = false;
                if (error.yesno_result)
                {
                    var stream = FILE.GetFileStream();
                    if (stream.CanRead)
                    {
                        byte[] text_to_read = new byte[stream.Length];
                        stream.Read(text_to_read, 0, (int)stream.Length);
                        content = Encoding.Default.GetString(text_to_read);
                    }
                    n.SetGUIContext(canvas);
                }
            }
        }
        public void DrawFileIcon(Sys.FileSystem.Listing.DirectoryEntry directoryEntry,Canvas canvas,Pen pen,int XX,int YY)
        {
            if (directoryEntry.mName.Contains(".txt"))
            {
                pen.Color = Color.LightGray;
                canvas.DrawRectangle(pen, XX + 10, YY, 30, 40);
                pen.Color = Color.Black;
                canvas.DrawLine(pen, XX + 14, YY + 5, XX + 33, YY + 5);
                canvas.DrawLine(pen, XX + 14, YY + 15, XX + 33, YY + 15);
            }
            else if (directoryEntry.mName.Contains(".ges"))
            {
                pen.Color = Color.LightGray;
                canvas.DrawRectangle(pen, XX + 10, YY, 30, 40);
                pen.Color = Color.LightBlue;
                canvas.DrawFilledRectangle(pen, XX + 10, YY, 30, 40);
                pen.Color = Color.Lime;
                canvas.DrawFilledRectangle(pen, XX + 10, YY + 20, 30, 20);
            }
            else if (directoryEntry.mName.Contains(".lfv"))
            {
                pen.Color = Color.SteelBlue;
                canvas.DrawFilledRectangle(pen, XX + 10, YY - 10, 40, 5);
                canvas.DrawFilledRectangle(pen, XX + 10, YY - 5, 5, 35);
                canvas.DrawFilledRectangle(pen, XX + 10, YY + 15, 40, 20);
            }
            else if (directoryEntry.mName.Contains(".cmd") || directoryEntry.mName.Contains(".bat"))
            {
                pen.Color = Color.Black;
                canvas.DrawFilledRectangle(pen, XX + 10, YY, 30, 30);
                pen.Color = Color.LightGray;
                canvas.DrawRectangle(pen, XX + 10, YY, 30, 30);
                pen.Color = Color.White;
                canvas.DrawString(">_",PCScreenFont.Default,pen,XX + 17,YY + 10);
            }
            else
            {
                pen.Color = Color.LightGray;
                canvas.DrawFilledRectangle(pen, XX + 10, YY, 30, 40);
                pen.Color = Color.White;
                canvas.DrawString("?", PCScreenFont.Default, pen, XX + 20, YY + 10);
            }
        }
        public void DefaultDraw(Canvas canvas,Pen pen)
        {
            DrawGraphicFile(fs.GetFile(@"0:\Settings\Desktop.ges"),canvas,pen);
            pen.Color = Color.Blue;
            canvas.DrawCircle(pen, 65, 714, 35);
            pen.Color = Color.Black;
            canvas.DrawFilledRectangle(pen, 150, 690, 50, 50);
            pen.Color = Color.Blue;
            canvas.DrawFilledRectangle(pen, 280, 690, 50, 50);
            pen.Color = Color.White;
            canvas.DrawFilledRectangle(pen, 410, 690, 50, 50); //페인트
            pen.Color = Color.Red;
            canvas.DrawFilledRectangle(pen, 420, 692, 5, 5); //페인트 1
            pen.Color = Color.Lime;
            canvas.DrawFilledRectangle(pen, 420, 710, 5, 5); //페인트 1
            pen.Color = Color.Blue;
            canvas.DrawFilledRectangle(pen, 420, 728, 5, 5); //페인트 1
            pen.Color = Color.White;
            canvas.DrawFilledRectangle(pen, 560, 670, 50, 50);
            pen.Color = Color.LightBlue;
            canvas.DrawFilledRectangle(pen, 540, 690, 50, 50);
            pen.Color = Color.White;
            canvas.DrawRectangle(pen, 540, 690, 50, 50);
            pen.Color = Color.DarkOrange;
            canvas.DrawFilledRectangle(pen, 670, 690, 50, 50);
            pen.Color = Color.Orange;
            canvas.DrawFilledRectangle(pen, 670, 705, 50, 35);
            pen.Color = Color.Black;
            canvas.DrawFilledRectangle(pen, 800, 690, 50, 50);
            pen.Color = Color.Blue;
            canvas.DrawFilledRectangle(pen, 820, 710, 20, 20);
            pen.Color = Color.White;
            canvas.DrawString("About",PCScreenFont.Default,pen,287,710);
            canvas.DrawString("Run", PCScreenFont.Default, pen, 40, 10);
            canvas.DrawString("New", PCScreenFont.Default, pen, 120, 10);
            canvas.DrawString("ToRun OS", PCScreenFont.Default, pen, 32, 712);
            canvas.DrawString("Delete", PCScreenFont.Default, pen, 200, 10);
            canvas.DrawRectangle(pen, 150, 690, 50, 50);
            canvas.DrawString(">_",PCScreenFont.Default,pen,160,710);
        }
        void bluescreen(string errr)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine($"            \n                {errr}\n\n");
            Console.Write("             ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("    >>> Press Any Key To Continue. <<<    ");
            Console.ReadKey();
            Sys.Power.Reboot();

        }
        void printf(string msg)
        {
            Console.WriteLine($"{msg}");
        }
        void selection1()
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            printf(@"
|====================================|
|MY PC SETTINGS                      |
|====================================|
|                                    |
|    1: PROTECTE MODE WHEN PC AFK.   |
|    2: PC DISPLAY SETTINGS          |
|    3: FORMAT COMPUTER              |
|                                    |
|====================================|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            var hmm = Console.ReadLine();
            if (hmm == "1")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                what = 1;
            }
            else if (hmm == "2")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                what = 2;
            }
            else if (hmm == "3")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                what = 3;
            }
        }
        void ToSingUp()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            printf("     Sign Up To ToRunOS     ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Name>");
            var username = Console.ReadLine();
            Console.Write("Password>");
            var userpass = Console.ReadLine();

            var hello_file = fs.GetFile(@"0:\userid.txt");
            var hello_file_stream = hello_file.GetFileStream();
            var pass_file = fs.GetFile(@"0:\userpass.txt");

            var pass_file_stream = pass_file.GetFileStream();
            if (hello_file_stream.CanWrite && pass_file_stream.CanWrite)
            {
                byte[] text_to_write = Encoding.ASCII.GetBytes(username);
                hello_file_stream.Write(text_to_write, 0, text_to_write.Length);
                byte[] text_to_write2 = Encoding.ASCII.GetBytes(userpass);
                pass_file_stream.Write(text_to_write2, 0, text_to_write2.Length);
            }


        }
        void game()
        {

        }
        void boot()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            int sel = 0;
            while (true)
            {
                Console.Clear();
                if (sel == 0)
                {
                    printf("            Boot Manager            ");
                    printf("\n\n\n   local disk: 0:\n\n*  Using LocalDisk(0): True   \n\n   Using Volume: False");
                }
                else if (sel == 1)
                {
                    printf("            Boot Manager            ");
                    printf("\n\n\n   local disk: 0:\n\n   Using LocalDisk(0): True   \n\n*  Using Volume: False");
                }

                var a = Console.ReadKey();
                if (a.Key == ConsoleKey.Escape)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                }
                else if (a.Key == ConsoleKey.UpArrow && sel > 0)
                {
                    sel--;
                }
                else if (a.Key == ConsoleKey.DownArrow && sel < 1)
                {
                    sel++;
                }
                else if (a.Key == ConsoleKey.Enter)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                }


            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        void disksel()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            int sel = 0;
            while (true)
            {
                Console.Clear();
                if (sel == 0)
                {
                    printf("            Select Disk            ");
                    printf("\n\n* LocalDisk(0)    \n\n  SubLocalDriver(A)");
                }
                else if (sel == 1)
                {
                    printf("            Select Disk            ");
                    printf("\n\n  LocalDisk(0)    \n\n* SubLocalDriver(A)");
                }

                var a = Console.ReadKey();
                if (a.Key == ConsoleKey.UpArrow && sel > 0)
                {
                    sel--;
                }
                else if (a.Key == ConsoleKey.DownArrow && sel < 1)
                {
                    sel++;
                }
                else if (a.Key == ConsoleKey.Enter && sel == 1)
                {
                    printf("invaild driver.");
                }
                else if (a.Key == ConsoleKey.Enter && sel == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                }


            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        void setupend()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            int sel = 0;
            while (true)
            {
                Console.Clear();
                if (sel == 0)
                {
                    printf("           ToRunOS Setup           ");
                    printf("\nToRunOS Setup is Ended.\n* Restart    \n\n  Continue Without Restart");
                }
                else if (sel == 1)
                {
                    printf("           ToRunOS Setup           ");
                    printf("\nToRunOS Setup is Ended.\n  Restart    \n\n* Continue Without Restart");
                }

                var a = Console.ReadKey();
                if (a.Key == ConsoleKey.UpArrow && sel > 0)
                {
                    sel--;
                }
                else if (a.Key == ConsoleKey.DownArrow && sel < 1)
                {
                    sel++;
                }
                else if (a.Key == ConsoleKey.Enter && sel == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                }
                else if (a.Key == ConsoleKey.Enter && sel == 0)
                {
                    Sys.Power.Reboot();
                }


            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        void consolegui()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            int sel = 0;
            while (true)
            {
                Console.Clear();
                printf("[Arrow Keys] Move [Enter] Run [ESC] Exit\n");
                printf("\n0:\\");
                if (sel == 0)
                {
                    noselect();
                    Console.Write("\n\n\n");
                    select();
                    printf("Console");
                    noselect();
                    printf("Explorer");
                    printf("Notepad");
                    printf("Settings");
                    printf("Reboot");
                    printf("Shutdown");
                    printf("Games");
                    printf("Calculator");
                }
                else if (sel == 1)
                {
                    noselect();
                    Console.Write("\n\n\n");
                    noselect();
                    printf("Console");
                    select();
                    printf("Explorer");
                    noselect();
                    printf("Notepad");
                    printf("Settings");
                    printf("Reboot");
                    printf("Shutdown");
                    printf("Games");
                    printf("Calculator");
                }
                else if (sel == 2)
                {

                    noselect();
                    Console.Write("\n\n\n");
                    noselect();
                    printf("Console");
                    printf("Explorer");
                    select();
                    printf("Notepad");
                    noselect();
                    printf("Settings");
                    printf("Reboot");
                    printf("Shutdown");
                    printf("Games");
                    printf("Calculator");
                }
                else if (sel == 3)
                {
                    noselect();
                    Console.Write("\n\n\n");
                    noselect();
                    printf("Console");
                    printf("Explorer");
                    printf("Notepad");
                    select();
                    printf("Settings");
                    noselect();
                    printf("Reboot");
                    printf("Shutdown");
                    printf("Games");
                    printf("Calculator");
                }
                else if (sel == 4)
                {

                    noselect();
                    Console.Write("\n\n\n");
                    noselect();
                    printf("Console");
                    printf("Explorer");
                    printf("Notepad");
                    printf("Settings");
                    select();
                    printf("Reboot");
                    noselect();
                    printf("Shutdown");
                    printf("Games");
                    printf("Calculator");
                }
                else if (sel == 5)
                {

                    noselect();
                    Console.Write("\n\n\n");
                    noselect();
                    printf("Console");
                    printf("Explorer");
                    printf("Notepad");

                    printf("Settings");
                    printf("Reboot");
                    select();
                    printf("Shutdown");
                    noselect();
                    printf("Games");
                    printf("Calculator");
                }
                else if (sel == 6)
                {

                    noselect();
                    Console.Write("\n\n\n");
                    noselect();
                    printf("Console");
                    printf("Explorer");
                    printf("Notepad");

                    printf("Settings");
                    printf("Reboot");

                    printf("Shutdown");

                    select();
                    printf("Games");
                    noselect();
                    printf("Calculator");
                }
                else if (sel == 7)
                {

                    noselect();
                    Console.Write("\n\n\n");
                    noselect();
                    printf("Console");
                    printf("Explorer");
                    printf("Notepad");

                    printf("Settings");
                    printf("Reboot");

                    printf("Shutdown");


                    printf("Games");

                    select();
                    printf("Calculator");
                    noselect();
                }
                var a = Console.ReadKey();
                if (a.Key == ConsoleKey.UpArrow && sel > 0)
                {
                    sel--;
                }
                else if (a.Key == ConsoleKey.DownArrow && sel < 7)
                {
                    sel++;
                }
                else if (a.Key == ConsoleKey.LeftWindows)
                {
                    boot();
                    break;
                }
                else if (a.Key == ConsoleKey.Enter && sel == 1)
                {
                    explorer();
                    break;
                }
                else if (a.Key == ConsoleKey.Enter && sel == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                }
                else if (a.Key == ConsoleKey.Enter && sel == 2)
                {
                    notepad();
                    break;
                }
                else if (a.Key == ConsoleKey.Enter && sel == 4)
                {
                    Sys.Power.Reboot();
                }
                else if (a.Key == ConsoleKey.Enter && sel == 5)
                {
                    Sys.Power.Shutdown();
                }
                else if (a.Key == ConsoleKey.Enter && sel == 7)
                {
                    calc();
                    break;
                }
                else if (a.Key == ConsoleKey.Escape)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                }


            }
            Console.BackgroundColor = ConsoleColor.Black;

        }
        void calc()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            string v0 = "";
            string v1 = "";
            string op = "";
            int result = 0;
            while (true)
            {
                Console.WriteLine(v0 + op + v1);
                var a = Console.ReadKey();
                if (a.KeyChar == '+')
                {
                    op = "+";
                }
                else if (a.KeyChar == '-')
                {

                    op = "-";
                }
                else if (a.KeyChar == '/')
                {

                    op = "/";
                }
                else if (a.KeyChar == '*')
                {

                    op = "*";
                }
                else if (a.Key == ConsoleKey.D0)
                {
                    if (op == "")
                    {
                        v0 = v0 + "0";
                    }
                    else
                    {
                        v1 = v1 + "0";
                    }
                }
                else if (a.Key == ConsoleKey.Escape || a.Key == ConsoleKey.E)
                {
                    consolegui();
                    break;
                }
                else if (a.Key == ConsoleKey.D1)
                {
                    if (op == "")
                    {
                        v0 = v0 + "1";
                    }
                    else
                    {
                        v1 = v1 + "1";
                    }
                }
                else if (a.Key == ConsoleKey.D2)
                {
                    if (op == "")
                    {
                        v0 = v0 + "2";
                    }
                    else
                    {
                        v1 = v1 + "2";
                    }
                }
                else if (a.Key == ConsoleKey.D3)
                {
                    if (op == "")
                    {
                        v0 = v0 + "3";
                    }
                    else
                    {
                        v1 = v1 + "3";
                    }
                }
                else if (a.Key == ConsoleKey.D4)
                {
                    if (op == "")
                    {
                        v0 = v0 + "4";
                    }
                    else
                    {
                        v1 = v1 + "4";
                    }
                }
                else if (a.Key == ConsoleKey.D5)
                {
                    if (op == "")
                    {
                        v0 = v0 + "5";
                    }
                    else
                    {
                        v1 = v1 + "5";
                    }
                }
                else if (a.Key == ConsoleKey.D6)
                {
                    if (op == "")
                    {
                        v0 = v0 + "6";
                    }
                    else
                    {
                        v1 = v1 + "6";
                    }
                }
                else if (a.Key == ConsoleKey.D7)
                {
                    if (op == "")
                    {
                        v0 = v0 + "7";
                    }
                    else
                    {
                        v1 = v1 + "7";
                    }
                }
                else if (a.Key == ConsoleKey.D8)
                {
                    if (op == "")
                    {
                        v0 = v0 + "8";
                    }
                    else
                    {
                        v1 = v1 + "8";
                    }
                }
                else if (a.Key == ConsoleKey.D9)
                {
                    if (op == "")
                    {
                        v0 = v0 + "9";
                    }
                    else
                    {
                        v1 = v1 + "9";
                    }
                }
                else if (a.Key == ConsoleKey.Enter)
                {
                    if (op == "+")
                    {
                        result = Convert.ToInt32(v0) + Convert.ToInt32(v1);
                    }
                    else if (op == "-")
                    {
                        result = Convert.ToInt32(v0) - Convert.ToInt32(v1);
                    }
                    else if (op == "*")
                    {
                        result = Convert.ToInt32(v0) * Convert.ToInt32(v1);
                    }
                    else if (op == "/")
                    {
                        result = Convert.ToInt32(v0) / Convert.ToInt32(v1);
                    }
                }
            }

        }
        void notepad()
        {
            bool dalla = false;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("[type 'notepad.quit' to exit notepad.]");
            Console.WriteLine("[type 'notepad.save' to save file.]");
            var zatx = "";
            var realvalue = "";
            while (dalla == false)
            {
                var value = Console.ReadLine();
                if (value == "notepad.quit")
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    dalla = true;
                    consolegui();
                    break;
                }
                else if (value == "notepad.save")
                {
                    Console.Write(">>>");
                    var filename = Console.ReadLine();
                    try
                    {
                        fs.CreateFile(EnvPath + filename);
                        var hello_file = fs.GetFile(EnvPath + filename);
                        var hello_file_stream = hello_file.GetFileStream();

                        if (hello_file_stream.CanWrite)
                        {
                            byte[] text_to_write = Encoding.ASCII.GetBytes(realvalue);
                            hello_file_stream.Write(text_to_write, 0, text_to_write.Length);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
                else
                {
                    zatx = Console.ReadLine();
                    realvalue = realvalue + $"\n{zatx}" + value;
                }
            }
        }
        void OpenGraphicFile(Sys.FileSystem.Listing.DirectoryEntry f,Canvas canvas,Pen pen)
        {
            GUIContext g = new GUIContext(f.mName.Replace(".ges","") + " - Graphic Viewer",this);
            g.SetGUIContext(canvas);
            string line;
            try
            {
                var hstream = f.GetFileStream();

                if (hstream.CanRead)
                {
                    byte[] text_to_read = new byte[hstream.Length];
                    hstream.Read(text_to_read, 0, (int)hstream.Length);
                    line = Encoding.Default.GetString(text_to_read);
                    foreach (string s in line.Split('\n'))
                        GraphicFileInterp(s, canvas, pen);
                }
            }
            catch (Exception e)
            {
                MessageBox errorbox = new MessageBox(canvas, pen, "Error", e.ToString(), this);
                errorbox.DrawAndShow(canvas,pen,this);
            }
        }
        void OpenGraphicVideo(Sys.FileSystem.Listing.DirectoryEntry f, Canvas canvas, Pen pen,uint WaitForFrame)
        {
            GUIContext g = new GUIContext(f.mName.Replace(".lfv", "") + " - Video Player",this);
            g.SetGUIContext(canvas);
            string line;
            try
            {
                var hstream = f.GetFileStream();

                if (hstream.CanRead)
                {
                    byte[] text_to_read = new byte[hstream.Length];
                    hstream.Read(text_to_read, 0, (int)hstream.Length);
                    line = Encoding.Default.GetString(text_to_read);
                    foreach (string s in line.Split('\n'))
                    {
                        var istream = fs.GetFile(EnvPath + s).GetFileStream();

                        if (istream.CanRead)
                        {
                            byte[] to_read = new byte[istream.Length];
                            istream.Read(to_read, 0, (int)istream.Length);
                            line = Encoding.Default.GetString(to_read);
                            foreach (string LINE in line.Split('\n'))
                            {
                                GraphicFileInterp(LINE, canvas, pen);
                            }
                        }
                        if (WaitForFrame != 0) { Cosmos.HAL.Global.PIT.Wait(WaitForFrame); }
                        g.SetGUIContext(canvas);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox errorbox = new MessageBox(canvas, pen, "Error", e.ToString(), this);
                errorbox.DrawAndShow();
            }
        }
        public static string Read(Sys.FileSystem.Listing.DirectoryEntry file)
        {
            var STREAM = file.GetFileStream();
            byte[] text_to_read = new byte[STREAM.Length];
            STREAM.Read(text_to_read, 0, (int)STREAM.Length);
            return Encoding.Default.GetString(text_to_read);
        }
        void DrawGraphicFile(Sys.FileSystem.Listing.DirectoryEntry f, Canvas canvas, Pen pen)
        {
            string line;
            try
            {
                var hstream = f.GetFileStream();

                if (hstream.CanRead)
                {
                    byte[] text_to_read = new byte[hstream.Length];
                    hstream.Read(text_to_read, 0, (int)hstream.Length);
                    line = Encoding.Default.GetString(text_to_read);
                    foreach (string s in line.Split('\n'))
                        GraphicFileInterp(s, canvas, pen);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        void GraphicFileInterp(string line,Canvas canvas,Pen pen/*,GUIContext g*/)
        {
            line = line.ToLower();
            string[] arg = line.Split(' ');
            if (arg[0] == "text")
                canvas.DrawString(arg[1], PCScreenFont.Default, pen, Convert.ToInt32(arg[2]), Convert.ToInt32(arg[3]));
            else if (arg[0] == "color")
            {
                if (arg[1] == "white")
                    pen.Color = Color.White;
                else if (arg[1] == "red")
                    pen.Color = Color.Red;
                else if (arg[1] == "black")
                    pen.Color = Color.Black;
                else if (arg[1] == "blue")
                    pen.Color = Color.Blue;
                else if (arg[1] == "green")
                    pen.Color = Color.Green;
                else if (arg[1] == "lime")
                    pen.Color = Color.Lime;
                else if (arg[1] == "yellow")
                    pen.Color = Color.Yellow;
                else if (arg[1] == "orange")
                    pen.Color = Color.Orange;
                else if (arg[1] == "gray")
                    pen.Color = Color.Gray;
                else if (arg[1] == "brown")
                    pen.Color = Color.Brown;
                else if (arg[1] == "lightblue")
                    pen.Color = Color.LightBlue;
            }
            else if (arg[0] == "clear")
                canvas.Clear(pen.Color);
            else if (arg[0] == "filledcircle")
                canvas.DrawFilledCircle(pen, Convert.ToInt32(arg[1]), Convert.ToInt32(arg[2]), Convert.ToInt32(arg[3]));
            else if (arg[0] == "circle")
                canvas.DrawCircle(pen, Convert.ToInt32(arg[1]), Convert.ToInt32(arg[2]), Convert.ToInt32(arg[3]));
            else if (arg[0] == "filledrectangle")
                canvas.DrawFilledRectangle(pen, Convert.ToInt32(arg[1]), Convert.ToInt32(arg[2]), Convert.ToInt32(arg[3]), Convert.ToInt32(arg[4]));
            else if (arg[0] == "rectangle")
                canvas.DrawRectangle(pen, Convert.ToInt32(arg[1]), Convert.ToInt32(arg[2]), Convert.ToInt32(arg[3]), Convert.ToInt32(arg[4]));
            else if (arg[0] == "ellipse")
                canvas.DrawEllipse(pen, Convert.ToInt32(arg[1]), Convert.ToInt32(arg[2]), Convert.ToInt32(arg[3]), Convert.ToInt32(arg[4]));
            else if (arg[0] == "filledellipse")
                canvas.DrawFilledEllipse(pen, Convert.ToInt32(arg[1]), Convert.ToInt32(arg[2]), Convert.ToInt32(arg[3]), Convert.ToInt32(arg[4]));
            else if (arg[0] == "line")
                canvas.DrawLine(pen, Convert.ToInt32(arg[1]), Convert.ToInt32(arg[2]), Convert.ToInt32(arg[3]), Convert.ToInt32(arg[4]));
            else if (arg[0] == "wait")
                Cosmos.HAL.Global.PIT.Wait((uint)Convert.ToInt32(arg[1]));
        }
        void openfile()
        {
            Console.Write("file name: ");
            var location = Console.ReadLine();
            if (location.Contains(".cmd"))
            {
                try
                {
                    var hello_file = fs.GetFile(EnvPath + location);
                    var hello_file_stream = hello_file.GetFileStream();

                    if (hello_file_stream.CanRead)
                    {
                        byte[] text_to_read = new byte[hello_file_stream.Length];
                        hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                        var value = Encoding.Default.GetString(text_to_read);
                        if (value == "BackgroundColor = Blue")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                        }
                        else if (value == "BackgroundColor = White")
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                        }
                        else if (value == "BackgroundColor = Black")
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                        }
                        else if (value == "BackgroundColor = Red")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                        }
                        else if (value == "BackgroundColor = Yellow")
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                        }
                        else if (value == "BackgroundColor = Green")
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                        }
                        else if (value.Contains("print"))
                        {
                            var d = value.Split('"');
                            printf(d[1]);
                        }
                        else if (value.Contains("del"))
                        {
                            var d = value.Split(' ');
                            var ss = fs.GetFile($"0:\\{d[1]}");
                            fs.DeleteFile(ss);
                            printf("Deleted " + ss + ".");
                        }
                        else if (value.Contains("newfile"))
                        {
                            var d = value.Split(' ');
                            fs.CreateFile($"0:\\{d[1]}");
                            printf("Downloaded " + d[1] + ".");
                        }
                        else if (value == "shutdown")
                        {
                            Sys.Power.Shutdown();
                        }
                        else if (value == "logout")
                        {
                            ToLogin();
                        }
                        else if (value.Contains("sys."))
                        {
                            if (value.Contains("sys.rn"))
                            {
                                var dozzin = value.Split(' ');
                                var file = fs.GetFile(dozzin[1]);
                                file.SetName(dozzin[2]);
                            }
                            else
                            {
                                printf("unknown system command.");
                            }
                        }
                        else if (value == "format")
                        {
                            fs.Format(EnvPath, EnvPath, true);
                            printf("successfully formated.");
                        }
                        else if (value == "reboot")
                        {
                            Sys.Power.Reboot();
                        }
                        else
                        {
                            printf("Faild To Open file.");
                        }
                    }
                }
                catch (OutOfMemoryException out_of_memory)
                {
                    printf($"{out_of_memory}");
                }
                catch (Exception e)
                {
                    bluescreen($"{e}");
                }
            }
            else
            {
                try
                {
                    var hello_file = fs.GetFile(EnvPath + location);
                    var hello_file_stream = hello_file.GetFileStream();

                    if (hello_file_stream.CanRead)
                    {
                        byte[] text_to_read = new byte[hello_file_stream.Length];
                        hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                        Console.WriteLine(Encoding.Default.GetString(text_to_read));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        void openfile(string path,string env)
        {
            string location = path;
            if (location.Contains(".des"))
            {
                try
                {
                    var hello_file = fs.GetFile(EnvPath + $"{env}\\" + location);
                    var hello_file_stream = hello_file.GetFileStream();

                    if (hello_file_stream.CanRead)
                    {
                        byte[] text_to_read = new byte[hello_file_stream.Length];
                        hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                        var value = Encoding.Default.GetString(text_to_read);
                        if (value == "BackgroundColor = Blue")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                        }
                        else if (value == "BackgroundColor = White")
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                        }
                        else if (value == "BackgroundColor = Black")
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                        }
                        else if (value == "BackgroundColor = Red")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                        }
                        else if (value == "BackgroundColor = Yellow")
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                        }
                        else if (value == "BackgroundColor = Green")
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                        }
                        else if (value.Contains("print"))
                        {
                            var d = value.Split('"');
                            printf(d[1]);
                        }
                        else if (value.Contains("del"))
                        {
                            var d = value.Split(' ');
                            var ss = fs.GetFile($"0:\\{d[1]}");
                            fs.DeleteFile(ss);
                            printf("Deleted " + ss + ".");
                        }
                        else if (value.Contains("newfile"))
                        {
                            var d = value.Split(' ');
                            fs.CreateFile($"0:\\{d[1]}");
                            printf("Created " + d[1] + ".");
                        }
                        else if (value == "shutdown")
                        {
                            Sys.Power.Shutdown();
                        }
                        else if (value == "logout")
                        {
                            ToLogin();
                        }
                        else if (value.Contains("sys."))
                        {
                            if (value.Contains("sys.rn"))
                            {
                                var dozzin = value.Split(' ');
                                var file = fs.GetFile(dozzin[1]);
                                file.SetName(dozzin[2]);
                            }
                            else
                            {
                                printf("unknown system command.");
                            }
                        }
                        else if (value == "format")
                        {
                            fs.Format(EnvPath, EnvPath, true);
                            printf("successfully formated.");
                        }
                        else if (value == "reboot")
                        {
                            Sys.Power.Reboot();
                        }
                        else
                        {
                            printf("Faild To Open file.");
                        }
                    }
                }
                catch (OutOfMemoryException out_of_memory)
                {
                    printf($"{out_of_memory}");
                }
                catch (Exception e)
                {
                    bluescreen($"{e}");
                }
            }
            else
            {
                try
                {
                    var hello_file = fs.GetFile(EnvPath + location);
                    var hello_file_stream = hello_file.GetFileStream();

                    if (hello_file_stream.CanRead)
                    {
                        byte[] text_to_read = new byte[hello_file_stream.Length];
                        hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                        Console.WriteLine(Encoding.Default.GetString(text_to_read));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        void explorer()
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                printf("[N] New File [O] Open File [R] Rename File [D] Delete File [E] Exit");
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                viewdir();
                var a = Console.ReadKey();
                if (a.Key == ConsoleKey.N)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    newfile();
                }
                else if (a.Key == ConsoleKey.D)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    delfile();
                }
                else if (a.Key == ConsoleKey.O)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    openfile();
                }
                else if (a.Key == ConsoleKey.R)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    rnfile();
                }
                else if (a.Key == ConsoleKey.E)
                {
                    consolegui();
                    break;
                }

            }
        }
        void rnfile()
        {
            try
            {
                Console.Write("file name: ");
                var file_name = Console.ReadLine();
                Console.Write(">>>");
                var name = Console.ReadLine();
                var ss = fs.GetFile(EnvPath + file_name);
                ss.SetName(name);
                Console.WriteLine("Renamed to " + name + ".");
            }
            catch (Exception an)
            {
                printf($"{an}");
            }
        }

        void newfile()
        {
            Console.Write("file name: ");
            var file_name = Console.ReadLine();
            try
            {
                fs.CreateFile(EnvPath + file_name);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine($"created file '{file_name}'.");
        }
        void delfile()
        {
            Console.Write("file name: ");
            var file_name = Console.ReadLine();
            try
            {
                var d = fs.GetFile(EnvPath + file_name);
                fs.DeleteFile(d);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine($"Deleted file '{file_name}'.");
        }
        void viewdir()
        {
            var directory_list = fs.GetDirectoryListing("0:/");
            long available_space = fs.GetAvailableFreeSpace("0:/");
            foreach (var directoryEntry in directory_list)
            {
                if (directoryEntry.mName.Contains(".cmd") && setting1 == true)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("         ");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("         \n         \n         ");

                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("         ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(directoryEntry.mName);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (directoryEntry.mName.Contains(".txt") || directoryEntry.mName.Contains(".wrt"))
                {
                    if (setting1 == true)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("     \n     \n     \n     ");

                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(directoryEntry.mName);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("         ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(directoryEntry.mName);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(directoryEntry.mName);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;

            }

        }
        void noselect()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
        }
        void select()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        void areyoulog()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            int sel = 0;
            while (true)
            {
                Console.Clear();
                if (sel == 0)
                {
                    printf("           Accounts           ");
                    printf("\nAre You Want Create Account?\n* Create Account    \n\n  Don't Create Account");
                }
                else if (sel == 1)
                {
                    printf("           Accounts           ");
                    printf("\nAre You Want Create Account?\n  Create Account    \n\n* Don't Create Account");
                }

                var a = Console.ReadKey();
                if (a.Key == ConsoleKey.UpArrow && sel > 0)
                {
                    sel--;
                }
                else if (a.Key == ConsoleKey.DownArrow && sel < 1)
                {
                    sel++;
                }
                else if (a.Key == ConsoleKey.Enter && sel == 0)
                {
                    try
                    {
                        var hello_file = fs.GetFile(@"0:\logaccount.hdn");
                        var hello_file_stream = hello_file.GetFileStream();

                        if (hello_file_stream.CanWrite)
                        {
                            byte[] text_to_write = Encoding.ASCII.GetBytes("true");
                            hello_file_stream.Write(text_to_write, 0, text_to_write.Length);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                }
                else if (a.Key == ConsoleKey.Enter && sel == 1)
                {
                    try
                    {
                        var hello_file = fs.GetFile(@"0:\logaccount.hdn");
                        var hello_file_stream = hello_file.GetFileStream();

                        if (hello_file_stream.CanWrite)
                        {
                            byte[] text_to_write = Encoding.ASCII.GetBytes("false");
                            hello_file_stream.Write(text_to_write, 0, text_to_write.Length);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        void ToLogin()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            printf("     Login To ToRunOS     ");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                var hello_file_id = fs.GetFile(@"0:\userid.txt");
                var hello_file_pass = fs.GetFile(@"0:\userpass.txt");
                var hello_file_stream = hello_file_id.GetFileStream();
                var pass_file_stream = hello_file_pass.GetFileStream();

                if (hello_file_stream.CanRead && pass_file_stream.CanRead)
                {
                    byte[] text_to_read = new byte[hello_file_stream.Length];
                    hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                    var id = Encoding.Default.GetString(text_to_read);
                    byte[] text_to_read2 = new byte[pass_file_stream.Length];
                    pass_file_stream.Read(text_to_read2, 0, (int)pass_file_stream.Length);
                    var pass_ = Encoding.Default.GetString(text_to_read2);
                    Console.Write("Name>");
                    var username = Console.ReadLine();
                    Console.Write("Password>");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    var userpass = Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    if (username == id && userpass == pass_)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        printf($"successfully logged on {username}");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    else if (username == "adminstrator" && userpass == pass_)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        printf($"successfully logged on {username}");
                        Console.ForegroundColor = ConsoleColor.White;
                        adstrator = true;
                        break;
                    }
                    else if (username == "Adminstrator" && userpass == pass_)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        printf($"successfully logged on {username}");
                        Console.ForegroundColor = ConsoleColor.White;
                        adstrator = true;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        printf("Wrong username or password!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
            }
        }
    }
    class MessageBox
    {
        public bool clicked = false;
        public Canvas canvas;
        public Pen pen;
        public string title;
        public Theme theme;
        public string text;
        public Color UIColor = Theme.Default.MsgBoxUIColor;
        public Color BGColor = Theme.Default.MsgBoxBGColor;
        public bool yesno_result;
        public bool IsYesNo;
        public bool drawed = false;
        public MessageBox(Canvas canvas, Pen pen, string title, string text,bool isYesNo,Kernel k)
        {
            if (!k.setup)
            {
                if (Kernel.Read(k.fs.GetFile(@"0:\Settings\theme.bool")) == "true")
                    theme = Theme.Default;
                else
                    theme = Theme.Classic;
            }
            this.UIColor = theme.MsgBoxUIColor;
            this.BGColor = theme.MsgBoxBGColor;
            this.IsYesNo = isYesNo;
            this.canvas = canvas;
            this.pen = pen;
            this.text = text;
            this.title = title;
        }
        public MessageBox(Canvas canvas, Pen pen, string title, string text ,Kernel k)
        {
            if (!k.setup)
            {
                if (Kernel.Read(k.fs.GetFile(@"0:\Settings\theme.bool")) == "true")
                    theme = Theme.Default;
                else
                    theme = Theme.Classic;
            }
            this.UIColor = theme.MsgBoxUIColor;
            this.BGColor = theme.MsgBoxBGColor;
            this.canvas = canvas;
            this.pen = pen;
            this.text = text;
            this.title = title;
        }
        public void DrawAndShow(Canvas canvas,Pen pen,Kernel k)
        {
            this.Draw();
            this.WaitForClick(canvas,pen,k);
        }
        public void WaitForClick(Canvas canvas,Pen pen,Kernel k)
        {
            while (!clicked)
            {
                Sys.MouseManager.ScreenWidth = (uint)canvas.Mode.Columns;
                Sys.MouseManager.ScreenHeight = (uint)canvas.Mode.Rows;
                int X = (int)Sys.MouseManager.X;
                int Y = (int)Sys.MouseManager.Y;
                canvas.DrawLine(pen, X, Y, X + 5, Y);
                canvas.DrawLine(pen, X, Y, X, Y - 5);
                if (X > 600 && X < 700 && Y > 580 && Y < 640 && !clicked && drawed && Sys.MouseManager.MouseState == Sys.MouseState.Left && !IsYesNo)
                {
                    clicked = true;
                    GUIContext.isInContext = false;
                    k.DefaultDraw(canvas, pen);
                    return;
                }
                else if (X > 500 && X < 600 && Y > 580 && Y < 640 && !clicked && drawed && Sys.MouseManager.MouseState == Sys.MouseState.Left && IsYesNo)
                {
                    clicked = true;
                    yesno_result = true;
                    GUIContext.isInContext = false;
                    k.DefaultDraw(canvas, pen);
                    return;
                }
                else if (X > 650 && X < 750 && Y > 580 && Y < 640 && !clicked && drawed && Sys.MouseManager.MouseState == Sys.MouseState.Left && IsYesNo)
                {
                    clicked = true;
                    yesno_result = false;
                    GUIContext.isInContext = false;
                    k.DefaultDraw(canvas, pen);
                    return;
                }
            }
        }
        public void Draw()
        {
            if (!IsYesNo)
            {
                clicked = false;
                drawed = true;
                pen.Color = theme.MsgBoxUIColor;
                canvas.DrawFilledRectangle(pen, 500, 450, 300, 50); //UI
                pen.Color = Color.Black;
                canvas.DrawRectangle(pen, 500, 450, 300, 50);
                pen.Color = theme.MsgBoxBGColor;
                canvas.DrawFilledRectangle(pen, 600, 570, 100, 50);
                canvas.DrawFilledRectangle(pen, 500, 500, 300, 150);
                pen.Color = Color.Black;
                canvas.DrawRectangle(pen, 500, 500, 300, 150);
                pen.Color = Color.White;
                canvas.DrawString(title, PCScreenFont.Default, pen, 600, 465);
                pen.Color = Color.Black;
                int TY = 510;
                foreach (string t in text.Split('\n'))
                {
                    canvas.DrawString(t, PCScreenFont.Default, pen, 570, TY);
                    TY += 30;
                }
                canvas.DrawString("OK", PCScreenFont.Default, pen, 640, 580);
                canvas.DrawRectangle(pen, 600, 570, 100, 50);
                pen.Color = Color.Red;
                canvas.DrawFilledCircle(pen, 560, 570, 30);
                pen.Color = Color.DarkRed;
                canvas.DrawCircle(pen, 560, 570, 30);
                pen.Color = Color.White;
                canvas.DrawLine(pen,540,555,575,590);
                canvas.DrawLine(pen, 578, 554, 543, 589);
                pen.Color = Color.Black;
            }
            else
            {
                clicked = false;
                drawed = true;
                pen.Color = theme.MsgBoxUIColor;
                canvas.DrawFilledRectangle(pen, 500, 450, 300, 50);
                pen.Color = Color.Black;
                canvas.DrawRectangle(pen, 500, 450, 300, 50);
                pen.Color = theme.MsgBoxBGColor;
                canvas.DrawFilledRectangle(pen, 680, 570, 100, 50);
                canvas.DrawFilledRectangle(pen, 500, 570, 100, 50);
                canvas.DrawFilledRectangle(pen, 500, 500, 300, 150);
                canvas.DrawFilledRectangle(pen, 520, 570, 100, 50);
                pen.Color = Color.Black;
                canvas.DrawRectangle(pen, 500, 500, 300, 150);
                pen.Color = Color.White;
                canvas.DrawString(title, PCScreenFont.Default, pen, 600, 465);
                pen.Color = Color.Black;
                int TY = 510;
                foreach (string t in text.Split('\n'))
                {
                    canvas.DrawString(t, PCScreenFont.Default, pen, 570, TY);
                    TY += 30;
                }
                canvas.DrawString("YES", PCScreenFont.Default, pen, 550, 580);
                canvas.DrawString("NO", PCScreenFont.Default, pen, 720, 580);
                canvas.DrawRectangle(pen, 520, 570, 100, 50);
                canvas.DrawRectangle(pen, 680, 570, 100, 50);
                pen.Color = Color.Black;
                //canvas.DrawFilledCircle(pen, 560, 570, 30);
            }
        }
        public void Refresh(Canvas canvas,Pen pen,Kernel k,int X,int Y)
        {
            if (X > 600 && X < 700 && Y > 580 && Y < 640 && !clicked && drawed && Sys.MouseManager.MouseState == Sys.MouseState.Left && !IsYesNo)
            {
                clicked = true;
                GUIContext.isInContext = false;
                k.DefaultDraw(canvas, pen);
                return;
            }
            else if (X > 500 && X < 600 && Y > 580 && Y < 640 && !clicked && drawed && Sys.MouseManager.MouseState == Sys.MouseState.Left && IsYesNo)
            {
                clicked = true;
                yesno_result = true;
                GUIContext.isInContext = false;
                k.DefaultDraw(canvas, pen);
                return;
            }
            else if (X > 650 && X < 750 && Y > 580 && Y < 640 && !clicked && drawed && Sys.MouseManager.MouseState == Sys.MouseState.Left && IsYesNo)
            {
                clicked = true;
                yesno_result = false;
                GUIContext.isInContext = false;
                k.DefaultDraw(canvas, pen);
                return;
            }
        }
    }
    class WarnMessageBox : MessageBox
    {
        public WarnMessageBox(Canvas canvas, Pen pen, string title, string text, bool isYesNo,Kernel k) : base(canvas, pen, title, text, isYesNo,k)
        {
            this.canvas = canvas;
            this.pen = pen;
            this.title = title;
            this.IsYesNo = isYesNo;
            this.text = text;
        }
        public WarnMessageBox(Canvas canvas, Pen pen, string title, string text,Kernel k) : base(canvas, pen, title, text,k)
        {
            this.canvas = canvas;
            this.pen = pen;
            this.title = title;
            this.text = text;
        }
        new public void Draw()
        {
            Console.Beep(40,200);
            if (!IsYesNo)
            {
                clicked = false;
                drawed = true;
                pen.Color = base.theme.MsgBoxUIColor;
                canvas.DrawFilledRectangle(pen, 500, 450, 300, 50); //UI
                pen.Color = Color.Black;
                canvas.DrawRectangle(pen, 500, 450, 300, 50);
                pen.Color = base.theme.MsgBoxBGColor;
                canvas.DrawFilledRectangle(pen, 600, 570, 100, 50);
                canvas.DrawFilledRectangle(pen, 500, 500, 300, 150);
                pen.Color = Color.Black;
                canvas.DrawRectangle(pen, 500, 500, 300, 150);
                pen.Color = Color.White;
                canvas.DrawString(title, PCScreenFont.Default, pen, 600, 465);
                pen.Color = Color.Black;
                int TY = 510;
                foreach (string t in text.Split('\n'))
                {
                    canvas.DrawString(t, PCScreenFont.Default, pen, 570, TY);
                    TY += 30;
                }
                canvas.DrawString("OK", PCScreenFont.Default, pen, 640, 580);
                canvas.DrawRectangle(pen, 600, 570, 100, 50);
                pen.Color = Color.Goldenrod;
                canvas.DrawFilledCircle(pen, 560, 570, 30);
                pen.Color = Color.DarkGoldenrod;
                canvas.DrawCircle(pen, 560, 570, 30);
                pen.Color = Color.Black;
                canvas.DrawFilledRectangle(pen, 557, 545, 10, 38);
                canvas.DrawFilledRectangle(pen, 557, 590, 10, 8);
            }
            else
            {
                clicked = false;
                drawed = true;
                pen.Color = base.theme.MsgBoxUIColor;
                canvas.DrawFilledRectangle(pen, 500, 450, 300, 50);
                pen.Color = Color.Black;
                canvas.DrawRectangle(pen, 500, 450, 300, 50);
                pen.Color = base.theme.MsgBoxBGColor;
                canvas.DrawFilledRectangle(pen, 680, 570, 100, 50);
                canvas.DrawFilledRectangle(pen, 500, 570, 100, 50);
                canvas.DrawFilledRectangle(pen, 500, 500, 300, 150);
                canvas.DrawFilledRectangle(pen, 520, 570, 100, 50);
                pen.Color = Color.Black;
                canvas.DrawRectangle(pen, 500, 500, 300, 150);
                pen.Color = Color.White;
                canvas.DrawString(title, PCScreenFont.Default, pen, 600, 465);
                pen.Color = Color.Black;
                int TY = 510;
                foreach (string t in text.Split('\n'))
                {
                    canvas.DrawString(t, PCScreenFont.Default, pen, 570, TY);
                    TY += 30;
                }
                canvas.DrawString("YES", PCScreenFont.Default, pen, 550, 580);
                canvas.DrawString("NO", PCScreenFont.Default, pen, 720, 580);
                canvas.DrawRectangle(pen, 520, 570, 100, 50);
                canvas.DrawRectangle(pen, 680, 570, 100, 50);
                pen.Color = Color.Goldenrod;
                canvas.DrawFilledCircle(pen, 560, 570, 30);
                pen.Color = Color.DarkGoldenrod;
                canvas.DrawCircle(pen, 560, 570, 30);
                pen.Color = Color.Black;
                canvas.DrawFilledRectangle(pen, 557, 545, 10, 38);
                canvas.DrawFilledRectangle(pen, 557, 590, 10, 8);
                //canvas.DrawFilledCircle(pen, 560, 570, 30);
            }
        }
    }
    class TextMessageBox : MessageBox
    {
        public string inputtext = "";
        public Sys.KeyEvent LastKey;
        public TextMessageBox(Canvas canvas, Pen pen, string title, string text, bool isYesNo,Kernel k) : base(canvas, pen, title, text, isYesNo,k)
        {
            this.canvas = canvas;
            this.pen = pen;
            this.title = title;
            this.IsYesNo = isYesNo;
            this.text = text;
        }
        public TextMessageBox(Canvas canvas, Pen pen, string title, string text,Kernel k) : base(canvas, pen, title, text,k)
        {
            this.canvas = canvas;
            this.pen = pen;
            this.title = title;
            this.text = text;
        }
        public void Draw(Kernel k)
        {
            clicked = false;
            drawed = true;
            pen.Color = base.theme.MsgBoxUIColor;
            canvas.DrawFilledRectangle(pen, 500, 450, 300, 50); //UI
            pen.Color = Color.Black;
            canvas.DrawRectangle(pen, 500, 450, 300, 50);
            pen.Color = base.theme.MsgBoxBGColor;
            canvas.DrawFilledRectangle(pen, 600, 570, 100, 50);
            canvas.DrawFilledRectangle(pen, 500, 500, 300, 150);
            pen.Color = Color.Black;
            canvas.DrawRectangle(pen, 500, 500, 300, 150);
            canvas.DrawRectangle(pen, 545, 600, 200, 30);
            pen.Color = Color.White;
            canvas.DrawString(title, PCScreenFont.Default, pen, 600, 465);
            pen.Color = Color.Black;
            int TY = 510;
            foreach (string t in text.Split('\n'))
            {
                canvas.DrawString(t, PCScreenFont.Default, pen, 570, TY);
                TY += 30;
            }
            pen.Color = Color.Black;
            while (true)
            {
                LastKey = Sys.KeyboardManager.ReadKey();
                if (LastKey.Key == Sys.ConsoleKeyEx.Enter)
                {
                    clicked = true;
                    GUIContext.isInContext = false;
                    k.DefaultDraw(canvas, pen);
                    return;
                    
                }
                else
                {
                    inputtext += LastKey.KeyChar;
                    canvas.DrawString(inputtext, PCScreenFont.Default, pen, 550, 607);
                }
            }
        }
    }
    class Theme
    {
        public Color BGColor;
        public Color UIColor;
        public Color MsgBoxUIColor;
        public Color MsgBoxBGColor;
        public Theme(Color BG,Color UI,Color MsgUI,Color MsgBG)
        {
            this.BGColor = BG; this.UIColor = UI; this.MsgBoxBGColor = MsgBG; this.MsgBoxUIColor = MsgUI;
        }
        public static Theme Default 
        {
            get
            {
                return new Theme(Color.White,Color.Lime,Color.SlateBlue,Color.White);
            }
        }
        public static Theme Classic
        {
            get
            {
                return new Theme(Color.LightGray, Color.Blue, Color.Blue, Color.LightGray);
            }
        }
    }
}
