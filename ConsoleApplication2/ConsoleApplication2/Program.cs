using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("You want to play? Y/N");
            Console.Write("\n");

            //container var to hold data
            List<int> list = new List<int>();
            List<string> list2 = new List<string>();
            List<int> list3 = new List<int>();

            while (Console.ReadLine() != "N")
            {

                Random rand = new Random(); // generate random
                int num = rand.Next(5); // generate random number 0-4

                list.Add(num); // adding random number to the list contianer

                //out put for each list value
                for (int i = 0; i < list.Count; i++) 
                {
                    Console.Write(list[i] + " ");
                }

                Console.Write("\n");
                Console.Write("Type what you saw");
                Console.Write("\n");

                int counter = 0; // var to int number

                for (int i = 0; i < list.Count; i++) 
                {
                    list2.Add(Console.ReadLine());
                }

                //changing string value to int
                foreach (string value in list2)
                {
                    int result = Convert.ToInt32(value);
                    list3.Add(result);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == list3[i])
                    {
                        counter++;
                    }
                }//for

                if (counter == list.Count)
                {
                    Console.Write("\n");
                    Console.Write("Correct");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("\n");
                    Console.Write("Incorrect");
                    Console.Write("\n");
                    Console.Write("The number you saw ");

                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.Write(list[i] + " ");
                    }

                    Console.Write("and the number you typed ");

                    for (int i = 0; i < list3.Count; i++)
                    {
                        Console.Write(list3[i] + " ");
                    }

                    Console.Write("\n");
                }

                list2.Clear();
                list3.Clear();

                Console.Write("\n");
                Console.Write("You want to continue? Y/N");
                Console.Write("\n");
            }//while

            Console.Write("Bye");
            Console.Write("\n");
        }
    }
}
/* sample run 

You want to play? Y/N
Y
1
Type what you saw
1

Correct

You want to continue? Y/N
Y
1 3
Type what you saw
1
2

Incorrect
The number you saw 1 3 and the number you typed 1 2

You want to continue? Y/N
Y
1 3 4
Type what you saw
1
3
4

Correct

You want to continue? Y/N
N
Bye
Press any key to continue . . .*/