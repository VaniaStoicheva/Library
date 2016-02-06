using System;
using System.Collections.Generic;
using System.Linq;

enum SearchOption { NameOfBook, Author }
enum DisplayOption { NameOfBook, Author }

class Library
{
    string name;
    List<Book> bookList;

    public Library(string name, List<Book> bookList = null)
    {
        this.name = name;

        if (bookList == null)
        {
            this.bookList = new List<Book>();
        }
        else
        {
            this.bookList = bookList;
        }
        
    }

    public string Name
    {
        get
        {
            return Name;
        }

        set
        {
            this.name = value;
        }
    }


    public void Add(Book someBook)
    {
        this.bookList.Add(someBook);
    }

    public int IndexOf(string name, int startIndex, SearchOption opt)
    {
        int foundIndx = -1;

        name = name.Trim();


        for (int i = startIndex; i < this.bookList.Count; i++)
        {

            if (opt == SearchOption.Author)
            {
                if (this.bookList[i].Author == name)
                {
                    foundIndx = i;
                }
            }
            else
            {
                if (this.bookList[i].Title == name)
                {
                    foundIndx = i;
                }
            }
        }

        return foundIndx;
    }


    public void Display(string name, DisplayOption opt)
    {
        Console.WriteLine("{0,-3}|{1,-15}|{2,-15}", "N", "Title", "Author");
        for (int i = 0; i < this.bookList.Count; i++)
        {

            if (opt == DisplayOption.Author)
            {
                if (this.bookList[i].Author == name)
                {
                    Console.WriteLine("{0,-3}|{1,-15}|{2,-15}", i + 1, bookList[i].Title, bookList[i].Author);
                }
            }
            else
            {
                if (this.bookList[i].Title == name)
                {
                    Console.WriteLine("{0,-3}|{1,-15}|{2,-15}", i + 1, bookList[i].Title, bookList[i].Author);
                }
            }
        }
    }
    
    public void DisplayAll()
    {
        int count = 1;
        
        Console.WriteLine("{0,-3}|{1,-15}|{2,-15}","N","Title","Author");
        foreach (Book elem in this.bookList)
        {
            Console.WriteLine("{0,-3}|{1,-15}|{2,-15}",count, elem.Title, elem.Author);
            count++;
        }

    }

    public void DeleteAt(int index)
    {
        this.bookList.RemoveAt(index);
    }
}

