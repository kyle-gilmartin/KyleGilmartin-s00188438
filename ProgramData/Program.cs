using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam;

namespace ProgramData
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone() {PhoneID = 1, Name = "Samsung S20" ,Price = 500, OperatingSystem = "Android", Phone_Image="/Images/android.png" ,Os_Image = "/Images/s20.png" };
                Phone p2 = new Phone() {PhoneID = 2, Name = "IPhone 11", Price = 600, OperatingSystem = "IOS", Phone_Image = "/Images/apple.png", Os_Image = "/Images/iphone11.png" };

                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Phone added to database");

                db.SaveChanges();

                Console.WriteLine("Saved to database");
            }
        }
    }
}
