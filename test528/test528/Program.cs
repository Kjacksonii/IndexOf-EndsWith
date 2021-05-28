using System;

namespace test528
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kevin Jackson II";
            string name2 = "Kevin Jackson";

            //Finds the first instance of parameter set
            Console.WriteLine(name.IndexOf('n'));

            //Determines if the string ends with the parameter set
            Console.WriteLine(name.EndsWith("ii"));

            //Same as above, included ToUpper as my suffix is always capitalizes
            Console.WriteLine(name.ToUpper().EndsWith("II"));

            //Checks to see if the string contain the parameter
            Console.WriteLine(name2.Contains("v"));
        }
    }
    
}

