using System;

namespace Temperature_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(0);
            Kelvin kelvin = celsius;  
            Console.WriteLine(kelvin.Degree);

        }
    }
}
