namespace Q_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Date date = new Date();
            Person person = new Person();

            person.AcceptPerson();
            person.DisplayPerson();
            Console.WriteLine(person.PersonString());
        }
    }
}
