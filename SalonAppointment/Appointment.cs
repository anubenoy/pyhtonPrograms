using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonAppointment
{
    internal class Appointment : IComparable<Appointment>
    {
        public int Time { get; set; }
        public string Name { get; set; }

        public string Service { get; set; }
        public double price { get; set; }
        public double Total { get; set; }


        //function to display appointment and select service based on patient type
        public void print()
        {

            Console.Write($"{Name.ToUpper()} have appointment at {Time / Program.minutes_in_hour:00}:{Time % Program.minutes_in_hour:00} and {Service} {Total}\n");

        }
        public int CompareTo(Appointment other)
        {
            return this.Time - other.Time;
        }
    }
}
