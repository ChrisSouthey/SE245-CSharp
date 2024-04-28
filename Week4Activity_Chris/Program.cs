using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Activity_Chris
{
    class Program
    {
        public class book
        {
            private string title;
            private string authFirst;
            private string authLast;
            private string email;
            private DateTime datePublished;
            private int pages;
            private double price;

            public string Title
            {
                get
                {
                    return title;
                }

                set
                {
                    title = value + " " + "poopy";
                }
            }

            public string AuthFirst
            {
                get
                {
                    return authFirst;
                }

                set
                {
                    authFirst = value;
                }
            }

            public string AuthLast
            {
                get
                {
                    return authLast;
                }

                set
                {
                    authLast = value;
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

            public DateTime DatePublished
            {
                get
                {
                    return datePublished;
                }

                set
                {
                    if (ValidationLibrary.IsAFutureDate(value) == false)
                    {
                        datePublished = value;
                    }
                    else
                    {
                        datePublished = DateTime.Parse("1/1/1900 12:00 am");
                    }
                }
            }

            public int Pages
            {
                get
                {
                    return pages;
                }

                set
                {
                    if (ValidationLibrary.IsMinumumAmount(value, 1) == true)
                    {
                        pages = value;
                    }
                    else
                    {
                        pages = 0;
                    }
                }
            }

            public double Price
            {
                get
                {
                    return price;
                }

                set
                {
                    if (ValidationLibrary.IsMinumumAmount(value, 1) == true)
                    {
                        price = value;
                    }
                    else
                    {
                        price = 0;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            bool blnResult = false;

            book temp = new book();


            Console.Write("\nPlease enter the book title: ");
            temp.Title = Console.ReadLine();

            Console.Write("\nPlease enter the Authors first name: ");
            temp.AuthFirst = Console.ReadLine();

            Console.Write("\nPlease enter the Authors last name: ");
            temp.AuthLast = Console.ReadLine();

            Console.Write("\nPlease enter the Authors email: ");
            temp.Email = Console.ReadLine();


            do
            {
                Console.Write("\nPlease enter the Date published: ");
                DateTime dtTempDate;
                blnResult = DateTime.TryParse(Console.ReadLine(), out dtTempDate);

                if (blnResult == false)
                {
                    Console.Write("\nIncorrect Date format. Please try again. (Ex. 03/13/2005) ");
                }
                else
                {
                    temp.DatePublished = dtTempDate;
                }
            } while (blnResult == false);


            do
            {
                Console.Write("\nPlease enter the # of pages: ");
                int intTempPages;
                blnResult = Int32.TryParse(Console.ReadLine(), out intTempPages);

                if (blnResult == false)
                {
                    Console.Write("\nIncorrect # of pages. Please try again. (Ex. 115) ");
                }
                else
                {
                    temp.Pages = intTempPages;
                }
            } while (blnResult == false);


            do
            {
                Console.Write("\nPlease enter the Price of the book: $");
                double dblTempPrice;
                blnResult = Double.TryParse(Console.ReadLine(), out dblTempPrice);

                if (blnResult == false)
                {
                    Console.Write("\nIncorrect price. Please try again. (Ex. 14.95) ");
                }
                else
                {
                    temp.Price = dblTempPrice;
                }
            } while (blnResult == false);



            Console.Write("\n\nYou have entered the following book:");
            Console.Write($"\nTitle: {temp.Title}");
            Console.Write($"\nWritten by: {temp.AuthFirst} {temp.AuthLast}");
            Console.Write($"\nEmail: {temp.Email}");
            Console.Write($"\nPublished: {temp.DatePublished.ToShortDateString()}");
            Console.Write($"\nPages: {temp.Pages}");
            Console.Write($"\nPrice: {temp.Price}");

            BasicTools.Pause();

        }



        
        
    }
}
