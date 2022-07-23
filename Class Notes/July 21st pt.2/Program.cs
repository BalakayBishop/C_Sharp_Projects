using System;

namespace July21st_ClassNotes
{
    class Program
    {

        public static void ModifyArrayVal (int[] arrayPassed) // passing by value
        {
            // this will NOT affect the original array
        } // end of ModifyArrayVal

        public static void ModifyArrayRef (ref int[] arrayPassed) // passing by reference
        {
            // this WILL affect the original array
        } // end of ModifyArrayRef

        static void Main(string[] args)
        {
            int[] array1 = new int[3];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i * 2;
            }

            foreach (int i in array1)
            {
                //Console.WriteLine(array1[i]);
                // or could be written like 
                Console.WriteLine(i);
            }

            // to catch out of range 
            Console.WriteLine("\n");
            Console.WriteLine("{0, 5} {1, 5}", "Index", "Value");
            for ( int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("{0} {1,5}", i, array1[i]);
                }
                catch
                {
                    Console.WriteLine("Error, out of range");
                }
            }

            // Resizing Array to be bigger
            Console.WriteLine("\nResize array1 to have more elements");
            Array.Resize(ref array1, 5);
            Console.WriteLine("{0, 5} {1, 5}", "Index", "Value");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("{0} {1,5}", i, array1[i]);
            }

            Console.WriteLine();
            int total = 0;
            foreach (int element in array1)
            {
                total += element;
            }
            Console.WriteLine(total / array1.Length);

            // Two Dimensional Array 
            // [rows][columns]
            int[,] a = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] b = new int[5, 5]; // 5 row and 5 column 2D array

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    // iterating thru 2D Array
                }
            }

            // Jagged Array 
            int[][] jagged = { new int[] { 1, 2 },
                               new int[] { 3 },
                               new int[] { 4, 5, 6 } };

            foreach (int[] row in jagged)
            {
                foreach (int element in row)
                {
                    Console.WriteLine("{0, 5}", element);
                }
            }
            
            int[] secondArray = { 3, 4, 5 };
            
            
        } // end of main 
    } // end of class
} // end of NameSpace
