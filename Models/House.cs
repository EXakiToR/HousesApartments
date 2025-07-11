using System;

namespace HousesApartments.Models;

public class House(int Floors, List<Apartment> Apartments)
{
  public int Floors { get; init; } = Floors;
  public List<Apartment> Apartments { get; init; } = Apartments ?? [];
  // public int TopPrice;
  public static double GetTopPrice(List<Apartment> apartments) =>
    apartments != null ? apartments.Max(apt => apt.Price) : 0;

  public static List<Apartment> SuitableApartments(List<Apartment> apartments)
  {
    return [.. apartments.Where(apt => (apt is ApartmentWithGarden || apt is ApartmentWithPool) &&
    apt.Price <= 5e+4)];
  }
}
