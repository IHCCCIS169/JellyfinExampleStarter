using JellyfinStarter;
using static System.Console;

//NOTE: Errors in this class are due to Movie and Show classes not being completed. 

var another = true;
WriteLine("Welcome to Jellyfin \ud83e\udebc Entry System");
do
{
    WriteLine("Is this entry a Movie or Show?");
    WriteLine("1. Movie \ud83c\udfa5");
    WriteLine("2. TV Show \ud83d\udcfa");
    WriteLine("3. Exit");
    Write("Choice: ");
    var choice = ReadLine();
    if (!int.TryParse(choice, out var choiceInt) || choiceInt < 1 || choiceInt > 3)
    {
        WriteLine("Invalid input. Please enter  1,  2, or  3.");
        continue;
    }

    switch (choiceInt)
    {
        case 1:
            // Movie Entry
            // var movie = new Movie
            // {
            //     Title = GetMovieTitle("Enter Movie Title: "),
            //     Minutes = GetMinutes("Enter Movie Minutes: ")
            // };
            // movie.SetRating(GetInputRating("Enter Movie Rating: \"G\",\"PG\",\"PG-13\", or \"R\"\n Choice: "));
            
            // WriteLine(movie.ToString());
            break;

        case 2:
            //TODO Add TV show entry system 
            WriteLine("Sorry not implemented yet \ud83d\ude41");
            throw new NotImplementedException();
            break;
        case 3:
            WriteLine("Goodbye");
            another = false;
            break;
    }
} while (another);


return;

int GetMinutes(string prompt)
{
    int result;
    do
    {
        Write(prompt);
        var input = ReadLine();
        if (int.TryParse(input, out result))
        {
            break;
        }

        WriteLine("Invalid input. Please enter a number greater then one.");
    } while (true);

    return result;
}

string GetInputRating(string prompt)
{
    string result;
    do
    {
        Write(prompt);
        var input = ReadLine();
        if (input is "G" or "PG" or "PG-13" or "R")
        {
            result = input;
            break;
        }
        WriteLine("Invalid input. Please enter \"G\", \"PG\", \"PG-13\" or \"R\".");
    } while (true);

    return result;
}

string GetMovieTitle(string prompt)
{
    do
    {
        Write(prompt);
        var input = ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            return input;
        }
        else //dont' need the else 
        {
            WriteLine("Invalid input. Title can't be null");
        }
    } while (true);
}