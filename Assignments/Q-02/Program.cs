namespace Q_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(args[0]);
            int num2 = Convert.ToInt32(args[2]);
            switch (args[1]) 
            {
                case "+":
                    Console.WriteLine("Addition is = "+ (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Subtraction is = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Multiplication is = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("Division is = " + (num1 / num2));
                    break;
            }
        }
    }
}
