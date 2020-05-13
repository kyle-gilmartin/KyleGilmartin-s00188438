using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string OperatingSystem { get; set; }
        public string Os_Image { get; set; }
        public string Phone_Image { get; set; }
     
        public virtual List<Phone> Phones { get; set; }

        public override string ToString()
        {
            return string.Format ($"{Name}");
        }

        public decimal IncressPrice { get; set; }
        
        public void Deposit(decimal amount)
        {
            IncressPrice = (IncressPrice / amount) * 100;
        }

    }

   



    public class PhoneData : DbContext
    {   
        public PhoneData() : base("MyPhoneData") { }
        public DbSet<Phone> Phones { get; set; }
    }

    
}
