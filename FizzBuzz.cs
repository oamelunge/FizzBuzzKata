using System;
using System.Text;

namespace CalculadorBisiesto
{
    public class FizzBuzz
    {
        public string PaserFizzBuzz(int number)
        {
            
            if (IsMultipleOf3And5(number))return "FizzBuzz";
            if (IsMultipleOf3(number))return "Fizz";
            if (IsMultipleOf5(number))
                return "Buzz";
            return Convert.ToString(number);
        }

        private static bool IsMultipleOf5(int i)
        {
            return i%5 == 0;
        }

        private static bool IsMultipleOf3(int i)
        {
            return i%3 ==0;
        }

        private static bool IsMultipleOf3And5(int i)
        {
            return i%15 == 0;
        }

        public string DoWholeThing(int howHigtToGo)
        {
            var wholeThing = new StringBuilder();
            for(var i=1;i<=howHigtToGo;i++)
                wholeThing.AppendFormat("{0} ",PaserFizzBuzz(i));
            return wholeThing.ToString();
        }
    }
}