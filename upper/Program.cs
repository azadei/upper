using System;
using System.Linq;


namespace upper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = "java".ToUpper();

            string name2 = name.ToUpper();

            Console.WriteLine(name2.Reverse());
        }
    }
}
