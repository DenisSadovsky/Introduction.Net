using System;

namespace Hello_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
   
            Console.WriteLine(ClassLibrary.Salutations.GetSalutation(name));
            Console.ReadKey();
            
        }
    }
}
