// See https://aka.ms/new-console-template for more information

using System;

namespace Demo18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            MyGenericType<int> intVariable = new MyGenericType<int>();
            intVariable.Value = 1;
            intVariable.DisplayInfo();

            MyGenericType<string> strVariable = new MyGenericType<string>();
            strVariable.Value = "rensi hello!";
            strVariable.DisplayInfo();

            
        }
    }
}