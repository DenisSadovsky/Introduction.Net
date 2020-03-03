using System;

namespace Hello_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
   
            Console.WriteLine(ClassLibrary.Class1.Method(name));
            Console.ReadKey();
            
        }
    }
}
