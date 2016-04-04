using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Fizzbuzz
    {
        static void Main(string[] args)
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();
            for (int i = 1; i < 100; i++){
                Console.WriteLine(fizzbuzz.fizzbuzzer(i));
            }
        }

        public string fizzbuzzer(int v)
        {
            string result="";
            if( v % 3 == 0)
            {
                result = "fizz";
            }
            if (v % 5 == 0)
            {
                result += "buzz";
            }

            result = String.IsNullOrEmpty(result) ?  v.ToString(CultureInfo.InvariantCulture) : result;
            return result;

        }
    }
}
