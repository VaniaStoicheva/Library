using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Book
{

    public Book(string title, string author, string publisher = "unknow", DateTime? date = null, string isbn = "unknow")
    {
        this.Title = title;
        this.Author = author;
        this.Publisher = publisher;
        
        if (date == null)
        {
            this.PublishedDate = DateTime.Now;
        }
        else
        {
            this.PublishedDate = (DateTime)date;
        }
        
        
        this.ISBN = isbn;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime PublishedDate { get; set; }
    public string ISBN { get; set; }


}

