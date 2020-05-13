using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string OperatingSystem { get; set; }
        public string Os_Image { get; set; }
        public string Phone_Image { get; set; }

        public virtual List<phone> Phones { get; set; }

    }

    class phone
    {
       
    }

    public class PhoneData : DbContext
    {
        public DbSet<phone> Phones { get; set; }
    }

    
}
