using System;

namespace Demo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indexer");

            Company C = new Company("eInfochips");
            C.AddEmployee("Rensi");
            C.AddEmployee("Aditya");

            

            Employee empFind;

            empFind = C["Rensi"];
            if (empFind == null)
            {
                Console.WriteLine("find some one");
            }
            else
            {
                Console.WriteLine("object was not found");
            }


            empFind = C[2];
            if (empFind == null)
            {
                Console.WriteLine("could not find the employee with ID == 3!");
            }
        }


        static void Demo01()
        {
            int[] arr = new int[2] {  20, 30 };

            arr[2] = 890;                   
        }
    }
}
