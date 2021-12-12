using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Purchase
{
    public class Car
    {
      
            public int year;
            public string compeny;
            public Car()
            {
                this.year = 1994;
                this.compeny = "Ford";
            }

            public Car(string compeny, int year)
            {
                this.year = year;// year in which car menufactured
                this.compeny = compeny;// company of the car
            }

            public string Compeny// Company of the car
        {
                get { return compeny; }
                set { compeny = value; }
            }

            public int Year // year
            {
                get { return Year; }
                set { Year = value; }
            }
        }
    }
