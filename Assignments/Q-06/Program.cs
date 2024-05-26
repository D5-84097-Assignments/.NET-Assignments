namespace Q_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            Date date1 = new Date();
            date.AcceptDate();
            date.PrintDate(date.Day,date.Month,date.Year);
            Console.WriteLine(date.ToString(date.Day, date.Month, date.Year));
            if(date.IsValid(date.Day, date.Month, date.Year))
            {
                Console.WriteLine("Date is valid");
            }
            else
            {
                Console.WriteLine("Date is Invalid");
            }
            date1.AcceptDate();
            int difference = Date.YearDifference(date.Year,date1.Year);
            Console.WriteLine("Difference between years : "+ difference);
        }
    }

    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            this.day = 1;
            this.month = 4;
            this.year = 1999;
        }

        public Date(int day, int month, int year)
        {
            this.day=day;
            this.month=month;
            this.year=year;
        }

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public void AcceptDate()
        {
            Console.WriteLine("Enter day");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            Year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate(int day, int month, int year)
        {
            Console.WriteLine("Day - " + day);
            Console.WriteLine("Month - " + month);
            Console.WriteLine("Year - " + year);
        }

        public bool IsValid(int day, int month, int year)
        {
            if((day>0 && day<32)&&(month>0 && month<13)&&(year>0))
            {
                return true;
            }
            else
                return false;
        }

        public string ToString(int day, int month, int year)
        {
            return "Date is - " + day + "/" + month + "/" + year;
        }

        public static int YearDifference(int d1, int d2)
        {
            return Math.Abs(d1 - d2);
        }
    }
}
