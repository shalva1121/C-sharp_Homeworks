namespace lesson12_homework
{
    internal class Movie : IComparable<Movie>
    {
        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }

        public string Title { get; set; }
        public int Year { get; set; }

        public int CompareTo(Movie? other)
        {
            return this.Year.CompareTo(other.Year);
        }

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
