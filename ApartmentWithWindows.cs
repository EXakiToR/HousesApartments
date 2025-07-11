using System;

namespace House;

public class ApartmentWithWindows(int Floor, double Area) : Apartment(Floor, Area)
{
    public bool HasWindows { get; } = true;


};
