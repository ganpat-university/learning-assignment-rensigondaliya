// See https://aka.ms/new-console-template for more information
using System;

namespace Demo17
{


    internal class Program
    {

        delegate void Pro_Handler();

        static void Main(string[] args)
        {
            Demo01();

            Demo02();
        }

        static void Demo02()
        {
            Process p1 = new Process();

            Pro_Handler P = new Pro_Handler(p1.Step01);
            P += new Pro_Handler(p1.Step01);
            P += new Pro_Handler(p1.Step04);
            P += new Pro_Handler(p1.Step03);
            P += new Pro_Handler(p1.Step08);
           P += new Pro_Handler(p1.Step05);

        
            P();
            Console.WriteLine();

            Pro_Handler P2 = new Pro_Handler(p1.Step01);
            P2 += new Pro_Handler(p1.Step08);
            P2 += new Pro_Handler(p1.Step01);

           
            P2();
            Console.WriteLine();

            Program.DoSomething(P2);
        }


        static void DoSomething(Pro_Handler P)
        {
           

            if (P != null)
            {
                P();            
            }
        }

        static void Demo01()
        {
            Console.WriteLine("--- Running Process #1");
            Process p1 = new Process();
            p1.Step01();
            p1.Step02();
            p1.Step05();
            p1.Step03();
            p1.Step07();
            p1.Step09();

            Console.WriteLine();
            Console.WriteLine("--- Running Process #2");
            Process p2 = new Process();
            p2.Step01();
            p2.Step06();
            p2.Step10();
        }
    }
}
