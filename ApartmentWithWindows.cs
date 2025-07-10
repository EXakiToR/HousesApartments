using System;

namespace House;

public record ApartmentWithWindows(int Floor, float Area) : Apartment(Floor, Area)
{
    public bool HasWindows { get; } = true;
};
