namespace FarmLinq;

public static class FarmMenu
{
    public static void Run()
    {
        Console.Clear();
        var farmRepository = new FarmRepository();
        var farms = FarmRepository.CreateSampleFarms();

        var groupedByType = farmRepository.GroupFarmsByType(farms);
        DisplayGroupedFarmInformation("Farms Grouped by Type", groupedByType);

        var joinedFarms = farmRepository.JoinFarmsWithManagers(farms, CreateSampleManagers(farms));
        DisplayJoinedFarmInformation("Farms Joined with Managers", joinedFarms);

        
        var info = farms.Select(f => new NewFarm()
        {
            Name = f.Name,
            ManagerName = f.ManagerName,
            ManagerPhoneNumber = f.ManagerPhoneNumber
        }).ToList();

        foreach (var f in info)
        {
            Console.WriteLine($"Farm Name: {f.Name}");
            Console.WriteLine($"Manager Name: {f.ManagerName}");
            Console.WriteLine($"Manager Phone Number: {f.ManagerPhoneNumber}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
    private static void DisplayGroupedFarmInformation<T>(string title, IEnumerable<IGrouping<T, Farm>> groupedFarms)
    {
        Console.WriteLine($"===== {title} =====");
        foreach (var group in groupedFarms)
        {
            Console.WriteLine($"{group.Key}:");
            int farmCount = group.Count();

            foreach (var farm in group)
            {
                Console.WriteLine($"  - {farm.Name}");
            }

            Console.WriteLine($"Total Farms in {group.Key}: {farmCount}");
            Console.WriteLine();
        }
    }

    private static void DisplayJoinedFarmInformation(string title, IEnumerable<dynamic> joinedFarms)
    {
        Console.WriteLine($"===== {title} =====");
        foreach (var item in joinedFarms)
        {
            Console.WriteLine($"Farm: {item.Farm.Name}, Manager: {item.Farm.ManagerName}");
        }
        Console.WriteLine();
    }
    private static List<Farm> CreateSampleManagers(IEnumerable<Farm> farms)
    {
        var uniqueManagers = farms
            .Where(f => f.ManagerName != null)
            .GroupBy(f => f.ManagerName)
            .Select(group => new Farm
            {
                ManagerName = group.Key,
                ManagerPhoneNumber = group.First().ManagerPhoneNumber ?? string.Empty
            })
            .ToList();

        return uniqueManagers;
    }
}