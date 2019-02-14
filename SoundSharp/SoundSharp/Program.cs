using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp
{
    class Program
    {
        //make struct MP3 for storage of MP3 players
        public struct MP3
        {
            public int id;
            public string brand;
            public string model;
            public int storageSpace;
            public double price;
            public int stock;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("please enter your name here");
            //read name
            var name = Console.ReadLine();
            //read password
            Console.WriteLine("now please enter your password");
            var inputPassword = Console.ReadLine();

            //check if password matches and display correct response
            string IsOk = Login(inputPassword);
            switch (IsOk)
            {
                case "OK":
                    Console.WriteLine("Welcome to soundsharp {0}", name);
                    ShowMenu();
                    break;

                case "NotOK":
                    Console.WriteLine("password incorrect");
                    break;

                default:
                    Console.WriteLine("error: no valid output. please try again");
                    break;
            }
        }
        public static string Login(string input)
        {
            //set constants for the maximum tries and the password
            const string PASSWORD = "SHARPSOUND";
            const int MaxTries = 3;

            //set some extra variables
            var x = 1;
            var returnValue = "NotOK";

            do
            {
                //check if imput matches password
                if (input == PASSWORD)
                {
                    //if password matches, break out of the loop and approve password
                    returnValue = "OK";
                    break;
                }
                else
                {
                    //if password does not match, repeat circle till max amount of tries has been reached
                    x++;
                    Console.WriteLine("wachtwoord fout try " + x + " out of 3");

                    if (x == 3)
                    {
                        Console.WriteLine("LET OP! laatste poging");
                    }

                    input = Console.ReadLine();

                    //extra check if password is right
                    if (input == PASSWORD)
                    {
                        returnValue = "Juist";
                        break;
                    }
                }

            } while (x != MaxTries);
            return returnValue;
        }
        public static void ShowMenu()
        {
            //menu to show options
            ShowOptionMenu();

            //get all MP3 players
            ArrayList mp3Array = CreateStruct();

            //loop for key imput for available options
            while (true)
            {
                char keyChar = Console.ReadKey(true).KeyChar;

                if ((int)keyChar == 57)
                {
                    //9 button pressed, exit loop and program
                    break;
                }
                else if ((int)keyChar == 56)
                {
                    //8 button pressed, show menu again
                    ShowOptionMenu();
                }
                else if ((int)keyChar == 49)
                {
                    //1 button pressed, show all MP3 players by looping through them
                    foreach (MP3 i in mp3Array)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(i.id);
                        Console.WriteLine(i.brand);
                        Console.WriteLine(i.model);
                        Console.WriteLine(i.storageSpace);
                        Console.WriteLine(i.price);
                    }
                }
                else if ((int)keyChar == 50)
                {
                    //2 button pressed, show available stock by looping through all of them
                    foreach (MP3 i in mp3Array)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(i.id);
                        Console.WriteLine(i.stock);
                    }
                }
                else if ((int)keyChar == 51)
                {
                    //3 button pressed, mutate stock
                    MutateStruct(mp3Array);
                }
            }
            Console.WriteLine("press any key to close the program");
            Console.ReadKey();
        }
        public static void ShowOptionMenu()
        {
            //write all available options
            Console.WriteLine("1: Overview MP3 players");
            Console.WriteLine("2: Show available stock");
            Console.WriteLine("3: Muteer stock");
            Console.WriteLine("4: test");
            Console.WriteLine("5: test");
            Console.WriteLine("6: test");
            Console.WriteLine("7: test");
            Console.WriteLine("8: Show Menu");
            Console.WriteLine("9: exit");
        }
        public static void MutateStruct(ArrayList mp3Array)
        {
            Console.WriteLine("Please input the ID of which MP3 player you want to change the stock");
            try
            {
                int inputID = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < mp3Array.Count; i++)
                {
                    if (inputID == ((MP3)mp3Array[i]).id)
                    {
                        MP3 selectedMP3 = ((MP3)mp3Array[i]);

                        Console.WriteLine("Model: {0} {1} selected, how many are left in stock?", selectedMP3.brand, selectedMP3.model);
                        int inputStock = Convert.ToInt32(Console.ReadLine());

                        if (inputStock >= 0)
                        {
                            //mp3Array.
                            //mp3Array.RemoveAt(4);
                          //  mp3Array.Add(inputStock);
                            selectedMP3.stock = inputStock;

                            foreach (MP3 y in mp3Array)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(y.id);
                                Console.WriteLine(y.stock);
                            }

                        } else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: please enter a value greater then 0");
                            Console.ResetColor();
                        }
                    }

                }

            } catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: please enter a number");
                Console.ResetColor();
            }
        }
        public static ArrayList CreateStruct()
        {
            //make mp3 players and put them in Array list
            MP3 first = new MP3
            {
                id = 1,
                brand = "GET technologies.inc",
                model = "HF 410",
                storageSpace = 4096,
                price = 129.95,
                stock = 500
            };

            MP3 second = new MP3
            {
                id = 2,
                brand = "Far & Loud",
                model = "XM 600",
                storageSpace = 8192,
                price = 224.95,
                stock = 0,
            };

            MP3 third = new MP3
            {
                id = 3,
                brand = "Innotivative",
                model = "Z3",
                storageSpace = 4096,
                price = 124.95,
                stock = 500
            };

            MP3 fourth = new MP3
            {
                id = 4,
                brand = "Resistance S.A.",
                model = "3001",
                storageSpace = 4096,
                price = 124.95,
                stock = 500
            };

            MP3 fifthMP3 = new MP3
            {
                id = 5,
                brand = "CBA",
                model = "NXT volume",
                storageSpace = 2048,
                price = 159.05,
                stock = 500
            };

            ArrayList mp3Array = new ArrayList();

            mp3Array.Add(first);
            mp3Array.Add(second);
            mp3Array.Add(third);
            mp3Array.Add(fourth);
            mp3Array.Add(fifthMP3);

            return mp3Array;
        }
    }
}
