using System;

namespace demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arry");
            SingleDimensionalArray();
            TwoDimensionalArray();
            
        }

        static void TwoDimensionalArray()
        {
            int[,] arr;          
            arr = new int[2, 3];    
            arr[0, 0] = 8;         
            arr[0, 1] = 9;
            arr[0, 2] = 10;
            arr[1, 0] = 11;
            arr[1, 1] = 12;
            arr[1, 2] = 13;

            int[,] arr2 = new int[2, 3]
            {
                { 8, 9, 10 },
                { 11, 12, 13 }
            };
            int[,] arr3 = {
                { 10, 20, 30 },
                { 40, 50, 60 }
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }

            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
      
        static void SingleDimensionalArray()
        {
            int[] arr;        
            arr = new int[3];   
            arr[0] = 5;        
            arr[1] = 6;
            arr[2] = 7;
           

            int[] arr2 = new int[3];
            int[] arr3 = new int[3] { 5 , 6 , 7};
            int[] arr5 = { 5 , 6 , 7 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
