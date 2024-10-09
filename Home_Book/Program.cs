using System;
using System.Reflection;

namespace Home_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fullInfo = true;

            //Задание первое
            Book bookTask1 = new Book();
            bookTask1.Title = "1984";
            bookTask1.Author = "George Orwell";
            bookTask1.Year = 1949;
            bookTask1.ISBN = "978-0-452-28423-4";

            Book bookTask2 = new Book();
            bookTask2.Title = "The Master and Margarita";
            bookTask2.Author = "Mikhail Bulgakov";
            bookTask2.Year = 1967;
            bookTask2.ISBN = "978-5-17-027948-1";

            Book bookTask3 = new Book();
            bookTask3.Title = " Eneida";
            bookTask3.Author = "Ivan Kotliarevsky";
            bookTask3.Year = 1798;
            bookTask3.ISBN = "978-966-155-386-7";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ЗАДАНИЕ ПЕРВОЕ");
            Console.ResetColor();
            Console.WriteLine($"Название книги: {bookTask1.Title}, Автор: {bookTask1.Author}, Год: {bookTask1.Year}, ISBN: {bookTask1.ISBN}");
            Console.WriteLine($"Название книги: {bookTask2.Title}, Автор: {bookTask2.Author}, Год: {bookTask2.Year}, ISBN: {bookTask2.ISBN}");
            Console.WriteLine($"Название книги: {bookTask3.Title}, Автор: {bookTask3.Author}, Год: {bookTask3.Year}, ISBN: {bookTask3.ISBN}");
            Console.WriteLine("______________________________________________________________________________________________________________");


            //Задание второе
            EBook book1 = new EBook("The Jungle Book", "Rudyard Kipling", 1984, " 978-1503215197");
            EBook book2 = new EBook("The Hound of the Baskervilles", "Arthur Conan Doyle", 1902);
            EBook book3 = new EBook();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ЗАДАНИЕ ВТОРОЕ");
            Console.ResetColor();
            Console.WriteLine($"Название книги: {book1.Title}, Автор: {book1.Author}, Год: {book1.Year}, ISBN: {book1.ISBN}");
            Console.WriteLine($"Название книги: {book2.Title}, Автор: {book2.Author}, Год: {book2.Year}, ISBN: {book2.ISBN}");
            Console.WriteLine($"Название книги: {book3.Title}, Автор: {book3.Author}, Год: {book3.Year}, ISBN: {book3.ISBN}");
            Console.WriteLine("______________________________________________________________________________________________________________");

            //задание третье
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ЗАДАНИЕ ТРЕТЬЕ");
            Console.ResetColor();

            EBookNew booknew = new EBookNew("1984", "George Orwell", 1949, "978-0-452-28423-4");
            
            EBookNew booknew1 = new EBookNew("The Master and Margarita", "Mikhail Bulgakov");
           
            
            booknew.GetBookInfo(fullInfo);
            booknew1.GetBookInfo();
           

            //задание четвертое
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ЗАДАНИЕ ЧЕТВЕРТОЕ");
            Console.ResetColor();
            EBookNew booknew3 = new EBookNew();
            booknew3.UpdateBook();
            booknew3.UpdateBook(author: "Joan", year : 1983);
            
        }
        //Задание первое
        internal class Book
        {
            //поля класса
            internal string Title { get; set; }
            internal string Author { get; set; }
            internal int Year { get; set; }
            internal string ISBN { get; set; }
        }

        //Задание второе: модифицируем класс Book, создав наследуемый класс.
        internal class EBook : Book
        {
            //параметризованный конструктор класса, который имеет один необязательный параметр
            internal EBook(string title, string author, int year, string isbn = "Неизвестно")
            {
                Title = title;
                Author = author;
                Year = year;
                ISBN = isbn;
            }

            //конструктор по умолчанию
            internal EBook()
            {
                Title = "Неизвестно";
                Author = "Неизвестно";
                Year = 0;
                ISBN = "000-0-00-000000-0";
            }
        }

        //Задание третье
        internal class EBookNew
        {
            internal string Title { get; set; }
            internal string Author { get; set; }
            internal int Year { get; set; }
            internal string ISBN { get; set; }


            internal EBookNew() 
            {
                
            }

            internal EBookNew(string title, string author, int year, string isbn)
            {
                Title = title;
                Author = author;
                Year = year;
                ISBN = isbn;
            }

            internal EBookNew(string title, string author)
            {
                Title = title;
                Author = author;
            }

           
            internal void GetBookInfo(bool fullInfo)
            {
                Console.WriteLine($"Название книги: {Title}, Автор: {Author}, Год: {Year}, ISBN: {ISBN}");
            }
        

            internal void GetBookInfo()
            {
                Console.WriteLine($"Название книги: {Title}, Автор: {Author}");
            }

            //Задание четвертое
            internal void UpdateBook(string title = null, string author = null, int year = 0, string isbn = null)
            {
                if (title != null)
                {
                    Title = title;
                }
                if (author != null)
                {
                    Author = author;
                }
                if (year != 0)
                {
                    Year = year;
                }
                if (isbn != null)
                {
                    ISBN = isbn;
                }

                Console.WriteLine($"Название книги: {Title}, Автор: {Author}, Год: {Year}, ISBN: {ISBN}");
            }

        }
    }
}





           




   




