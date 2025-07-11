using System;

namespace House;

public static class HouseUtils
{
    public static (bool IsValid, string? ErrorMessage) ValidateApartment(Apartment apt, int floors)
    {
        var unsuccess = (false, $"Error: {apt.GetType()} attempted to be created on floor {apt.Floor}");
        return apt switch
        {
            ApartmentWithGarden _ when apt.Floor != 1 =>
                unsuccess,
            ApartmentWithPool _ when apt.Floor != floors =>
                unsuccess,
            _ => (true, null)
        };
    }
    public static (List<Apartment> Apartments, List<string> Errors) GenerateRandomApartments(int count, int floors)
    {
        var random = new Random();
        var validApts = new List<Apartment>();
        var errors = new List<string>();

        for (int i = 0; i < count; i++)
        {
            int floor = random.Next(1, floors + 1); // Random floor 1 to totalFloors
            double area = Math.Round(random.Next(10, 30) + random.NextDouble(), 2);
            int type = random.Next(0, 4); // Randomly pick any type

            Apartment apt = type switch
            {
                0 => new Apartment(floor, area),
                1 => new ApartmentWithWindows(floor, area),
                2 => new ApartmentWithGarden(floor, area),
                3 => new ApartmentWithPool(floor, area),
                _ => new Apartment(floor, area)
            };

            var (IsValid, ErrorMessage) = ValidateApartment(apt, floors);
            if (IsValid)
            {
                validApts.Add(apt);
                Console.WriteLine($"Price for {apt.GetType()} on floor {apt.Floor} with area {apt.Area} is ${apt.Price}");
            }
            else if (ErrorMessage != null)
            {
                errors.Add(ErrorMessage);
            }
        }

        return (validApts, errors);
    }
    
}
