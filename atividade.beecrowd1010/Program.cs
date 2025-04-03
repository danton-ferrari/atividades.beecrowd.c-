string[] linha = Console.ReadLine().Split(' ');
string codigo1 = linha[0];
int numeroPecas1 = int.Parse(linha[1]);
decimal valorUnitario1 = decimal.Parse(linha[2]);

linha = Console.ReadLine().Split(' ');
string codigo2 = linha[0];
int numeroPecas2 = int.Parse(linha[1]);
decimal valorUnitario2 = decimal.Parse(linha[2]);

decimal total = (numeroPecas1 * valorUnitario1) + (numeroPecas2 * valorUnitario2);
Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
Console.ReadKey();