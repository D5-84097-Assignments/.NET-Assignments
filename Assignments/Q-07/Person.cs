using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_07
{
    
    internal class Person
    {
        private string name;
        private bool gender;
        private Date birth;
        private string address;

        Date date = new Date();
        public Person()
        {
            birth = new Date();
        }

        public Person(string name, bool gender, Date birth, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
        }

        public void AcceptPerson()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender 0.Male,1.Female");
            if(Console.ReadLine()=="0")
            {
                gender = true;
            }
            else
            {
                gender = false;
            }
            Console.WriteLine("Enter birthdate:");
            birth.AcceptDate();
            Console.WriteLine("Enter address");
            address = Console.ReadLine();
        }

        public void DisplayPerson()
        {
            Console.WriteLine("Name - " + name);
            if(gender)
            {
                Console.WriteLine("Gender - Male");
            }
            else
            {
                Console.WriteLine("Gender - Female");
            }
            Console.WriteLine("DOB- ");
            birth.DisplayDate();
            Console.WriteLine("Address - "+ address);
        }

        public string PersonString()
        {
            string gender1;
            if(gender)
            {
                gender1 = "Male";
            }
            else
            {
                gender1 = "Female";
            }
            return ("Name - "+ name + ", Gender - "+gender1 + ", DOB - "+ birth.DateString() + ", Address - "+ address);
        }
    }
}
