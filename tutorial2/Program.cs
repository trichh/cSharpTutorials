using System;

namespace TypeConversion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            byte b = (byte) i;
            int n = 1000;
            byte c = (byte) n;
            string number = "1234";
            int num = Convert.ToInt32(number);
            Console.WriteLine("NOT LOOSING DATA " + b);
            Console.WriteLine("LOOSING DATA " + c);
            Console.WriteLine("Converting string " + number + " to interger " + num);
            try
            {
                byte d = Convert.ToByte(number);
                Console.WriteLine("Converting string " + number + " to byte " + d);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte!");
            }
            try
            {
                string str = "true";
                bool boolean = Convert.ToBoolean(str);
                Console.WriteLine("Converting string " + str + " to boolean " + boolean);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to a boolean!");
            }
        }
    }
}
