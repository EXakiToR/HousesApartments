using System;

namespace HousesApartments.Models;

public class ApartmentWithGarden : ApartmentWithWindows
{
    public bool HasGarden { get; } = true;
    public ApartmentWithGarden(int floor, double area) : base(floor, area)
    {
        Price += 2e+4;
    }

};
