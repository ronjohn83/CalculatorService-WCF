using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalcServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        int Multiply(int number1, int number2);

        [OperationContract]
        int Divide(int number1, int number2);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "CalcServiceLibrary.ContractType".
    [DataContract]
    public class MyNumbers
    {
        int number1 = 0;
        int number2 = 0;

        [DataMember]
        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }

        [DataMember]
        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }
    }
}
