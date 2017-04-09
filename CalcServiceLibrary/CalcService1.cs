using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalcServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalcService1 : ICalcService
    {
        public int Divide(int number1, int number2)
        {
            return (number1 / number2);
        }

        public int Multiply(int number1, int number2)
        {
            return (number1 * number2);
        }
    }
}
