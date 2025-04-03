
using System.Globalization;

decimal raio = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
decimal pi = 3.14159M;
decimal area = pi * (raio * raio);
Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
Console.ReadKey();