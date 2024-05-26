using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_07
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 1;
            month = 1;
            year = 2000;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month; 
            this.year = year;
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter Day");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayDate()
        {
            Console.WriteLine("Day - "+ day);
            Console.WriteLine("Month - " + month);
            Console.WriteLine("Year - " + year);
        }

        public string DateString()
        {
            return "Date - "+day+"/"+month+"/"+year;
        }
    }
}
