using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());    //the date and time
            //Console.WriteLine(myValue.ToShortDateString()); //just the date
            //Console.WriteLine(myValue.ToShortTimeString()); //just the time without seconds
            //Console.WriteLine(myValue.ToLongDateString());  //date written out with day of week
            //Console.WriteLine(myValue.ToLongTimeString());  //time with seconds

            //Date-Time Math using helper methods

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());      //a ton of options for .Add such as days, hours, milliseconds, etc
            //Console.WriteLine(myValue.AddHours(5).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());      //to go into the past

            //Console.WriteLine(myValue.Month);     //tells the integer month

            //DateTime myBirthday = new DateTime(1987, 6, 1);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("6/1/1987");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
