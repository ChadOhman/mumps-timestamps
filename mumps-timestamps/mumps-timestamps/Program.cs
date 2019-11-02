using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mumps_timestamps
{
    class Program
    {
        static void Main()
        {
            var baseDate = new DateTime(1970,01,01);

            Console.WriteLine("*******************************");
            Console.WriteLine("MUMPS/Cache TimeStamp Converter");
            Console.WriteLine("*******************************\n");

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Human Readable Date/Time to MUMPS/Cache");
            Console.WriteLine("2. MUMPS/Cache to Human Readable Date/Time");
            Console.Write("Choose option: ");
            int MenuOption = int.Parse(Console.ReadLine());

            switch (MenuOption)
            {
                case 1:
                    Console.WriteLine("Human Readable Date/Time to MUMPS/Cache");

                    Console.Write("Enter Date (mm/dd/yyyy): ");
                    var humanDate = new DateTime(long.Parse(Console.ReadLine()));
                    int unixStamp = (int)humanDate.Subtract(baseDate).TotalSeconds;

                    Console.WriteLine(unixStamp);

                    return;

                case 2:
                    Console.WriteLine("MUMPS/Cache to Human Readable Date/Time");

                    return;

                default:

                    return;
            }
        }
    }
}
