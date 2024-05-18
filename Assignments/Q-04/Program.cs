namespace Q_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails(student.MyName, student.MyGender, student.MyAge, student.MyStd,student.MyDiv, student.MyMarks);
        }

        struct Student
        {
            private string name;
            private bool gender;
            private int age;
            private int std;
            private char div;
            private double marks;

            public Student(string name, bool gender, int age, int std, char div, double marks)
            {
                this.name = name;
                this.gender = gender;
                this.age = age;
                this.std = std;
                this.div = div;
                this.marks = marks;
            }

            public string MyName
            {
                get { return name; }
                set { name = value; }
            }

            public bool MyGender
            {
                get { return gender; }
                set { gender = value; }
            }

            public int MyAge
            {
                get { return age; }
                set { age = value; }
            }

            public int MyStd
            {
                get { return std; }
                set { std = value; }
            }

            public char MyDiv
            {
                get { return div; }
                set { div = value; }
            }

            public double MyMarks
            {
                get { return marks; }
                set { marks = value; }
            }

            public void AcceptDetails()
            {
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter Gender 0. Male, 1. Female");
                if(Console.ReadLine()== "0")
                {
                    gender = true;
                }
                else
                {
                    gender = false;
                }
                Console.WriteLine("Enter Age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter std");
                std = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Div");
                div = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter Marks");
                marks = Convert.ToDouble(Console.ReadLine());
            }

            public void PrintDetails(string name, bool gender, int age, int std, char div, double marks)
            {
                Console.WriteLine("Name - " + name);
                if (gender)
                {
                    Console.WriteLine("Gender - Female");
                }
                else
                {
                    Console.WriteLine("Gender - Male");
                }
                Console.WriteLine("Age - " + age);
                Console.WriteLine("Std - " + std);
                Console.WriteLine("Div - " + div);
                Console.WriteLine("Marks - " + marks);
            }
        }
    }
}
