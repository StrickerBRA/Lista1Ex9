using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Realizando: Operação (Área de um círculo a partir de seu diâmetro):");
            Console.Write("Digite o valor do diâmentro do círculo:");
            a = double.Parse(Console.ReadLine());

            b = Math.Pow((a/2), 2)*(Math.PI);
            Console.WriteLine($"A Área do cìrculo de diâmetro {a} é {b}.");
        }
    }
}
