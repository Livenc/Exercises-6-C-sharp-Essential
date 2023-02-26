using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Book
    {
        string text = " Dr Tomas Streyer looked around the control room at his team of scientists and  engineers. He was excited and frightened but he tried to seem calm. In a few minutes, they might start to discover something amazing: how the universe began.\r\n\r\nHe looked out of the window at the beautiful blue summer sky and tried to breathe slowly.\r\n\r\n'Ready,' he said. He pressed the first button and the complicated computers and machines came to life.\r\n\r\n'Set,' he said. He pressed the second button and switched on the large particle accelerator that lay under the towns and fields of Switzerland. \r\n\r\n'Go,' he said. And, at exactly twelve o'clock, he pressed the final button.\r\n\r\nFor a second, he felt as if he was blind, because everything went completely black. Tomas shouted in shock, but the lights were already on again. That was not part of his plan. He had no idea what had just happened.\r\n\r\n'Everybody, check the systems!' he ordered. But nothing seemed to be wrong with them. The particle accelerator was working perfectly.  \r\n\r\n'Tomas,' said his assistant. 'Look outside.' She sounded afraid.\r\n\r\nThe perfect summer's day of five minutes ago had gone. Instead, the sky was darker than the blackest night. But that wasn't the worst thing. The sun wasn't there, and the moon and stars were also gone.\r\n\r\nPeople were shouting and screaming. They started calling their families on the telephone because they were afraid they had all gone too. Tomas felt as if it was hard to breathe, but he counted to ten and tried to breathe slowly. He sat at the main computer and started reading the information and numbers from his experiment. But he couldn’t find anything to explain what was happening. He ran out of the exit with the rest of his team until they were all outside the building. \r\n\r\nEveryone else in the building was outside, frightened and confused. They were using the screens and lights on their mobile phones to see better. Several people got in their cars and turned on the lights. They drove to the entrance to make a small area of light for everybody to stand together. The street lights turned on, but most people were still afraid. \r\n\r\nThen, almost twenty minutes after Tomas had started the particle accelerator, the sun was in the sky again. It was warm and yellow, and the black sky turned blue again. Everyone started laughing and dancing around, and Tomas felt as if he could breathe normally again. \r\n\r\nBut later, hours later, when the real night began, no one was happy. Because, although the moon rose again, there were no stars in the sky at all.";
        public string Text
        {
            get
            {
                return text;
            }
        }
        public class Notes
        {
            private List<string> notes = new List<string>();

            public void Add(string note)
            {
                notes.Add(note);
            }

            public void Show()
            {
                if (notes.Count > 0)
                {
                    Console.WriteLine("Notes:");
                    foreach (string note in notes)
                    {
                        Console.WriteLine("- {0}", note);
                    }
                }
                else
                {
                    Console.WriteLine("No notes.");
                }
            }
        }
    }
    
}