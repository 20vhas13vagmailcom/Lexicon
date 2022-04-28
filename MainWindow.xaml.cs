using System;
using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;


namespace WpfApp_uppgifter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    class Character
    {
        public Character(string name)
        {
            Random rnd = new Random();
            Name = name;
            Health = rnd.Next(1, 11);
            Strength = rnd.Next(1, 11);
            Luck = rnd.Next(1, 11);
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"--------- {Name} ------------");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Luck: {Luck}");
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {


            //Uppg 1
            static void Greeting()
            {
                Console.WriteLine("Hello World");
            }
            //slut uppg 1

            //Uppg 2
            static void Person()
            {
                String name;
                String lastname;
                int age;

                Console.WriteLine("Skriv ditt namn ");
                name = Console.ReadLine();
                Console.WriteLine("Skriv ditt efterrnamn ");
                lastname = Console.ReadLine();
                Console.WriteLine("Skriv din ålder ");
                age = int.Parse(Console.ReadLine());
                //age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ditt namn:  " + name + "  Ditt efternamn:  " + lastname + "  Din ålder:  " + age);
            }
            //slut uppg 2

            //Uppg 3
            static void ColorsSwitch()
            {

                if (Console.ForegroundColor == ConsoleColor.Red)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Text med vitt färg");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Text med rött färg");
                }
            }
            //Sedan kan man från Main metoden anropa ColorsSwitch() 7 ggr.i en loop, med:
            for (int i = 0; i < 7; i++)
            {
                ColorsSwitch();
            }
            // Slut Uppg3


            //Uppg 4
            static void datum()
            {
                Console.WriteLine(DateTime.Today);
            }
            // Slut Uppg4



            //Uppg 5
            static void maximus()
            {
                //double val1 = 15.896745, val2 = 25.676843;
                int tal1;
                int tal2;
                Console.Write("Skriv ett tal ");
                tal1 = int.Parse(Console.ReadLine());
                Console.Write("Skriv ett tal ");
                tal2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Maximum Value from two int values = " + Math.Max(tal1, tal2));
            }
            // Slut Uppg5



            // Uppgift 6
            static void Slump()
            {
                Random rnd = new Random();
                int slumptal;
                int tal;

                slumptal = (rnd.Next(1, 101));

                Console.Write("Skriv ett tal ");
                tal = int.Parse(Console.ReadLine());
                int antal_ggr = 1;

                while (tal != slumptal)
                {

                    antal_ggr++;
                    Console.Write("Fel, försök igen och skriv ett tal: ");
                    tal = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Rätt tal! " + slumptal);
                Console.WriteLine("Antal gissningar =  " + antal_ggr);

            }
            //Slut Uppg 6


            //Uppg 7 och 8

            //WriteStringToFile();
            //Console.Read();
            //ReadFromFile();
            //Console.Read();

            AddNumbersFromString();
            //AddNumbersFromString();
            //Console.Read();

            SortNumbersFromString();
            Console.Read();
           
            /// <summary>
            /// Function that writes a line of text to a file
            /// If you run the program again, the new line will replace the old one.
            /// </summary>
            static void WriteStringToFile()
            {
                Console.WriteLine("Skriv en kort mening");
                string fromUser = Console.ReadLine();
                // Set a variable to the My Documents path.
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\filename.txt"))
                {
                    outputFile.WriteLine(fromUser);
                    outputFile.Close();
                }
                Console.WriteLine("Klar med att skriva din text till fil");
                Console.WriteLine("Du hittar din fil i \"Documents\" mappen med namnet filename.txt");
            }
            /// <summary>
            /// Here, we read from the same file
            /// If you add manually more rows to the file, the results will change.
            /// </summary>
            static void ReadFromFile()
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                int counter = 0;
                // Read the file and display it line by line.  
                foreach (string line in File.ReadLines(mydocpath + @"\filename.txt"))
                {
                    System.Console.WriteLine(line);
                    counter++;
                }
                System.Console.WriteLine("\n{0} rader kunde läsas från filen filename.txt", counter);
            }
            //Slut Uppg 7 och 8



            //Uppg 9
            // Returns roten av, samt Upphöjt till 2 och 10

            static void CalculateValues()
            {

                double userInput;

                Console.Write("Skriv ett flyttal: ");
                userInput = double.Parse(Console.ReadLine());

                double squareRoot = Math.Sqrt(userInput);
                double atPowerOfTwo = Math.Pow(userInput, 2);
                double atPowerOfTen = Math.Pow(userInput, 10);

                Console.WriteLine("Roten ur {0} blir lika med {1}", userInput, squareRoot.ToString());
                Console.WriteLine("Talet upphöjt till 2 blir lika med: {0}", atPowerOfTwo.ToString());
                Console.WriteLine("Talet upphöjt till 2 blir lika med: {0}", atPowerOfTen.ToString());

            }

            // Slut Uppg9

            //Uppg 10
            static void mult_tabell()
            {
                {
                    //En ”tabb” ska läggas in efter varje nummer
                    int j, n;

                    Console.Write("\n\n");
                    Console.Write("Display the multiplication table:\n");
                    Console.Write("-----------------------------------");
                    Console.Write("\n\n");

                    Console.Write("Input the number (Table to be calculated) : ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                    Console.Write("\n");

                    for (j = 1; j <= 10; j++)
                    {
                        Console.Write("{0} X {1} = {2} \t", n, j, n * j);
                    }
                }
            }
            // Slut Uppg10

            //Uppg 11
            static void falt()
            {
                //2 arrays en med slumptal den andra med sorterade från första
                //Array.sort kan inte användas
                Random rnd = new Random();
                int max = 21;

                int[] array1 = new int[max];
                int[] array2 = new int[max];

                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = rnd.Next(1, max);
                    //Console.WriteLine(array1[i]);
                }

                //Sedan sorteras arrayen med bubbelsort
                static void BubbleSort(int[] array2)
                {
                    bool needsSorting = true;
                    //Gör en loop för varje tal som skall sorteras, avbryt om talen är sorterade
                    for (int i = 0; i < array2.Length - 1 && needsSorting; i++)
                    {
                        //Signalera att vi börjar om en ny vända med sortering
                        needsSorting = false;
                        //Gå igenom alla tal fram till och med de tal som ev. 
                        //redan är sorterade (variabeln i)
                        for (int j = 0; j < array2.Length - 1 - i; j++)
                        {
                            //Flytta större tal fram i vektorn
                            if (array2[j] > array2[j + 1])
                            {
                                //Signalera att vi kommer att behöva fortsätta sortera
                                needsSorting = true;
                                //Byt plats på tal
                                int tmp = array2[j + 1];
                                array2[j + 1] = array2[j];
                                array2[j] = tmp;
                            }
                        }
                        //Har vi nu inte behövt sortera några tal så är 
                        //needsSorting == false och loop'en kommer att avbrytas
                    }
                }


            }
            // Slut Uppg11

            //Uppg12
            static Boolean IsPalindrome(string Ord)
            {
                string text = Console.ReadLine();
                Console.WriteLine(IsPalindrome(text));
                if (text.Length <= 1)
                {
                    return true;
                }
                else
                {
                    if (text[0] != text[text.Length - 1])
                    {
                        return false;
                    }
                    else
                    {
                        return IsPalindrome(text.Substring(1, text.Length - 2));
                    }
                }

            }
            // Slut Uppg12

            //Uppg 13
            static void twoinputs()
            {
                //Skriver alla tal emellan
                int j;
                Console.WriteLine("Ange ett tal: ");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ange ett tal till: ");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                Console.Write("\n");

                for (j = tal1 + 1; j < tal2; j++)
                {
                    Console.Write("{0} \t", j);
                }
            }
            // Slut Uppg13

            //Upg 14
            static void AddNumbersFromString()
            {
                Console.WriteLine("Skriv dina heltal, komma separerade");
                string fromUser = Console.ReadLine();
                string[] arr = fromUser.Split(',');
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += int.Parse(arr[i]);
                }
                Console.WriteLine("Summan blir lika med {0}", sum);
            }
            // Slut Uppg14


            //Uppg 15
            static void SortNumbersFromString()
            {
                Console.WriteLine("Skriv dina heltal, komma separerade");
                string fromUser = Console.ReadLine();
                string[] arr = fromUser.Split(',');

                //Transform string array to int array so that we can sort
                int[] intArr = new int[arr.Length];

                for (int i = 0; i < arr.Length; i++)
                {
                    intArr[i] = int.Parse(arr[i]);
                }

                //Bubble sorting now
                for (int r = 1; r < intArr.Length; r++)
                {
                    //The inner loop pushes the largest integer to the end of the array
                    for (int i = 0; i < intArr.Length - r; i++)
                    {
                        if (intArr[i] > intArr[i + 1])
                        {
                            int temp = intArr[i];
                            intArr[i] = intArr[i + 1];
                            intArr[i + 1] = temp;
                        }
                    }
                }

                string finalSorted = "";
                Console.Write("Sorterade nummer: ");
                foreach (var item in intArr)
                {
                    finalSorted += item.ToString() + ", ";
                }
                Console.Write(finalSorted.Substring(0, finalSorted.Length - 2));
            }
            // Slut Uppg15

            //Uppg 16

            // Character Classen med properties och
            // metoderna är deklarerade ovanpå main
            

        static void Battle()
            {

                //Skapa hjälten
                Character hero = new Character("Batman");
                //Skapa skurken
                Character enemy = new Character("Joker");

                //Visa datan för hjälten
                hero.DisplayInfo();

                //Visa datan för skurken
                enemy.DisplayInfo();

            }
            // Slut Uppg16

            //Meny för att anropa 

            Console.WriteLine("Välj ett tal mellan  1 och 16");

            int tal = int.Parse(Console.ReadLine());

            while (tal != 0 && tal <= 16)
            {

                switch (tal)
                {
                    case 1:
                        Console.WriteLine("Du matade in alternativ 1");
                        Greeting();
                        break;
                    case 2:
                        Console.WriteLine("Du matade in alternativ 2");
                        Person();
                        break;
                    case 3:
                        Console.WriteLine("Du matade in alternativ 3");
                        ColorsSwitch();
                        break;

                    // och så vidare....... till case 16:

                    default:
                        Console.WriteLine("Du angav felaktigt alternativ");
                        break;
                        
                }
            }


        }
    }
}

   

