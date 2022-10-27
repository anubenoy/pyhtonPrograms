using System;
using System.Collections.Generic;
using System.Linq;

namespace SalonAppointment
{
    internal class Program
    {
        //public constants (shared with Appointment.cs)
        public const int minutes_in_hour = 60;

        //private constants
        const int first_appointment_hour = 8;
        const int last_appointment_hour = 16;

        const int first_appointment = first_appointment_hour * minutes_in_hour;
        const int last_appointment = last_appointment_hour * minutes_in_hour;

        const int appointment_length = minutes_in_hour;
        static void Main(string[] args)
        {
           
            //list of appointments
            List<Appointment> appointments = new List<Appointment>();

            double total = 0d;

           

            //list of available appointment times
            List<int> appointmentTimes = new List<int>();

            //set up all the possible appointment times available
            for (int time = first_appointment; time < last_appointment; time += appointment_length)
                appointmentTimes.Add(time);

            do
            {
                string fName;
                do
                {
                    Console.WriteLine("Please enter customer first name");
                    fName = Console.ReadLine();
                } while (fName == "");


                string lName;
                do
                {
                    Console.WriteLine("Please enter customer last name");
                    lName = Console.ReadLine();
                } while (lName == "");

                string name = fName + " " + lName;

                string email;
                do
                {
                    Console.WriteLine("Please enter email address");
                    email = Console.ReadLine();
                } while (email == "");


                //Object of appointement is created each time the appointment is scheduled
                Appointment appointment = new Appointment();

                appointment.Name = name;

                bool shouldExit = false;
                int selected = 0;
                do
                {
                    //prompt the user for an appointment time
                    Console.WriteLine();
                    Console.WriteLine("Please select an appointment time by number");
                    //display appointment times with 'selector' number
                    int selector = 1;
                    foreach (int time in appointmentTimes)
                        Console.WriteLine($"{selector++} {time / minutes_in_hour:00}:{time % minutes_in_hour:00}");

                    var key = Console.ReadKey();
                    Console.WriteLine();
                    //if they typed the escape key, then do an early exit
                    if (key.Key == ConsoleKey.Escape)
                    {
                        shouldExit = true;
                        break;
                    }
                    //otherwise, collect the number (single digit) that they typed
                    int.TryParse(key.KeyChar.ToString(), out selected);
                    selected--;
                    //loop until they pick something from the list
                } while (selected < 0 || selected >= appointmentTimes.Count);

                //user is done, so show the list right away
                if (shouldExit)
                    break;

                //remember the selected time
                appointment.Time = appointmentTimes[selected];



                Console.WriteLine();
                string service;
                do
                {
                    Console.WriteLine("Available services:\n1. Hair cut\n2. Hair color\n3. Wash/Shampoo");
                    Console.Write("Please enter the serive you need: ");
                    service = Console.ReadLine();
                } while (service == "");

                AvailableServices availableServices = new AvailableServices();
                availableServices.Services(service.ToLower());

                appointment.Service = service;
                appointments.Add(appointment);



                Console.WriteLine("Do you want to reset(Y/N)");
                var reset = Console.ReadLine();

                if (reset.ToLower() == "y")
                {
                    appointments.RemoveAt(appointments.Count() - 1);
                    //appointmentTimes.Add(appointmentTimes[selected]);
                }
                else {
                    appointmentTimes.RemoveAt(selected);
                    appointment.Total = availableServices.totalPrice;
                    total += availableServices.totalPrice;
                    
                }
                //this time is no longer available, so don't show it again


                //Need to continue with appointments
                Console.WriteLine("Do you want to book more appointment? (Y/N)");
                var decision = Console.ReadLine();
                if (decision.ToUpper() == "N")
                {
                    break;
                }

            } while (appointmentTimes.Count > 0);


            foreach (Appointment a in appointments)
            {

                a.print();

            }
            Console.WriteLine($"Total price is {total}");
            Console.ReadKey();
        }
    }
}
