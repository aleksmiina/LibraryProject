
public class LibraryItems 
{
    string[] historyBooksInStorage = {
            "The History of Rome by Titus Livy",
            "The Twelve Caesars by Suetonius",
            "The Annals of Imperial Rome by Tacitus",
            "Rubicon: The Last Years of the Roman Republic by Tom Holland",
            "SPQR: A History of Ancient Rome by Mary Beard",
            "The Decline and Fall of the Roman Empire by Edward Gibbon",
            "Augustus: The Life of Rome's First Emperor by Anthony Everitt",
            "The Storm Before the Storm: The Beginning of the End of the Roman Republic by Mike Duncan",
            "Cicero: The Life and Times of Rome's Greatest Politician by Anthony Everitt",
            "Rome's Last Citizen: The Life and Legacy of Cato, Mortal Enemy of Caesar by Rob Goodman and Jimmy Soni"
        };
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
    }
}

// how will my library look like? It will have a list of books. User would be able to borrow a book from it.
// so, I need to create a list of books for now.
// then user will be able via console.readline to ask for a book and borrow it.
// how to store books? list or array? 
// when a book is borrowed, it should be removed from the list. The user should have a possibility to return the book and the list we be updated.
// I need to figure out the way of store these books. 
// the list should include separate authors, names, etc. 