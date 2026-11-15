using System;
using System.Collections.Generic;
using System.Text;

namespace lesson12_homework
{
    internal class Movie
    {
        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }

        public string Title { get; set; }
        public int Year { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Movie movie
               && Title == movie.Title
               && Year == movie.Year;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
