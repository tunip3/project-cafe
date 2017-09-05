using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Project_cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up loop to allow repeated multiple downloads
            while (1 == 1)
            {

                //Create C:/Users/Public/homebrew directory if it doesn't already exist
                //System.IO.Directory.CreateDirectory(@"c:\Users\Public\homebrew");

                // Setting up the design of the Console Interface
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________                          ");
                Console.WriteLine("|                                               |                         ");
                Console.WriteLine("|Project cafe - The wiiu guide download assitant|                         ");
                Console.WriteLine("|_______________________________________________|                         ");
                Console.WriteLine("                                                                          ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" # Note: all homebrew is automatically put on the sd");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("                                                                          ");
                Console.WriteLine(" ---------------------------------------                                    ");
                Console.WriteLine("|                                       |");
                Console.WriteLine("|    [wiiu tools for using homebrew]    |");
                Console.WriteLine("|1.hbl         launch homebrew          |");
                Console.WriteLine("|2.hbas        download homebrew to wiiu|");
                Console.WriteLine("|                                       |");
                Console.WriteLine("|    [      custom firmware        ]    |");
                Console.WriteLine("|3.mocha cfw   the most advanced cfw    |");
                Console.WriteLine("|                                       |");
                Console.WriteLine("|    [      haxchi tools           ]    |");
                Console.WriteLine("|                                       |");
                Console.WriteLine("|4.haxchi   boot hbl from the home menu |");
                Console.WriteLine("|5.cbhc     auto boot cfw do not use -  |");
                Console.WriteLine("| unless you are using a gbatemp guide  |");
                Console.WriteLine("|                                       |");
                Console.WriteLine(" ---------------------------------------");



                // Converting user selection from string to int for the switch block
                string menuChoice_string = Console.ReadLine();
                int menuChoice = Convert.ToInt32(menuChoice_string);




                // Setting uo switch block to handle user selections
                switch (menuChoice)
                {


                    // Using the WebClient Class to connect to the server and download the file to the specified path
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading the hbl Please Wait....");
                        WebClient Client = new WebClient();
                        System.IO.Directory.CreateDirectory(@"F:\wiiu\apps\homebrew_launcher");
                        Client.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/homebrew_launcher.elf", @"F:\wiiu\apps\homebrew_launcher\homebrew_launcher.elf");
                        Client.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/icon.png", @"F:\wiiu\apps\homebrew_launcher\icon.png");
                        Client.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/meta.xml", @"F:\wiiu\apps\homebrew_launcher\meta.xml");
                        Console.WriteLine("Succesfully Downloaded..... Press Enter to Download something else :-)");
                        Console.ResetColor();
                        break;




                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading hbas Please Wait....");
                        WebClient Client2 = new WebClient();
                        System.IO.Directory.CreateDirectory(@"F:\wiiu\apps\appstore");
                        Client2.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/appstore/hbas.elf", @"F:\wiiu\apps\appstore\hbas.elf");
                        Client2.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/appstore/icon.png", @"F:\wiiu\apps\appstore\icon.png");
                        Client2.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/appstore/meta.xml", @"F:\wiiu\apps\appstore\meta.xml");
                        Console.WriteLine("Succesfully Downloaded..... Press Enter to Download something else :-)");
                        Console.ResetColor();
                        break;



                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading mocha please wait");
                        WebClient Client3 = new WebClient();
                        System.IO.Directory.CreateDirectory(@"F:\wiiu\apps\mocha");
                        Client3.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/mocha/mocha.elf", @"F:\wiiu\apps\mocha\mocha.elf");
                        Client3.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/mocha/icon.png", @"F:\wiiu\apps\mocha\icon.png");
                        Client3.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/mocha/meta.xml", @"F:\wiiu\apps\mocha\meta.xml");
                        Console.WriteLine("Succesfully Downloaded..... Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading haxchi Please Wait");
                        WebClient Client4 = new WebClient();
                        System.IO.Directory.CreateDirectory(@"F:\wiiu\apps\haxchi");
                        System.IO.Directory.CreateDirectory(@"F:\haxchi");
                        Client4.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/haxchi/haxchi.elf", @"F:\wiiu\apps\haxchi\haxchi.elf");
                        Client4.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/haxchi/icon.png", @"F:\wiiu\apps\haxchi\icon.png");
                        Client4.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/haxchi/meta.xml", @"F:\wiiu\apps\haxchi\meta.xml");
                        Client4.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/haxchi/title.txt", @"F:\haxchi\title.text");
                        Client4.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/haxchi/iconTex.tga", @"F:\haxchi\iconTex.tga");
                        Client4.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/haxchi/config.txt", @"F:\haxchi\config.txt");
                        Client4.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/haxchi/bootTvTex.tga", @"F:\haxchi\bootTvTex.tga");
                        Client4.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/haxchi/bootDrcTex.tga", @"F:\haxchi\bootDrcTex.tga");
                        Console.WriteLine("Succesfully Downloaded..... Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading cbhc Please Wait....");
                        WebClient Client5 = new WebClient();
                        System.IO.Directory.CreateDirectory(@"F:\wiiu\apps\cbhc");
                        System.IO.Directory.CreateDirectory(@"F:\cbhc");
                        Client5.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/cbhc/cbhc.elf", @"F:\wiiu\apps\cbhc\cbhc.elf");
                        Client5.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/cbhc/icon.png", @"F:\wiiu\apps\cbhc\icon.png");
                        Client5.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/cbhc/meta.xml", @"F:\wiiu\apps\cbhc\meta.xml");
                        Client5.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/cbhc/title.txt", @"F:\cbhc\title.text");
                        Client5.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/cbhc/iconTex.tga", @"F:\cbhc\iconTex.tga");
                        Client5.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/cbhc/bootTvTex.tga", @"F:\cbhc\bootTvTex.tga");
                        Client5.DownloadFile("https://raw.githubusercontent.com/tunip3/project-cafe/hbapps/data/cbhc/bootDrcTex.tga", @"F:\cbhc\bootDrcTex.tga");
                        Console.WriteLine("Succesfully Downloaded..... Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;





                    // Throws an Exception if the user pressed an invalid option
                    default:
                        Console.WriteLine("Exception! Invalid Input Try Again");
                        break;




                }

                Console.ReadLine();
            }
        }
    }
}

