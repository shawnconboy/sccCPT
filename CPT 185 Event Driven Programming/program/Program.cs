using System;
using System.Runtime.InteropServices;

//namespace variables
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

//            const float Pi = 3.14f;

//            Console.WriteLine(Pi);
//        }
//    }  
//}

namespace typeConversion
{
    class program
    {
        static void Main(string[] args)
        {
            //int i = 1000;
            //byte b = (byte) i;
            //Console.WriteLine(b);

            //string number = "1234";
            //int numericalNumber = Convert.ToInt32(number);
            //Console.WriteLine(numericalNumber);

            var address = "1170";
            int numericalAddress = Convert.ToInt32(address);
            Console.WriteLine(numericalAddress);

            try
            {
                var areaCode = "864";
                byte b = Convert.ToByte(areaCode);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }


            try
            {
                string str = "true";
                bool choice = Convert.ToBoolean(str);
                Console.WriteLine(choice);
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry. Couldn't convert correctly.");
            }
        }
    }
}
