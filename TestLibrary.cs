using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class TestLibrary
{
    static void Main(string[] args)
    {
        Book firstBook = new Book("C#", "Svetlin Nakov");
        Book secondBook = new Book("Java", "Svetlin Nakov");
        Book thirdBook = new Book(".NET", "Svetlin Nakov");
        Book fourthBook = new Book("Ice and fire", "George Martin");

        Library telerikLib = new Library("Telerik Library");
        
        
        telerikLib.Add(firstBook);
        telerikLib.Add(secondBook);
        telerikLib.Add(thirdBook);
        telerikLib.Add(fourthBook);
        Console.WriteLine("Display library :");
        telerikLib.DisplayAll();

        int startIndx = 0;
        int indxFound;

        while (telerikLib.IndexOf("Svetlin Nakov", startIndx, SearchOption.Author) != -1)
        {
            indxFound = telerikLib.IndexOf("Svetlin Nakov", startIndx, SearchOption.Author);
            telerikLib.DeleteAt(indxFound);
        }
        Console.WriteLine("\nAfter deleting :");
        telerikLib.DisplayAll();
    }
}

