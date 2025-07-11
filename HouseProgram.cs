using System;
using System.Collections.Generic;
using System.Linq;
using static House.HouseUtils;

namespace House;

class HouseProgram
{
    public static void Main(string[] args)
    {
        int totalFloors = 10; // Example: 10 floors
        var house = new House(totalFloors, new List<Apartment>());
        var (apartments, errors) = GenerateRandomApartments(totalFloors, house);

        Console.WriteLine($"House with {house.Floors} floors:");
        Console.WriteLine($"Generated {apartments.Count} valid apartments:");
        
        foreach (var apt in apartments)
            Console.WriteLine(apt);

        if (errors.Count != 0)
        {
            Console.WriteLine("\nValidation Errors:");
            foreach (var error in errors)
                Console.WriteLine(error);
        }
        else
        {
            Console.WriteLine("\nNo validation errors.");
        }
    }


}
