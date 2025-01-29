using System;

class Book
{
    // Поля для зберігання даних про книгу
    private string title; // Назва книги
    private string author; // Автор книги
    private int year; // Рік публікації

    // Конструктор за замовчуванням
    public Book()
    {
        title = "Невідома книга";
        author = "Невідомий автор";
        year = 0;
    }

    // Конструктор із параметром для назви
    public Book(string title) : this()
    {
        this.title = title; // Використовуємо this для уточнення, що змінюємо поле класу
    }

    // Конструктор із параметрами для назви, автора та року публікації
    public Book(string title, string author, int year) : this(title)
    {
        this.author = author; // Встановлюємо автора
        this.year = year;     // Встановлюємо рік публікації
    }

    // Метод для відображення інформації про книгу
    public void DisplayInfo()
    {
        Console.WriteLine($"Назва: {title}, Автор: {author}, Рік: {year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта за замовчуванням
        Book defaultBook = new Book();
        defaultBook.DisplayInfo();

        // Створення об'єкта з вказаною назвою
        Book namedBook = new Book("Мистецтво війни");
        namedBook.DisplayInfo();

        // Створення об'єкта з повною інформацією
        Book fullInfoBook = new Book("1984", "Джордж Орвелл", 1949);
        fullInfoBook.DisplayInfo();
    }
}