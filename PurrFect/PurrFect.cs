using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurrFect
{
}

namespace PurrFect
{
    public static class Booking
    {

        public static int PetID { get; set; }
        public static int GroomerID { get; set; }     
        public static int ServiceID { get; set; }     
        public static string Package { get; set; }    
        public static string groomer { get; set; }     
        public static string TimeSlot { get; set; }
        public static DateTime BookingDate { get; set; }
        public static decimal TotalPrice { get; set; }
        public static int BookingID { get; set; }

        public static string PaymentMethod { get; set; }

        // Add-on variables
        public static string HairCut { get; set; }
        public static string Shampoo { get; set; }
        public static string NailClip { get; set; }
        public static string FleaTreatment { get; set; }
        public static string TeethCleaning { get; set; }



    }

    
}
