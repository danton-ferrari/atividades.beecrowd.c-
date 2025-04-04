double tempoGasto = double.Parse(Console.ReadLine());
double velocidadeMedia = double.Parse(Console.ReadLine());
double resultado = (tempoGasto * velocidadeMedia) / 12;
Console.WriteLine(resultado.ToString("F3"));
Console.ReadKey();