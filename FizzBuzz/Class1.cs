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

            return i.ToString();
        }
    }
}
