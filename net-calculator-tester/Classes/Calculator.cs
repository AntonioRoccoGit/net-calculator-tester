using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester.Classes
{
    internal class Calculator
    {
        public static T NumberSumm<T>(T number1, T number2) where T : INumber<T>
        {
            return number1 + number2;
        }
        public static T NumberDiff<T>(T number1, T number2) where T : INumber<T>
        {
            return number1 - number2;
        }
        public static T NumberMultiplier<T>(T number1, T number2) where T : INumber<T>
        {
            return number1 * number2;
        }
        public static T NumberDivision<T>(T number1, T number2) where T : INumber<T>
        {
            return number1 / number2;
        }
    }
}
