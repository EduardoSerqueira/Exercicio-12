using System;

namespace Exercicio_doze
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;

            Console.WriteLine("Hora inicial: ");
            horaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Hora final: ");
            horaFinal = int.Parse(Console.ReadLine());

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
            Console.ReadKey();
        }
    }
}
