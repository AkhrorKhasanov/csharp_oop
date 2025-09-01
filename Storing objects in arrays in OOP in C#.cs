using System;
class City
{
    public string name { get; set; }
    public int population { get; set; }
    public City(string name, int population)
    {
        this.name = name;
        this.population = population;
    }
}

class Program
{
    static void Main()
    {
        City[] cities = new City[5];

        cities[0] = new City("Samarkand", 1000);
        cities[1] = new City("Tashkent", 2000);
        cities[2] = new City("Berlin", 3000);
        cities[3] = new City("Washington", 4000);
        cities[4] = new City("London", 5000);

        foreach (City city in cities)
        {
            Console.WriteLine($"City: {city.name} --- Population: {city.population}");
        }
    }
}