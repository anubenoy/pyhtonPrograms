using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonAppointment
{
    internal class AvailableServices
    {
        Appointment appointment = new Appointment();

        public double totalPrice = 0d;
        public double Haircutprice = 0d;
        public double haircolorprice = 0d;
        public double washprice = 0d;
        public void Services(string hairService)
        {
            
           
            switch (hairService)
            {
                case "hair cut":
                    Haircutprice = 4.99;
                    break;
                case "hair color":
                    haircolorprice = 5.99;
                    break;
                case "wash":
                    washprice += 6.99;
                    break;

            }

            totalPrice= Haircutprice + haircolorprice + washprice;
            
        }
       
    }
    
}
