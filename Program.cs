public class Book 
{
    public string? Author { get; set; }
    public string? BookName { get; set; }
    public int YearOfPublishing { get; set; }
}
public class LibraryItems
{
     List<Book> romanHistoryBooks;

    public LibraryItems()
    {
        romanHistoryBooks = new List<Book>
        {
            new Book { Author = "Mary Beard", BookName = "SPQR: A History of Ancient Rome", YearOfPublishing = 2015 },
            new Book { Author = "Tom Holland", BookName = "Rubicon: The Last Years of the Roman Republic", YearOfPublishing = 2003 },
            new Book { Author = "Adrian Goldsworthy", BookName = "Caesar: Life of a Colossus", YearOfPublishing = 2006 },
            new Book { Author = "Edward Gibbon", BookName = "The History of the Decline and Fall of the Roman Empire", YearOfPublishing = 1776 },
            new Book { Author = "Anthony Everitt", BookName = "Cicero: The Life and Times of Rome's Greatest Politician", YearOfPublishing = 2001 }
        };
    }



}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
    }
}

// okay, looks like that I have messed the structure and I need to think more logically. 
// we have a library which stores books. Books have their own properties like author, book name, year of publishing. 

// then, I could create a class called LibraryItems and store a list of books in it.