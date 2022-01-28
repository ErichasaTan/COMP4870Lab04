using lab03.Models;

namespace lab03.Data;

public class SampleData
{
    public static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>() {
            new Province() {
            ProvinceCode="BC",
            ProvinceName="British Columbia",
            },
            new Province() {
            ProvinceCode="AB",
            ProvinceName="Alberta",
            },
            new Province() {
            ProvinceCode="ON",
            ProvinceName="Ontario",
            },
            new Province() {
            ProvinceCode="MN",
            ProvinceName="Manitoba",
            },

        };

        return provinces;
    }

    public static List<City> GetCities()
    {
        List<City> cities = new List<City>() {
            new City {
            CityId = 1,
            CityName = "Vancouver",
            Population = 3900000,
            ProvinceCode = "BC"
            },
            new City {
            CityId = 2,
            CityName = "Burnaby",
            Population = 3000222,
            ProvinceCode = "BC"
            },
            new City {
            CityId = 3,
            CityName = "Surrey",
            Population = 3003333,
            ProvinceCode = "BC"
            },
            new City {
            CityId = 4,
            CityName = "Edmonton",
            Population = 200000,
            ProvinceCode = "AB"
            },
            new City {
            CityId = 5,
            CityName = "Calgary",
            Population = 3045600,
            ProvinceCode = "AB"
            },
            new City {
            CityId = 6,
            CityName = "Red Deer",
            Population = 6780000,
            ProvinceCode = "AB"
            },
            new City {
            CityId = 7,
            CityName = "Toronto",
            Population = 3512300,
            ProvinceCode = "ON"
            },
                        new City {
            CityId = 8,
            CityName = "Hamilton",
            Population = 3123300,
            ProvinceCode = "ON"
            },
                        new City {
            CityId = 9,
            CityName = "Windsor",
            Population = 3518900,
            ProvinceCode = "ON"
            },
            new City {
            CityId = 10,
            CityName = "Winnipeg",
            Population = 750000,
            ProvinceCode = "MN"
            },
            new City {
            CityId = 11,
            CityName = "Selkirk",
            Population = 752300,
            ProvinceCode = "MN"
            },
            new City {
            CityId = 12,
            CityName = "Morden",
            Population = 754378,
            ProvinceCode = "MN"
            },
        };

        return cities;
    }

}