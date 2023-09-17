using N39_HT_1.Model;

var weathers = new List<WeatherReport>
{
    new WeatherReport { Degree=30, State = "UAE"},
    new WeatherReport { Degree=15, State = "UZB"},
    new WeatherReport { Degree=36, State = "EGYPT"},
    new WeatherReport { Degree=24, State = "TURKEY"},
};

var users = new List<User>
{
    new User { FirstName="Robert", LastName = "Johnson"},
    new User { FirstName="John", LastName = "WICK"},
    new User { FirstName="Michel", LastName = "Halley"},
    new User { FirstName="Richard", LastName = "Walley"},
};

Console.WriteLine("\tThe weathers which has the degree is 30 C\n");
weathers.Where(weather => weather is { Degree: 30 }).ToList().ForEach(Console.WriteLine);
Console.WriteLine("\n\tThe people who are name is John\n");
users.Where(user => user is { FirstName: "John" }).ToList().ForEach(Console.WriteLine);