namespace FarmLinq
{
    public static class FarmMenu
    {
        public static void Run()
        {
            Console.Clear();
            List<Farm> farms = CreateSampleFarms();

            var groupedFarms = GroupFarmsByNameAndType(farms);

            DisplayFarmInformation(groupedFarms);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static List<Farm> CreateSampleFarms()
        {
            return new List<Farm>
            {
                new Farm {FarmId = 01,Name = "Farm A",Address = "Sango Ota",Type = FarmType.CropFarm,ManagerName = "Famakinwa Ade",ManagerAddress = "Alabata",ManagerPhoneNumber = "08012345678",Produce = "Millet",YearOfEstablishment = 2000},

                new Farm{FarmId = 02,Name = "Farm B",Address = "Alabata Village",Type = FarmType.DairyFarm,ManagerName = "Sulaimon Farooq",ManagerAddress = "Alabata",ManagerPhoneNumber = "09121973217",Produce = "Hen",YearOfEstablishment = 2001},

                new Farm{FarmId = 03,Name = "Farm C",Address = "Fadage Village",Type = FarmType.FishFarm,ManagerName = "Labeeb Ayinde",ManagerAddress = "Bode=Olude",ManagerPhoneNumber = "08139272981",Produce = "Milk",YearOfEstablishment = 2002},

                new Farm{FarmId = 04,Name = "Farm D",Address = "Obafe Village",Type = FarmType.PoultryFarm,ManagerName = "Olufemi Charlse",ManagerAddress = "Obafemi Owode",ManagerPhoneNumber = "08065388692",Produce = "Fish",YearOfEstablishment = 2004},

                new Farm{FarmId = 05,Name = "Farm E",Address = "Obada",Type = FarmType.LivestockFarm,ManagerName = "Rahmon Raheem",ManagerAddress = "Ile Ise Awo",ManagerPhoneNumber = "07063437679",Produce = "Corn",YearOfEstablishment = 1999},

                new Farm{FarmId = 06,Name = "Farm A",Address = "Alabata Village",Type = FarmType.CropFarm,ManagerName = "Pelewura Ayegbajeje",ManagerAddress = "Alabata",ManagerPhoneNumber = "09121973217",Produce = "Hen",YearOfEstablishment = 2022},

                new Farm{FarmId = 07,Name = "Farm B",Address = "Fadage Village",Type = FarmType.DairyFarm,ManagerName = "Famakinwa Ade",ManagerAddress = "Bode=Olude",ManagerPhoneNumber = "09121973217",Produce = "Milk",YearOfEstablishment = 2002},

                new Farm{FarmId = 08, Name = "Farm C", Address = "Obafe Village", Type = FarmType.FishFarm,
                ManagerName = "Olufemi Ojo", ManagerAddress = "Obafemi Owode", ManagerPhoneNumber = "08189464609",Produce = "Fish", YearOfEstablishment = 2004},

                new Farm{FarmId = 09,Name = "Farm D",Address = "Obafe Village",Type = FarmType.PoultryFarm,ManagerName = "Kalejaye Gbayepe",ManagerAddress = "Obafemi Owode",ManagerPhoneNumber = "08189464609",Produce = "Fish",YearOfEstablishment = 2004},

                new Farm{FarmId = 10,Name = "Farm E",Address = "Obafe Village",Type = FarmType.LivestockFarm,ManagerName = "Ajala Johnson",ManagerAddress = "Obafemi Owode",ManagerPhoneNumber = "08189464609",Produce = "Fish",YearOfEstablishment = 2004},

                new Farm {FarmId = 11,Name = "Farm A",Address = "Sango Ota",Type = FarmType.CropFarm,ManagerName = "King Charlse",ManagerAddress = "Alabata",ManagerPhoneNumber = "09121973217",Produce = "Rice",YearOfEstablishment = 2000},

                new Farm{FarmId = 12,Name = "Farm B",Address = "Alabata Village",Type = FarmType.DairyFarm,ManagerName = "Fatai Oluwo",ManagerAddress = "Alabata",ManagerPhoneNumber = "09121973217",Produce = "Sour Milk",YearOfEstablishment = 2001},

                new Farm{FarmId = 13,Name = "Farm C",Address = "Fadage Village",Type = FarmType.FishFarm,ManagerName = "Elewele Ajayi",ManagerAddress = "Bode=Olude",ManagerPhoneNumber = "09121973217",Produce = "Snail",YearOfEstablishment = 2002},

                new Farm{FarmId = 14,Name = "Farm D",Address = "Obafe Village",Type = FarmType.PoultryFarm,ManagerName = "John Olumuyiwa",ManagerAddress = "Obafemi Owode",ManagerPhoneNumber = "08189464609",Produce = "Duck",YearOfEstablishment = 2004},

                new Farm{FarmId = 15,Name = "Farm E",Address = "Sango Ota",Type = FarmType.LivestockFarm,ManagerName = "Famakinwa Ade",ManagerAddress = "Alabata",ManagerPhoneNumber = "09121973217",Produce = "Pig",YearOfEstablishment = 1999},

                new Farm{FarmId = 16,Name = "Farm A",Address = "Alabata Village",Type = FarmType.CropFarm,ManagerName = "Precious Ade",ManagerAddress = "Alabata",ManagerPhoneNumber = "09121973217",Produce = "Wheat",YearOfEstablishment = 2022},

                new Farm{FarmId = 17,Name = "Farm B",Address = "Fadage Village",Type = FarmType.DairyFarm,ManagerName = "Alarape Blessing",ManagerAddress = "Bode=Olude",ManagerPhoneNumber = "09012345678",Produce = "Milk",YearOfEstablishment = 2002},

                new Farm{FarmId = 18, Name = "Farm C", Address = "Obafe Village", Type = FarmType.FishFarm,
                ManagerName = "John Smith", ManagerAddress = "Obafemi Owode", ManagerPhoneNumber = "09073110456",Produce = "Fish", YearOfEstablishment = 2004},

                new Farm{FarmId = 19,Name = "Farm D",Address = "Obafe Village",Type = FarmType.PoultryFarm,ManagerName = "John Stone",ManagerAddress = "Obafemi Owode",ManagerPhoneNumber = "07053684751",Produce = "Chicken",YearOfEstablishment = 2004},

                new Farm{FarmId = 20,Name = "Farm E",Address = "Mawuko Village",Type = FarmType.LivestockFarm,ManagerName = "John Olumuyiwa",ManagerAddress = "Iberekodo Owode",ManagerPhoneNumber = "08189464609",Produce = "Cow",YearOfEstablishment = 2020},
            };
        }
        private static IEnumerable<IGrouping<(string Name, FarmType Type), Farm>> GroupFarmsByNameAndType(List<Farm> farms)
        {
            return farms.GroupBy(f => (f.Name, f.Type))!;
        }

        private static void DisplayFarmInformation(IEnumerable<IGrouping<(string Name, FarmType Type), Farm>> groupedFarms)
        {
            foreach (var group in groupedFarms)
            {
                Console.WriteLine($"Farm Name: {group.Key.Name}");
                Console.WriteLine($"Farm Type: {FarmTypeUtility.GetFarmTypeName(group.Key.Type)}");
                Console.WriteLine("====Farm Managers Info===");

                foreach (var farm in group)
                {
                    Console.WriteLine($"Manager Name: {farm.ManagerName}");
                    Console.WriteLine($"Manager Phone Number: {farm.ManagerPhoneNumber}");
                }

                Console.WriteLine();
            }
        }
    }
}