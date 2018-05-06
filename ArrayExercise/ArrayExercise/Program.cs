using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Program
    {

        //int[] InitialArray = new int[0];

        static void Main(string[] args)
        {
            int[] InitialArray = new int[1];
            InitialArray[0] = 1;
            

            int h = 1;
            while (h == 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Welcome to Array Exercise:");
                Console.WriteLine("Please choose an option from the menu by typing the number:");
                Console.WriteLine("1) Create an Array and populate it with random numbers");
                Console.WriteLine("2) Display Array in original order");
                Console.WriteLine("3) Display Array in crescent order");
                Console.WriteLine("4) Display Array in decrescent order");
                Console.WriteLine("5) Kenion´s Lets play Indexes");
                Console.WriteLine("6) Exit Program");
                //Console.WriteLine("1)");

                int Option = int.Parse(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        {
                            Console.WriteLine("Option 1");
                            Console.WriteLine("Define a size for the array between 5 and 10 elements");
                            int Size = int.Parse(Console.ReadLine());
                            int[] SupportArray = CreateArray(Size);
                            Array.Resize(ref InitialArray, SupportArray.Length);

                            for (int i = 0; i < SupportArray.Length; i++)
                            {
                                InitialArray[i] = SupportArray[i];
                            }

                            break;
                        }

                    case 2:
                        {
                            DisplayArray(InitialArray);
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            DisplayArray(SortCrescent(InitialArray));
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            DisplayArray(SortDecrescent(InitialArray));
                            Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Lets play Kenion´s game. Here is the current Array");
                            Console.ForegroundColor = ConsoleColor.Green;
                            DisplayArray(InitialArray);
                            int arraysize = InitialArray.Length;
                            Console.WriteLine("Your array size is {0}", arraysize);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Now, type a number");
                            int input1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Now, from the array displayed, choose an index number where you would like to place this number ({0})", input1);
                            int index = int.Parse(Console.ReadLine());
                            InitialArray[index] = input1;
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Press anykey to exit");
                            Console.ReadLine();
                            h++;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Choose valid option");
                            break;
                        }
                }
            }
        }

        private static int[] CreateArray(int size)
        {
            int[] subjectarray = new int[size];
            Random r = new Random();

            for (int i = 0; i < size; i++)
            {
                subjectarray[i] = r.Next(1, 100);
            }

            DisplayArray(subjectarray);
            Console.ReadLine();
            return subjectarray;
            
        }

        private static void DisplayArray(int[] myarray)
        {
            if (myarray.Length > 10)
            {
                Console.WriteLine("Index  | Member Value");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0}      | {1}", i, myarray[i]);
                }

                for (int i = 11; i < myarray.Length; i++)
                {
                    Console.WriteLine("{0}     | {1}", i, myarray[i]);
                }
            }
            else
            {
                Console.WriteLine("Index | Member Value");

                for (int i = 0; i < myarray.Length; i++)
                {
                    Console.WriteLine("{0}     | {1}", i, myarray[i]);
                }
            }
        }

        private static int[] SortCrescent(int[] arr01)
        {
            int[] Sorted = new int[arr01.Length];
           // bool check = false;

            for (int i = 0; i < arr01.Length; i++)
            {
                for (int j = i+1; j < arr01.Length; j++)
                {
                    if (arr01[i] > arr01[j])
                    {
                        int x = arr01[j];
                        int y = arr01[i];

                        arr01[i] = x;
                        arr01[j] = y;
                        
                    }                    
                    
                }
            }

            return arr01;

        }

        private static int[] SortDecrescent(int[] arr01)
        {
            int[] Sorted = new int[arr01.Length];
            // bool check = false;

            for (int i = 0; i < arr01.Length; i++)
            {
                for (int j = i + 1; j < arr01.Length; j++)
                {
                    if (arr01[i] < arr01[j])
                    {
                        int x = arr01[j];
                        int y = arr01[i];

                        arr01[i] = x;
                        arr01[j] = y;

                    }

                }
            }

            return arr01;

        }


    }
}
