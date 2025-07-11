using System;


namespace HousesApartments.Models;

public class ApartmentWithPool : ApartmentWithWindows
{
    public bool HasPool { get; } = true;

    public ApartmentWithPool(int floor, double area) : base(floor, area)
    {
        Price += 3e+4;
    }

};
