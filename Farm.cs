namespace FarmLinq;

public class Farm
{
    public int FarmId { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public FarmType Type { get; set; }
    public string? ManagerName { get; set; }
    public string? ManagerAddress { get; set; }
    public string? ManagerPhoneNumber { get; set; }
    public string? Produce { get; set; }
    public int YearOfEstablishment { get; set; }
}

public  class NewFarm
{
    public string? Name { get; set; }
    public string? ManagerName { get; set; }
    public string? ManagerPhoneNumber { get; set; }

}