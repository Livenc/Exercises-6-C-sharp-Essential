namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            FindAndReplaceManager.FindNext("of");
           Book.Notes  notes = new Book.Notes();
            notes.Add("asdasd");
            notes.Show();
           
            Console.ReadLine();
        }
    }
}