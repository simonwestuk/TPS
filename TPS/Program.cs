using System;

namespace TPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("QWERTY12", "Ford", "Fiesta");

            TPSolutions.AddCar(c1);

            Ticket t1 = new Ticket(c1, 75.0, 14);

            TPSolutions.AddTicket(t1);

            Console.WriteLine(t1);
        }
    }
}
