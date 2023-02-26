using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal static class FindAndReplaceManager
    {
        static int stay = -1;
           public static void FindNext(string find)
        {
            Book book = new Book();
            stay  = book.Text.IndexOf(find);
            if (stay > -1)
            {
                Console.WriteLine("Text in index {0} and end {1}", stay - 1, stay + find.Length - 1) ;
            }

            
            //text.Contains(str);
        }

    }
}
