using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Data_Structures
{
    class Program
    {
        public static void ArrayClass()
        {
            //Initiallize array of size 10
            int[] myArray = new int[10];

            //Populate array
            Console.WriteLine("Initial Elements: ");
            for (int i = 0; i < myArray.Length - 4; i++) 
            {
                myArray[i] = i * 5;
                Console.WriteLine("[" + i + "]: " + myArray[i]);
            }
            
            //Testing common array methods
            Array.Reverse(myArray); //Reverse array
            Console.WriteLine("After reversing: ");
            for (int i = 0; i < myArray.Length; i++) //Print reversed array
            {
                Console.WriteLine("[" + i + "]: " + myArray[i]);
            }

            Array.Sort(myArray); //Sort array
            Console.WriteLine("After sorting: ");
            for (int i = 0; i < myArray.Length; i++) //Print reversed array
            {
                Console.WriteLine("[" + i + "]: " + myArray[i]);
            }

            Console.WriteLine("Array Lenght: " + myArray.Length); //Returns array lenght
            Console.WriteLine("Array Type: " + myArray.GetType()); //Returns array type
            Console.WriteLine("Contains 40? " + myArray.Contains(40)); //Returns true or false if array contains item
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //*****[DATA STRUCTURES]*****//
            ArrayClass(); //Calling Array Class
        }
    }
}
.