using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioQualMaiorSalario
{
    internal class Funcionario
    {
        public string nome { get; private set; }
        public double salario { get; private set; }

        public Funcionario(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public void MediaSalario(Funcionario funcionario1, Funcionario funcionario2)
        {
            double mediaSalarial;

            mediaSalarial = (funcionario1.salario + funcionario2.salario) / 2;

            Console.WriteLine("Salário médio = "+mediaSalarial.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
