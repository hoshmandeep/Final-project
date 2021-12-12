using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Purchase
{
    public abstract class Company// diffent companies of car
    {
        public string name;// name of the car
        public int price;// price of the car
        public string model;// model of the car
        public Company(string cname, int cprice, string cmodel)
        {
            name = cname;
            price = cprice;
            model = cmodel;
        }
        public class Ford : Company
        {
            public string car_color;

            public Ford(string cname, int cprice, string cmodel, string color) : base(cname, cprice, cmodel)// description of ford company cars
            {
                car_color = color;
            }
            public void DisplayInfo()
            {
                Console.WriteLine("\nThe name of the car is    :" + name);// name of the car
                Console.WriteLine("The price of the car is   :" + price);//price of the car
                Console.WriteLine("The model of the car is   :" + model);//model of the car
                Console.WriteLine("The color of car is       :" + car_color);// color of the car
            }
        }
        public class Hyundai : Company
        {
            public string car_color;

            public Hyundai(string cname, int cprice, string cmodel, string color) : base(cname, cprice, cmodel)// Description of hyundai company cars
            {
                car_color = color;
            }
            public void DisplayInfo()
            { 
                Console.WriteLine("\nThe name of the car is    :" + name);// name of the car
                Console.WriteLine("The price of the car is   :" + price);// price of the car
                Console.WriteLine("The model of the car is   :" + model);// model of the car
                Console.WriteLine("The color of car is       :" + car_color);// color of the car
            }
        }
        public class Honda : Company
        {
            public string car_color;

            public Honda(string cname, int cprice, string cmodel, string color) : base(cname, cprice, cmodel)// description of honda cars
            {
                car_color = color;
            }
            public void DisplayInfo()
            {
                Console.WriteLine("\nThe name of the car is    :" + name);// name of the car
                Console.WriteLine("The price of the car is   :" + price);// price of the car
                Console.WriteLine("The model of the car is   :" + model);// model of the car
                Console.WriteLine("The color of car is       :" + car_color);// color of the car
            }
        }
      
    }
}
