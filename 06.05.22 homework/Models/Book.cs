using System;
using System.Collections.Generic;
using System.Text;

namespace _06._05._22_homework.Models
{
    class Book
    {

        public string code { get; set; }
        public string Name { get; set; }
        private static int count;
        public string AuthorName { get; set; 
        }

        public int PageCount { get; set; }
        List<Book> books = new List<Book>(); 
        static Book()
        {
            count = 1;
        }
        public Book(string name, string authotname, int pagecount) 
        {
            books = new List<Book>();
            Name = name;
            AuthorName = authotname;
            PageCount = pagecount;
            count++;
            code = $"{name.Substring(0, 2).ToString() +name.Substring(2)}";
        }
        public override string ToString()
        {
            return $"{Name} {AuthorName} {PageCount} {code}";
        }
    }
}
