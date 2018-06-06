using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BookDbInitializer: DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Author = "Чип и Дейл", Name = "Семья Вагин", Price = 42 });
            db.Books.Add(new Book { Author = "Валя", Name = "Кошка-енот", Price = 15 });
            db.Books.Add(new Book { Author = "Хуяля", Name = "Дочь петуха", Price = 28 });
        }
    }
}