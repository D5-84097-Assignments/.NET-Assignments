using System.Drawing;
using System.Reflection;
using System.Xml.Linq;

namespace Q_05
{
    internal class Program
    {
        private static Student[] studentArray;
        static void Main(string[] args)
        {
            CreateArray();
            AcceptInfo();
            PrintInfo(studentArray);
            ReverseArray(studentArray);
        }

        struct Student
        {
            private string name;
            private bool gender;
            private int age;
            private int std;
            private char div;
            private double marks;

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
        }
        private static void CreateArray()
        {
            Console.WriteLine("Enter size of students array");
            int size = Convert.ToInt32(Console.ReadLine()); 
            studentArray = new Student[size];
        }

        private static void AcceptInfo()
        {
            for (int i = 0; i < studentArray.Length; i++)
            {
                Console.WriteLine("Enter Name");
                studentArray[i].MyName = Console.ReadLine();
                Console.WriteLine("Enter Gender 0. Male, 1. Female");
                if (Console.ReadLine() == "0")
                {
                    studentArray[i].MyGender = true;
                }
                else
                {
                    studentArray[i].MyGender = false;
                }
                Console.WriteLine("Enter Age");
                studentArray[i].MyAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter std");
                studentArray[i].MyStd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Div");
                studentArray[i].MyDiv = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter Marks");
                studentArray[i].MyMarks = Convert.ToDouble(Console.ReadLine());
            }
                
        }

        private static void PrintInfo(Student[] studentArray)
        {
            foreach (Student student in studentArray)
            {
                Console.WriteLine("Name - " + student.MyName);
                if (student.MyGender)
                {
                    Console.WriteLine("Gender - Male");
                }
                else
                {
                    Console.WriteLine("Gender - Female");
                }
                Console.WriteLine("Age - " + student.MyAge);
                Console.WriteLine("Std - " + student.MyStd);
                Console.WriteLine("Div - " + student.MyDiv);
                Console.WriteLine("Marks - " +  student.MyMarks);
            }
                
        }

        private static void ReverseArray(Student[] studentArray)
        {
            Student[] reverseArray = new Student[studentArray.Length];  
            for (int i = 0; i < reverseArray.Length; i++)
            {
                reverseArray[i] = studentArray[studentArray.Length-i-1];
                Console.WriteLine("Name -" + reverseArray[i].MyName);
                if (reverseArray[i].MyGender)
                {
                    Console.WriteLine("Gender - Male");
                }
                else
                {
                    Console.WriteLine("Gender - Female");
                }
                Console.WriteLine("Age -" + reverseArray[i].MyAge);
                Console.WriteLine("Std -" + reverseArray[i].MyStd);
                Console.WriteLine("Div -" + reverseArray[i].MyDiv);
                Console.WriteLine("Marks -" + reverseArray[i].MyMarks);
            }
        }
        
    }
}
