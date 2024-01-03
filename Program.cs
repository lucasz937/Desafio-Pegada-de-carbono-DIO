using System;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Agora, digite os quilômetros por dia:");
        double quilometrosPorDia = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite as horas de uso de eletrônicos por dia:");
        int horasDeEletronicos = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a quantidade de refeições com carne por dia:");
        int refeicoesComCarne = int.Parse(Console.ReadLine());
        
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
                Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");
    }

    static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
        double pegadaQuilometros = quilometrosPorDia * 365 * 0.2;
        double pegadaEletronicos = horasDeEletronicos * 0.1;
        double pegadaRefeicoes = refeicoesComCarne * 0.5;

        return pegadaQuilometros + pegadaEletronicos + pegadaRefeicoes;
    }
}

