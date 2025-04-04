using System.Globalization;

int x = int.Parse(Console.ReadLine());
decimal y = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
decimal consumeMedio = x / y;
Console.WriteLine(consumeMedio.ToString("F3")+" km/l");
Console.ReadKey();
