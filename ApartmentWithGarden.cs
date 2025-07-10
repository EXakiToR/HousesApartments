using System;

namespace House;

public record ApartmentWithGarden(int Floor, float Area) : ApartmentWithWindows(Floor, Area)
{
    public bool HasGarden { get; } = true;
};
