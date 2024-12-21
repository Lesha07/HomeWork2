using HomeWork2;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Добро пожаловать в библиотеку!!");
        
        Libary libary = new Libary();
        
        libary.AddBooks(new Book("Мастер и Маргарита","Булгаков", "АДЕФ-Украина") );
        
        libary.AddBooks(new Book("Игра престолов", "Джордж Р. Р. Мартин", 
            "Bantam Spectra Voyager Books"));
        
        bool ProgramRun = true;

        while (ProgramRun)
        {
            Console.WriteLine("\n0. Посмотреть все книги " +
                              "\n1. Добавить книгу в библиотеку. " +
                              "\n2. Взять книгу из библиотеки. " +
                              "\n3. Поиск книги по автору, названию или изданию. " +
                              "\n4. Переименновать издание." +
                              "\n5. Закрыть библиотеку");

            Console.WriteLine("Выберите действие:");
            
            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    
                    Console.Clear();
                    
                    libary.DisplayBooks();
                    break;
                
                case "1":
                    
                    Console.Clear();
                    
                    Console.WriteLine("Введите название книги: ");
                    string? nameBook = Console.ReadLine();

                    Console.WriteLine("Введите имя автора: ");
                    string? authorBook = Console.ReadLine();

                    Console.WriteLine("Введите издателя: ");
                    string? publisherBook = Console.ReadLine();
                    
                    Book newBook = new Book(nameBook, authorBook, publisherBook);
                    libary.AddBooks(newBook);
                    
                    Console.WriteLine("Книга успешно добавлена!");
                    break;
                    
                case "2":
                    Console.Clear();
                    
                    Console.WriteLine("Выберие книгу которую вы хотите взять:");
                    string? bookToRemove = Console.ReadLine();
                    
                    libary.RemoveBooks(bookToRemove);
                    break;
                
                case "3":
                    
                    Console.Clear();
                    
                    Console.Write("Введите название книги, автора или издательство для поиска: ");
                    string query = Console.ReadLine();
                    
                    libary.FindBooks(query);
                    break;
                   
                case "4":
                   
                    Console.Clear();
                    
                    Console.WriteLine("Введетие название книги, издание которой вы хотите изменить: ");
                    string NameBook = Console.ReadLine();
                    
                    Console.WriteLine("Введите название нвого издательства: "); 
                    string newPublisher = Console.ReadLine();

                    libary.UpdatePublisher(NameBook, newPublisher);
                    
                    break;
                
                case "5":
                    ProgramRun = false;
                    Console.WriteLine("Выходим.....");
                    break;
            }
            
            Console.WriteLine("Спасибо за выбор нашей библиотки, ждём вас снова. Пока!");
        }
    }
}