using ConsoleTheater.Interfaces;

namespace ConsoleTheater.Modals
{
 public class Ticket : IPurchasable
 {
  public string Time { get; set; }
  public Movie Movie { get; set; }
  public decimal Price { get; set; }
  public string Type { get; set; }

  public Ticket(string time, Movie movie, decimal price)
  {
   Time = time;
   Movie = movie;
   Price = price;
   Type = "Ticket";
  }

  public void PrintName()
  {
   System.Console.WriteLine($"Purchase of {Ticket} for {Price}");
  }
 }
}