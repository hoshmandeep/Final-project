using System;
using System.Collections.Generic;

namespace Car_Purchase
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();


            Company.Ford ford = new Company.Ford("Ford", 2000000, "Fiesta", "Black");//company, price, name of car, color
            ford.DisplayInfo();

            Company.Hyundai hyundai = new Company.Hyundai("Hyundai", 1500000, "Accent", "White");//company, price, name of car, color
            hyundai.DisplayInfo();

            Company.Honda honda = new Company.Honda("Honda", 2500000, "Civic", "Red");//company, price, name of car, color
            honda.DisplayInfo();


            Client client1 = new Client("Hoshman", 20, 1234567890);// client1, age, contact number
            Client client2 = new Client("Deep", 21, 0987654321);// client2, age, contact number
            Client client3 = new Client("Kaur", 22, 1234567890);// client3, age, contact number



            List<Client> clients = new List<Client>();
            clients.Add(client1);
            clients.Add(client2);
            clients.Add(client3);

            foreach (Client c in clients)
            {
                Console.WriteLine("\nThe name of the client is    :{0}, \nThe age of client is           :{1}, \nClient contact number          :{2}", c.Name, c.Age, c.Contact);
            }// This is how it will display clint name, age and contact number

        }
    }
}
