using System;
using System.Collections.Generic;
using System.Linq;


namespace House;

class HouseProgram
{
    public static void Main(string[] args)
    {
        int totalFloors = 10; // Example: 10 floors in the house
        var apartments = GenerateRandomApartments(10, totalFloors); // Generate 10 apartments
        var house = new House(apartments, totalFloors);
        Console.WriteLine($"House with {house.Floors} floors, {apartments.Count} apartments:");
        foreach (var apt in apartments)
        {
            Console.WriteLine(apt);
        }
    }

    private static List<Apartment> GenerateRandomApartments(int count, int totalFloors)
    {
        var random = new Random();
        var apartments = new List<Apartment>();

        for (int i = 0; i < count; i++)
        {
            int floor = random.Next(1, totalFloors + 1); // Floors 1 to totalFloors
            float area = (float)Math.Round(random.Next(30, 151) + random.NextDouble(), 2); // 30.0-150.99 m²
            bool hasWindows = random.Next(0, 2) == 0; // Randomly true/false for floors 2 to (totalFloors-1)

            Apartment apt = floor switch
            {
                1 => random.Next(0, 2) == 0
                    ? new ApartmentWithGarden(floor, area) // Ground floor: 50% chance of garden (has windows)
                    : new ApartmentWithWindows(floor, area), // Ground floor: windows only
                var f when f == totalFloors => random.Next(0, 2) == 0
                    ? new ApartmentWithPool(floor, area) // Top floor: 50% chance of pool (has windows)
                    : new ApartmentWithWindows(floor, area), // Top floor: windows only
                _ => hasWindows
                    ? new ApartmentWithWindows(floor, area) // Middle floors: random windows
                    : new Apartment(floor, area) // Middle floors: no windows
            };

            apartments.Add(apt);
        }

        return apartments;
    }
}
