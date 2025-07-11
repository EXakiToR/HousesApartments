using System.Collections.Generic;
using System.Linq;
using HousesApartments.Models;
using HousesApartments.Utils;
using static System.Console;
// using static House.HouseUtils;

namespace HousesApartments;

class HouseProgram
{
    public static void Main(string[] args)
    {
        int totalFloors = 114;
        var (apartments, errors) = HouseUtils.GenerateRandomApartments(totalFloors, (int)Math.Round((float)totalFloors / 5, 0));
        var house = new House(totalFloors, apartments);
        var suitableApartments = House.SuitableApartments(apartments);

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

        WriteLine("\tSuitable apartments with pool or garden (less than $100k):");

        foreach (var suitableApt in suitableApartments)
            WriteLine($"{suitableApt} with price ${suitableApt.Price} on floor {suitableApt.Floor}, area {suitableApt.Area}");

    }


}
