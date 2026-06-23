using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurrFect
{
    public interface IBookingProcessor
    {
        void ValidateBookingDate(DateTime date);
    }

    public class BaseForm : Form, IBookingProcessor
    {
        protected string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True";

        public BaseForm()
        {
        }

        public class InvalidBookingException : Exception
        {
            public InvalidBookingException(string message) : base(message) { }
        }

        
        public virtual void ValidateBookingDate(DateTime date)
        {
            if (date < DateTime.Today)
            {
                throw new InvalidBookingException("Date chosen cannot be a past date!");
            }
        }
    }
    }
