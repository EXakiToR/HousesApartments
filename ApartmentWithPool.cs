using System;


namespace House;

public record ApartmentWithPool(int Floor, float Area) : ApartmentWithWindows(Floor, Area)
{
    public bool HasPool { get; } = true;
};
