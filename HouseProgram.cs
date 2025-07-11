using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static House.HouseUtils;

namespace House;

class HouseProgram
{
    public static void Main(string[] args)
    {
        int totalFloors = 20;
        var house = new House(totalFloors, new List<Apartment>());
        var (apartments, errors) = GenerateRandomApartments(totalFloors, house);

        WriteLine($"House with {house.Floors} floors:");
        WriteLine($"Generated {apartments.Count} valid apartments:");

        foreach (var apt in apartments)
            WriteLine(apt);

        if (errors.Count != 0)
        {
            WriteLine("\nValidation Errors:");
            foreach (var error in errors)
                WriteLine(error);
        }
        else
        {
            WriteLine("\nNo validation errors.");
        }
        WriteLine($"Top price of apartment: ${House.GetTopPrice(apartments)}");
    }


}
