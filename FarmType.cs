using System.ComponentModel;

namespace FarmLinq;

public enum FarmType
{
    [Description("Crop Farm")]
    CropFarm = 1,
    [Description("Livestock Farm")]
    LivestockFarm,
    [Description("Dairy Farm")]
    DairyFarm,
    [Description("Poultry Farm")]
    PoultryFarm,
    [Description("Fish Farm")]
    FishFarm
}