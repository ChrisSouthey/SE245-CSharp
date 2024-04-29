using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Activity_Chris;



namespace Lab4_Chris
{
    class Program
    {
        public struct Person
        {
            private string fname;
            private string mname;
            private string lname;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private int zip;
            private string phone;
            private string email;



            public string Fname
            {
                get
                {
                    return fname;
                }
                set
                {
                    fname = value + " Poopy";
                }
            }

            public string Mname
            {
                get
                {
                    return mname;
                }
                set
                {
                    mname = value;
                }
            }

            public string Lname
            {
                get
                {
                    return lname;
                }
                set
                {
                    lname = value;
                }
            }

            public string Street1
            {
                get
                {
                    return street1;
                }
                set
                {
                    street1 = value;
                }
            }

            public string Street2
            {
                get
                {
                    return street2;
                }
                set
                {
                    street2 = value;
                }
            }

            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
                }
            }

            public string State
            {
                get
                {
                    return state;
                }
                set
                {
                    state = value;
                }
            }

            public int Zip
            {
                get
                {
                    return zip;
                }
                set
                {
                    zip = value;
                }
            }

            public string Phone
            {
                get
                {
                    return phone;
                }
                set
                {
                    phone = value;
                }
            }

            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    if (ValidationLibrary.IsValidEmail(value))
                    {
                        email = value;
                    }
                    else
                    {
                        email = "INVALID";
                    }
                }
            }

            static void Main(string[] args)
            {
                bool blnResult = false;

                Person temp = new Person();


                Console.Write("\nPlease enter First name: ");
                temp.Fname = Console.ReadLine();

                Console.Write("\nPlease enter Middle name: ");
                temp.Mname = Console.ReadLine();

                Console.Write("\nPlease enter Last name: ");
                temp.Lname = Console.ReadLine();

                Console.Write("\nPlease enter Street name (Ex. 12 Park Ave): ");
                temp.Street1 = Console.ReadLine();

                Console.Write("\nPlease enter apt # or Department name if available (Ex. Apt 4 or IT Dept, None): ");
                temp.Street2 = Console.ReadLine();

                Console.Write("\nPlease enter City: ");
                temp.City = Console.ReadLine();

                Console.Write("\nPlease enter State: ");
                temp.State = Console.ReadLine();

                do
                {
                    Console.Write("\nPlease enter Zipcode: ");
                    int intTempZip;
                    blnResult = Int32.TryParse(Console.ReadLine(), out intTempZip);

                    if (blnResult == false)
                    {
                        Console.Write("\nSorry, Incorrect Zipcode entered. Please try again. (Ex. 10101) ");
                    }
                    else
                    {
                        temp.Zip = intTempZip;
                    }
                } while (blnResult == false);

                Console.Write("\nPlease enter Phone number (Ex. 206-382-0194): ");
                temp.Phone = Console.ReadLine();

                Console.Write("\nPlease enter Email: ");
                temp.Email = Console.ReadLine();




                Console.Write($"\n{temp.Fname} {temp.Lname}'s Info:");
                Console.Write($"\nFirst Name: {temp.Fname}");
                Console.Write($"\nMiddle Name: {temp.Mname}");
                Console.Write($"\nLast Name: {temp.Lname}");
                Console.Write($"\nStreet 1: {temp.Street1}");
                Console.Write($"\nStreet 2: {temp.Street2}");
                Console.Write($"\nCity: {temp.City}");
                Console.Write($"\nState: {temp.State}");
                Console.Write($"\nZipcode: {temp.Zip}");
                Console.Write($"\nPhone #: {temp.Phone}");
                Console.Write($"\nEmail: {temp.Email}");


                BasicTools.Pause();
            } 
        }
    }
}
