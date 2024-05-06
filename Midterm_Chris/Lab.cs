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
        public class Person
        {
            private string fname;
            private string mname;
            private string lname;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zip;
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
                    fname = value;
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

            public string Zip
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

            public string Feedback { get; internal set; }

        }
    }
}
