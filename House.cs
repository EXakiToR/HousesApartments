using System;

namespace House;

public class House(int Floors, List<Apartment> Apartments)
{

    public int TopPrice { get; }
    public List<Apartment> Apartments { get; set; } = Apartments;
    public int Floors { get; set; } = Floors;

    public List<Apartment> ValidApartments(List<Apartment> apartments)
    {
        //todo: need implementation
        return null;
    }

};
