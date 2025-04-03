using System.Globalization;

int numeroFuncionario = int.Parse(Console.ReadLine());
int numeroHorasTrabalhadas = int.Parse(Console.ReadLine());
double salarioPorHora= double.Parse(Console.ReadLine());
double SALARY = numeroHorasTrabalhadas * salarioPorHora;
Console.WriteLine("NUMBER = " + numeroFuncionario);
Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", CultureInfo.InvariantCulture));
Console.ReadKey();
