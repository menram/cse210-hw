// ================================================================================================
// Exceeded Requirements by implementing the following stretch challenge:
// Randomly select from only those words that are not already hidden
// ================================================================================================
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        string readLine = "";
        // Scripture scripture1 = new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Scripture scripture1 = new Scripture(new Reference("2 Nephi", 9, 28, 29), "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish; But to be learned is good if they hearken unto the counsels of God.");
        Console.Clear();
        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        readLine = Console.ReadLine();
        while (!(scripture1.IsCompletelyHidden() || readLine == "quit"))
        {
            scripture1.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            readLine = Console.ReadLine();
        }
    }
}