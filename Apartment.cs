using System;

namespace House;

public class Apartment(int Floor, double Area)
{
    public int Floor { get; init; } = Floor;
    public double Area { get; init; } = Area;
    public double Price { get; set; } = Math.Round(2e+4 * Area + (Floor > 1 ? 5e+3 * (Floor - 1) : 0), 2);

};
