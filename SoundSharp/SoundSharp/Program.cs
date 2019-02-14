using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp
{
    class Program
    {
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
                Console.WriteLine("Wat is je naam ?");
                string name = Console.ReadLine();
                Login(name);
            }
            public static string Login(string name)
        {
            int loginAttempts = 0;
            int poging = 1;

            for (int i = 0; i < 3; i++)
            {
                if (poging == 3)
                {
                    Console.WriteLine("LET OP: Laatste poging!");
                }
                Console.WriteLine("Poging " + poging + " van 3");
                Console.WriteLine("Wachtwoord invoeren");
                string PassWord = Console.ReadLine();

                if (PassWord != "SHARPSOUND")
                {
                    loginAttempts++;
                    poging++;
                }
                else
                {
                    break;
                }
            }

            //Display the result
            if (loginAttempts > 2)
            {
                Console.WriteLine("Wachtwoord " + Wachtwoord.onjuist);
            }
            else
            {
                Console.WriteLine(Wachtwoord.juist + ", Welkom bij SoundSharp " + name);
                ShowMenu();
            }
            return Console.ReadLine();
        }
        enum Wachtwoord
        {
            juist = 0,
            onjuist = 1,
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
                else if((int)keyChar == 52)
                {
                    ShowStatistics(mp3Array);
                }
                else if ((int)keyChar == 53)
                {
                    //5 button is pressed. add mp3
                    //make new unique ID
                    int newMP3Id = mp3Array.Count + 1;

                    //get Brand name
                    Console.WriteLine("Please enter the brand name of the MP3 player.");
                    string newMP3Brand = Console.ReadLine();

                    //get Model name
                    Console.WriteLine("Please enter the Model name.");
                    string newMP3Model = Console.ReadLine();

                    //get storage amount
                    int newMP3Storage;
                    try
                    {
                        Console.WriteLine("Please enter the amount of storage in MB");
                        newMP3Storage = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("please enter a number.");
                        Console.ResetColor();
                        return;
                    }
                    //get price
                    double newMP3Price;
                    try
                    {
                        Console.WriteLine("Please enter the price, including two decimals. even if i would be ,00");
                        newMP3Price = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("please enter a number.");
                        Console.ResetColor();
                        return;
                    }

                    //set Stock amount
                    int newMP3Stock = 0;

                    //make a new MP3 and add it to the ArrayList
                    MP3 newMP3 = new MP3
                    {
                        id = newMP3Id,
                        brand = newMP3Brand,
                        model = newMP3Model,
                        storageSpace = newMP3Storage,
                        price = newMP3Price,
                        stock = newMP3Stock
                    };

                    mp3Array.Add(newMP3);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MP3 player added");
                    Console.ResetColor();

                }
                else if ((int)keyChar == 56)
                {
                    Console.Clear();
                    //8 button pressed, show menu again
                    ShowOptionMenu();
                }
                else if ((int)keyChar == 49)
                {
                    Console.Clear();
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
                    Console.WriteLine("");
                    Console.WriteLine("Press 8 to return back to the menu.");
                    Console.WriteLine("Press 9 to exit the console.");
                }
                else if ((int)keyChar == 50)
                {
                    Console.Clear();
                    //2 button pressed, show available stock by looping through all of them
                    foreach (MP3 i in mp3Array)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(i.id);
                        Console.WriteLine(i.stock);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Press 8 to return back to the menu.");
                    Console.WriteLine("Press 9 to exit the console.");
                }
                else if ((int)keyChar == 51)
                {
                    Console.Clear();
                    //3 button pressed, mutate stock
                    MutateStruct(mp3Array);
                    Console.WriteLine("");
                    Console.WriteLine("Press 8 to return back to the menu.");
                    Console.WriteLine("Press 9 to exit the console.");
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
            Console.WriteLine("5: Toevoegen MP3");
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
                            Console.WriteLine("De stock inhoud van {1} {2} is aangepast naar: {0}", inputStock, selectedMP3.brand, selectedMP3.model);



                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: please enter a value greater then 0");
                            Console.ResetColor();
                        }
                    }

                }

            }
            catch
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
                stock = 500
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

        public static void ShowStatistics(ArrayList mp3Array)
        {

            int totalStock = 0;
            double totalValue = 0;
            ArrayList ppmb = new ArrayList();

            foreach (MP3 i in mp3Array)
            {
                totalStock += i.stock;

                totalValue += i.price * i.stock;
            }

            //calculate average price per MP3 player
            double averagePrice = totalValue / totalStock;

            Console.WriteLine("Total stock: {0}", totalStock);
            Console.WriteLine("Total value of all stock: {0}EUR", totalValue);
        }
    }
}
