using System;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace CalculadorBisiesto
{
    public class StringCalculator
    {
        private char _delimiter = ',';
        private string _stringToCalculate;
        private static int _parsedNumber;

        public StringCalculator(string stringToCalculate)
        {
            _stringToCalculate = stringToCalculate;

        }

        public int GetValue()
        {
            if (StringIsEmpty()) return 0;

            ParseDelimiterAndStringToCalculate();

            return _stringToCalculate.Replace('\n', _delimiter).Split(_delimiter).AsQueryable().Sum(characterToParse => ProcessStringToNumber(characterToParse));
        }

        private bool StringIsEmpty()
        {
            return _stringToCalculate.Count().Equals(0);
        }

        private void ParseDelimiterAndStringToCalculate()
        {
            if (!_stringToCalculate.StartsWith("//")) return;
            _delimiter = _stringToCalculate[2];
            _stringToCalculate = _stringToCalculate.Substring(4);
        }



        private static int ProcessStringToNumber(string characterToParse)
        {
            ConvertCharacterToNumbers(characterToParse);
            IfNegativeValueTrhowException();
            return IfGratherThan1000() ? 0 : _parsedNumber;
        }

        private static bool IfGratherThan1000()
        {
            return _parsedNumber > 1000;
        }

        private static void IfNegativeValueTrhowException()
        {
            if (_parsedNumber >= 0) return;
            throw new Exception();
        }

        private static void ConvertCharacterToNumbers(string numberToParse)
        {
            _parsedNumber = int.Parse(numberToParse);
        }
    }
}