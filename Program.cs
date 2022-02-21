using System;
using System.Collections.Generic;
using Dealership.Models;
namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);

      List<Car> Cars = new List<Car>{volkswagen,yugo,ford,amc};
      Console.WriteLine("Enter Maximum Budjet Price");
      string stringMaxPrice=Console.ReadLine();
      int maxPrice= int.Parse(stringMaxPrice);
      List<Car> CarsMatchingSearch = new List<Car>(0);
      foreach(Car automobile in Cars){
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }

      }
      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("==================");
        Console.WriteLine("The nmodel is"+automobile.MakeModel);
        Console.WriteLine("The price is"+automobile.Price);
        Console.WriteLine("The mile"+automobile.Miles);
      }



    }
  }
}
