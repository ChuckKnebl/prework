using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Files
{
    class Program
    {
        static void Main(string[] args)
            //Retrieved this code from c-sharpcorner.com/blogs/reverse-a-number-and-string-in-c-sharp1
            // Learned from this exercise from c-sharpcorner, stackoverflow, others
            // Began my learning of Visual Studio
            // Learned different ways to accomplish same outcome; sanfoundry.com used while loop "number != 0" (not equal to zero)  
        {
            Console.WriteLine("Enter a No. to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }
    }
}
