using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a pin code between 4 and 8 digits.");
            string pincode = Console.ReadLine();
            int minLength = 8;
            int pincodeLength = pincode.Length;
            bool valid = true;

            foreach (var c in pincode)
            {
                if (!char.IsDigit(c))
                {
                    valid = false;
                    break;
                }
            }
            if (pincodeLength < 4 || pincodeLength>= minLength || !valid)
            {
                valid = false;
                Console.WriteLine("The pincode should be between 4 and 8 digits and not characters!");
            }
            else

            {

              Console.WriteLine(valid);
            }
        }
    }
}
