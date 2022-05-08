using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _06._05._22_homework.Models
{
    class Library
    {
        
        public List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }
        
        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> Books = books.FindAll(b => b.Name.ToLower().Contains(value.ToLower()));
            return Books;
            
        }
        public void RemoveAllBookByName(string a)
        {
            books.RemoveAll(b => b.Name.ToLower().Contains(a.ToLower()));
        }
        public List<Book> SearchBooks(string value) 
        {
            List<Book> Books = books.FindAll(b => b.Name.ToLower() == value.ToLower() || b.AuthorName.ToLower() == value.ToLower() || b.PageCount.ToString().ToLower() == value.ToLower());
            return books;
        }
        public List<Book> FindAllBooksByPageCountRange(int minimum , int maxnumum) 
        {
            return books.FindAll(b => b.PageCount >= minimum && b.PageCount <= maxnumum);
        }
        public void RemoveByNo(string value) 
        {
            books.RemoveAll(b => b.code.ToLower() == value.ToLower());
        }
    }
}
