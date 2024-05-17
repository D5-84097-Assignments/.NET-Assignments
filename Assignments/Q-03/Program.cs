namespace Q_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                choice = Menu();
                if (choice != 0)
                {
                    Console.WriteLine("Enter value of num1");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter value of num2");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Thank You...!");
                            break;
                        case 1:
                            Console.WriteLine("Addition is =" + (num1 + num2));
                            break;
                        case 2:
                            Console.WriteLine("Subtraction is =" + (num1 - num2));
                            break;
                        case 3:
                            Console.WriteLine("Multiplication is =" + (num1 * num2));
                            break;
                        case 4:
                            Console.WriteLine("Division is =" + (num1 / num2));
                            break;
                        default:
                            Console.WriteLine("Enter correct choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Thank You...!");
                }
            } while (choice != 0);
        }

        static public int Menu()
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("0. EXIT");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
