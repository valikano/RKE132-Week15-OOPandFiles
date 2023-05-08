List<Movie> myMovies = new List<Movie>();

string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tepArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tepArray[0], tepArray[2]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\data\movies.txt";


    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.Write(line);
    }
}


class Movie
{
    string title; //fields
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }
    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}
