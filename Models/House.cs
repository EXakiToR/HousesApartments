using System;

namespace HousesApartments.Models;

public class House(int Floors, List<Apartment> Apartments)
{
  public int Floors { get; init; } = Floors;
  public List<Apartment> Apartments { get; init; } = Apartments ?? [];
  // public int TopPrice;
  public static double GetTopPrice(List<Apartment> apartments)
  {
    if (apartments != null)
    {
      double maxPrice = apartments[0].Price;
      foreach (var apt in apartments)
      {
        maxPrice = apt.Price > maxPrice ? apt.Price : maxPrice;
      }
      return maxPrice;

    }
    else
    {
      throw new NullReferenceException("Null apartments");
    }
  }

  // public List<Apartment> ValidApartments(List<Apartment> apartments)
  // {

  //     return List<Apartment> apartments where apartment HasGarden || hasPool && apartments.Price <= 4e+3;
  // }
}
