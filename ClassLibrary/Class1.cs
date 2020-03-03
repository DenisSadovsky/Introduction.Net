using System;

namespace ClassLibrary
{
    public class Class1
    {
        public static string Method(string name)
        { 
            return ($"{new DateTime().ToShortTimeString()}. Hello, {name}!");
        }
  
    }
}
