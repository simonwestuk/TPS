using System;

namespace TPS
{
    class Ticket
    {
        public Guid Id { get; set; }
        public Car Car { get; set; }
        public DateTime DateIssued { get; set; }
        public double Fee { get; set; }
        public int DaysToPay { get; set; }
        public bool Paid { get; set; }

        public Ticket(Car car, double fee, int daysToPay)
        {
            Id = Guid.NewGuid();
            Car = car;
            DateIssued = DateTime.Now;
            Fee = fee;
            DaysToPay = daysToPay;
            Paid = false;
        }

        public override string ToString()
        {
            return $@"
                      ID: {Id}
                      Car: {Car.ToString()}
                      Date Issued: {DateIssued}
                      Fee: £{Fee}
                      Due Date: {DateIssued.AddDays(DaysToPay)}
                      Paid: {Paid}";
        }
    }
}
