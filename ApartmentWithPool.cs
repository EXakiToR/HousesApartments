using System;
using House;
namespace ApartamentWithPool;

public record ApartmentWithPool(int Floor, float Area) : ApartmentWithWindows(Floor, Area)
{
    public bool HasPool { get; } = true;
};
