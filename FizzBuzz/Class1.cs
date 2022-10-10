using System;

namespace FizzBuzz
{
    public class Class1
    {
        public string CountsOff(int i)
        {
            if (0.Equals(i % 3))
            {
                return "Fizz";
            }

            if (0.Equals(i % 5))
            {
                return "Buzz";
            }

            if (0.Equals(i % 7))
            {
                return "Whizz";
            }

            return i.ToString();
        }
    }
}
