using Exercise_5;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5, 3, 8, 1, 7, 2 };
            myArray.SortAscending();
            foreach (int element in myArray)
            {
                Console.Write(element + " ");
            }

            Console.ReadLine();
        }
    }
}