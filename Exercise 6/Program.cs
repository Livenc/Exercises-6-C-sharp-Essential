namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Console.WriteLine("{0} + {1} = {2}", a, b, Calculator.Add(a, b));
            Console.WriteLine("{0} - {1} = {2}", a, b, Calculator.Subtract(a, b));
            Console.WriteLine("{0} * {1} = {2}", a, b, Calculator.Multiply(a, b));
            Console.WriteLine("{0} / {1} = {2}", a, b, Calculator.Divide(a, b));

            try
            {
                int c = Calculator.Divide(a, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}