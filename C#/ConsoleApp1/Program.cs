using System;

namespace assignment1 {


    internal class assignment
    {
        static void Main(string[] args)
        {

            Class1 c = new Class1();
            
            System.Console.WriteLine("hello");
            Console.Write("enter your name ");
              c.Name= Console.ReadLine();


            Console.Write("enetr your age ");
            c.Age = int.Parse(Console.ReadLine());

            Console.WriteLine(" hi {0} your age is {1} ",c.Name , c.Age);  
                
                
                }
    }









}




