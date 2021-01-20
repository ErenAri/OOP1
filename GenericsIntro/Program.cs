using System;

namespace My
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("deneme");
            Console.WriteLine(isimler);
        }
    }
}
