namespace FarmLinq;

public static class FarmTypeUtility
{
    public static string GetFarmTypeName(FarmType farmType)
    {
        return farmType switch
        {
            FarmType.CropFarm =>"Crop Farm",
            FarmType.LivestockFarm => "Livestock Farm",
            FarmType.DairyFarm => "Dairy Farm",
            FarmType.PoultryFarm => "Poultry Farm",
            FarmType.FishFarm => "Fish Farm",
            _ => throw new ArgumentOutOfRangeException(nameof(farmType), farmType, "Invalid farm type"),
        };
    }
}