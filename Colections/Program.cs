using System;
using System.Collections.Generic;

namespace Colections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Eren","Bill Gates","Elon Musk","Steve Jobs"};
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Bill Gates", "Elon Musk", "Steve Jobs" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Eren");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
