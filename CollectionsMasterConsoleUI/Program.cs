using System;
using System.Collections.Generic;
//using System.Security.Cryptography;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50

            int[] array1 = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(array1);



            //Print the first number of the array
            Console.WriteLine($" This is the first random {array1[0]}");

            //Print the last number of the array    
            Console.WriteLine($" This is the last random {array1[49]}");

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(array1);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(array1);
           

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(array1);
           
            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(array1);


            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */

            Array.Sort(array1);
            NumberPrinter(array1);
            //Console.WriteLine("Sorted numbers:");


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List

            List<int> myList = new List<int>();
           

            //Print the capacity of the list to the console
            foreach (int a in myList)
            {
                Console.WriteLine(a);
            }

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(myList);
            //Print the new capacity
            foreach (int a in myList)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
           
            int userNumber;
            
            if (int.TryParse(Console.ReadLine(),out userNumber))
            { 
                NumberChecker(myList, userNumber);
            }
            else
            { 
                Console.WriteLine($"Sorry your input is not an integer...");
            }
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(myList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            OddKiller(myList);

            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");

            myList.Sort();
            NumberPrinter(myList);

            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
          
            int[] myArr = myList.ToArray();
            //NumberPrinter(myArr);

            //Clear the list

            myList.Clear();
            //NumberPrinter(myList);

            #endregion
        }
        //### End of Main

        static void NumberPrinter(int[] arr)
        {
           
                Random rnd = new Random();

                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            
        }

        static void NumberPrinter(List<int> printList)
        {

            foreach (int a in printList)
            {
                Console.WriteLine(a);
            }


        }


        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                    if ( numbers[i]%3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i=0; i<30; i++)
            if (numberList[i]%2 != 0)
            {
                    //Console.WriteLine($" {i} Item removed {numberList[i]}");
                    numberList.RemoveAt(i);
                   
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
           
                if (numberList.Contains(searchNumber)  == true)
               {
                    Console.WriteLine($"Yes we have your number... {searchNumber}");
               } else
                {
                    Console.WriteLine($"Nope your number isn't here... {searchNumber}");
                }
           
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 1; i < 50; i++)
            {
                numberList.Add(rng.Next(0,1000));   
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers[i] = rnd.Next(1, 1000);
            }

        }


        private static void ReverseArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
            Console.WriteLine("In ReverseArray");
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
        //    //STAY OUT DO NOT MODIFY!!
           foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}


