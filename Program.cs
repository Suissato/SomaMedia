using System.ComponentModel;

namespace SomaMedia;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Digite a quantidade de números que deseja informar.");
        int qntInfo = int.Parse(Console.ReadLine());

        List<double> numeros = new List<double>();

        for (var i = 0; i < qntInfo; i++)
        {
            Console.WriteLine($"Digite o {i + 1}° número.");
            //double numeroDigitado = double.Parse(Console.ReadLine());
            double numeroDigitado;
            while (!double.TryParse(Console.ReadLine(), out numeroDigitado))
            {
                Console.WriteLine("Valor inválido! tente novamente: ");
            }

            numeros.Add(numeroDigitado);
        }

        double soma = 0;
        foreach (var item in numeros)
        {
            soma += item;
        }

        //Console.WriteLine($"Média é igual a: {soma / qntInfo:f2}");
        Console.WriteLine($"A soma é: {numeros.Sum():f2}");
        Console.WriteLine($"Média é igual a: {numeros.Average():f2}");
    }
}
