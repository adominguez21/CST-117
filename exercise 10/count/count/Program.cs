using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Dont be late, teatime will not wait!";
            int count = 0;
            int word = 0;
            foreach (char item in input)
            { 
                if (item== 't')
                {
                    count++;
                }
                foreach (char item in input)
                {
                    if (item== 'e')
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine("The number of t characters are {0}", count);

            foreach (Match m in Regex.Matches(input,"how", RegexOptions.IgnoreCase))
            {
                word++;
            }
            Console.WriteLine("The no of words that end with t and e are {0}, word");
        }
    }
}
