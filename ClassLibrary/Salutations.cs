using System;

namespace ClassLibrary
{
    public class Salutations
    {
        public static string GetSalutation(string name)
        {
            return ($"{DateTime.Now.ToShortTimeString()}. Hello, {name}!");
        }
  
    }
}
