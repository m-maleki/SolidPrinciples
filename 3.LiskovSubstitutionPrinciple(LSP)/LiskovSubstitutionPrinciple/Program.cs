using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class PrintedBook : Book
{
    public int PageCount { get; set; }

    public PrintedBook(string title, string author, int pageCount)
        : base(title, author)
    {
        PageCount = pageCount;
    }
}

class EBook : Book
{
    public string Format { get; set; }

    public EBook(string title, string author, string format)
        : base(title, author)
    {
        Format = format;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book printedBook = new PrintedBook("The Catcher in the Rye", "J.D. Salinger", 224);
        Book ebook = new EBook("1984", "George Orwell", "PDF");

        Console.WriteLine($"Printed book: {printedBook.Title} by {printedBook.Author}, {((PrintedBook)printedBook).PageCount} pages");
        Console.WriteLine($"E-book: {ebook.Title} by {ebook.Author}, Format: {((EBook)ebook).Format}");
    }
}