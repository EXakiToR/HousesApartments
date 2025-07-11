using System;

namespace House;

public class House(int Floors, List<Apartment> Apartments)
{
  public int Floors { get; init; } = Floors;
  public List<Apartment> Apartments { get; init; } = Apartments ?? [];
  public int TopPrice { get; }

  //   public List<Apartment> ValidApartments(List<Apartment> apartments)
  //   {
  //       // TODO: Need implementation
  //       return null;
  //   }
}
