using System;

namespace demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Members");
            const string Student = "Rensi Gondaliya";

            Console.WriteLine("Author = {0}", Student);


            MyDay day = MyDay.Monday;
            Console.WriteLine("{0} : int = {1}", day, (int)day);
            day = MyDay.Friday;
            Console.WriteLine("{0} : int = {1}", day, (int)day);

            int i = 5;
            day = (MyDay)i;
            Console.WriteLine("{0} {1}", day, i);

            myStructure S;
            S.id = 20;
            S.Name = "";

            myClass c = new myClass();               
            c.id = 1;
            c.Name = "Rensi";


                 

        }
    }
}
