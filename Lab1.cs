using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Chris
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, hour, hourlyRate;
            Int32 intHour, intRate, gross, taxPay, net;
            Double dblResult, tax;

            Console.WriteLine("Hello!");


            Console.Write("Please enter your first name: ");
            name = Console.ReadLine();

            //Console.WriteLine(name);

            Console.Write("Please enter the amount of hours worked: ");
            hour = Console.ReadLine();

            //Console.WriteLine(hour);

            Console.Write("Please enter your hourly rate: ");
            hourlyRate = Console.ReadLine();

            intHour = Convert.ToInt32(hour);
            intRate = Convert.ToInt32(hourlyRate);
            gross = intHour * intRate;

            Console.WriteLine(gross);

            
            if (gross >= 0 && gross <= 499)
            {
                tax = (int)0.2;
            }

            else if (gross >= 500 && gross <= 999)
            {
                tax = 0.3;
            }

            else if (gross >= 1000)
            {
                tax = 0.5;
            }

            else
            {
                tax = 0;
            }


            taxPay = gross * tax;

            Console.WriteLine(taxPay);

            net = 

            










            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
