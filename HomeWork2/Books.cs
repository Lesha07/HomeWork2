namespace HomeWork2;

public class Book
{
    public string NameBook { get; set; }
    public string AuthorBook { get; set; }
    public string PublisherBook { get; set; }
    
    public Book(string nameBook, string authorBook, string publisherBook)
    {
        NameBook = nameBook;
        AuthorBook = authorBook;
        PublisherBook = publisherBook;
    }

    public override string ToString()
    {
        return $"Название: {NameBook}, Автор: {AuthorBook}, Издательство: {PublisherBook}";
    }
}

public class Libary
{

    public List<Book> books { get; set; } = new List<Book>();

    public void AddBooks(Book book)
    {
        books.Add(book);
    }

    public void RemoveBooks(string nameBook)
    { 
        var bookToRemove = books.FirstOrDefault(x => x.NameBook.Equals(nameBook, StringComparison.OrdinalIgnoreCase));
        
        if (bookToRemove != null) 
        {
            books.Remove(bookToRemove);
           
            Console.WriteLine($"Вы успешно взяли книгу {nameBook}");
        }
        else
        { 
            Console.WriteLine($"Упс, не удалось найти книгу {nameBook} :(");
        }
    }

    public void FindBooks(string query)
    {
        var findBooks = books.FindAll(b =>
            b.NameBook.Contains(query, StringComparison.OrdinalIgnoreCase) ||
            b.AuthorBook.Contains(query, StringComparison.OrdinalIgnoreCase) ||
            (b is Book book && 
             book.PublisherBook.Contains(query, StringComparison.OrdinalIgnoreCase))
        );

        if (findBooks.Count > 0)
        {
            foreach (var book in findBooks)
            {
                Console.WriteLine($"Книга {book} упешно найдена!");
            }
        }
        else
        {
            Console.WriteLine("Соре такой книги нема");
        }
    }
    public void UpdatePublisher(string nameBook, string newPublisher) 
    { 
        var bookToUpdate = books.Find(x => x.NameBook.Equals(nameBook, StringComparison.OrdinalIgnoreCase));
        
        if (bookToUpdate != null) 
        { 
            bookToUpdate.PublisherBook = newPublisher; 
            Console.WriteLine($"Издательство книги \"{nameBook}\" успешно изменено на \"{newPublisher}\"!"); 
        }
        else 
        { 
            Console.WriteLine("Упс, книгу не удалось найти.");
        }
    }
       
    public void DisplayBooks()
    {
        Console.WriteLine("Список всех книг в библиотеке:");

        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}
