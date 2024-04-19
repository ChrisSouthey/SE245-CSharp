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
                    title = value;
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
                Console.Write("\nPlease ");
            }
        }

        
        
    }
}
