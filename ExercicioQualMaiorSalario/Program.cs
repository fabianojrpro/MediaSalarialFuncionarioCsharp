// See https://aka.ms/new-console-template for more information
using ExercicioQualMaiorSalario;
using System.Globalization;

Console.WriteLine("Dados do primeiro funcionário: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Salário: ");
double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Funcionario funcionario1 = new Funcionario(nome,salario);
Console.WriteLine("Dados do primeiro funcionário: ");
Console.Write("Nome: ");
string nome2 = Console.ReadLine();
Console.Write("Salário: ");
double salario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Funcionario funcionario2 = new Funcionario(nome2, salario2);

funcionario1.MediaSalario(funcionario1,funcionario2);

