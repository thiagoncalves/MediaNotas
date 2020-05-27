using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[3];

            Console.WriteLine("Digite a primeira nota: ");
            notas[0] = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a segunda nota: ");
            notas[1] = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a terceira nota: ");
            notas[2] = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            double media = notas.Average();

            SaberResultado(media);

            Console.ReadLine();
        }

        public static void SaberResultado (double media)
        {
            if (media == 10)
                Console.WriteLine("Aprovado com Distinção");
            if (media >= 7 && media < 10)
                Console.WriteLine("Aprovado");
            if (media < 7)
                Console.WriteLine("Reprovado");
        }
    }
}
