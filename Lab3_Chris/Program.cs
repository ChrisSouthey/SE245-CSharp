using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Chris
{
    class Program
    {
        static void Main(string[] args)
        {
            String fname, lname, name, hour, hourlyRate;
            Int32 intHour, intRate, gross, taxPay, net;
            Double dblResult, tax;
            int payrollNum = 0;
            List<string> nameList = new List<string>();
            List<string> hourList = new List<string>();
            List<string> rateList = new List<string>();
            List<double> grossList = new List<double>();
            List<double> taxList = new List<double>();
            List<double> netList = new List<double>();



            string GetFullName(ref string firstName, ref string lastName)
            {
                return firstName + ' ' + lastName;
            }


            Console.WriteLine("\tHello!\n\n");

            Console.Write("How many payrolls do you need to enter? ");
            payrollNum = int.Parse(Console.ReadLine());



            for (int cntr = 1; cntr <= payrollNum; cntr++)
            {

                Console.Write("\nPlease enter the first name: ");
                fname = Console.ReadLine();

                Console.Write("\nPlease enter the last name: ");
                lname = Console.ReadLine();

                name = GetFullName(ref fname, ref lname);


                /*
                 name = fname + ' ' + lname;
                 //Console.Write(name);
                */
                nameList.Add(name);


                //Console.WriteLine(name);

                Console.Write("\nPlease enter the amount of hours worked: ");
                hour = Console.ReadLine();
                hourList.Add(hour);

                //Console.WriteLine(hour);

                Console.Write("\nPlease enter your hourly rate: ");
                hourlyRate = Console.ReadLine();
                rateList.Add(hourlyRate);

                double doubleHour = Double.Parse(hour);
                double doubleRate = Double.Parse(hourlyRate);
                double grossPay = doubleHour * doubleRate;

                grossList.Add(grossPay);
                //Console.WriteLine(gross);


                if (grossPay >= 0 && grossPay <= 499)
                {
                    tax = 0.2;
                }

                else if (grossPay >= 500 && grossPay <= 999)
                {
                    tax = 0.3;
                }

                else if (grossPay >= 1000)
                {
                    tax = 0.5;
                }

                else
                {
                    tax = 0;
                }


                taxPay = (int)(grossPay * tax);
                taxList.Add(taxPay);
                //Console.WriteLine(taxPay);


                double netPay = grossPay - taxPay;
                netList.Add(netPay);

                Console.Clear();
            }
            
            for (int cntr = 0; cntr < payrollNum; cntr++)
            {
                Console.Write($"\n\n{nameList[cntr]}'s Payroll Info\n");
                Console.Write("---------------------------------\n");
                Console.Write($"Hours worked: {hourList[cntr]}\n");
                Console.Write($"Pay rate: ${rateList[cntr]}\n");
                Console.Write("---------------------------------\n");
                Console.Write($"Gross pay: ${grossList[cntr]}\n");
                Console.Write($"Taxes due: ${taxList[cntr]}\n");
                Console.Write($"Total net pay: ${netList[cntr]}\n");
                Console.Write("---------------------------------\n");
            }




            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
