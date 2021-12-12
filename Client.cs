using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Purchase
{
    public class Client
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Contact { get; set; }
        public Client()
        {
           
        }

        public Client(string name, int age, decimal contact)
        {
            Name = name;// name of the client
            Age = age;// age of the client
            Contact = contact;// contact number of the client
        }

       
    }   
}
