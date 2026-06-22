using System;
using System.Collections.Generic; 

namespace PurrFect
{
    public static class Booking
    {
        public static int UserID { get; set; }
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

    public abstract class ServiceItem
    {
        public string ItemName { get; set; }
        public abstract decimal GetPrice(); 
    }

    public class PremiumService : ServiceItem
    {
        public decimal FixedPrice { get; set; }

        public override decimal GetPrice()
        {
            return FixedPrice;
        }
    }
    public class PriceCalculator
    {
        private List<ServiceItem> selectedItems = new List<ServiceItem>();

        public void AddItem(ServiceItem item)
        {
            selectedItems.Add(item);
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (ServiceItem item in selectedItems)
            {
                total += item.GetPrice();
            }
            return total;
        }
    }
}
namespace PurrFect
{


    public partial class PurrFect
    {
    }
}
