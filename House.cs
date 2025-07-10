using System;

namespace House;

public class House(List<Apartment> Apartments, int Floors)
{

    public int TopPrice { get; }
    public List<Apartment> Apartments { get; set; } = Apartments;
    public int Floors { get; set; } = Floors;

    public List<Apartment> ValidApartments(List<Apartment> apartments)
    {
        return null;
    }

};
