using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book
    {
        private string title;
        private int year;
        private List<string> author;

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Author = authors.ToList();
        }

        public string Title { get { return this.title; } set { this.title = value; } }

        public int Year { get { return this.year; } set { this.year = value; } }

        public List<string> Author { get { return this.author; } set { this.author = value; } }
    }
}
