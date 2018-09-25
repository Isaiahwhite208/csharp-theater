using System;
using ConsoleTheater.Models;

namespace ConsoleTheater
{
 class Program
 {
  static void Main(string[] args)
  {
   Theater myTheater = new Theater("Isaiah's Illusionary Films");
   myTheater.Initialize();
   Movie titanic = new Movie("Titanic");
   // myTheater.Movies.Add(titanic);
   myTheater.AddRoom(titanic, 100);
   myTheater.AddShowtime("12:00", 0);
   myTheater.PrintMovies();
  }
 }
}
