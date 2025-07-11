using System;

namespace HousesApartments.Models;

public class ApartmentWithWindows(int Floor, double Area) : Apartment(Floor, Area)
{
    public bool HasWindows { get; } = true;


};
