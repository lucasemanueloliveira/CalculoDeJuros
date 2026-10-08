using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor da dívida: R$ ");
        decimal valor = decimal.Parse(Console.ReadLine());

        Console.Write("Digite a data de vencimento (ddMMyyyy): ");
        string data = Console.ReadLine();

        DateTime vencimento = DateTime.ParseExact(
            data,
            "ddMMyyyy",
            CultureInfo.InvariantCulture
        );

        DateTime hoje = DateTime.Today;

        int diasAtraso = (hoje - vencimento).Days;

        if (diasAtraso <= 0)
        {
            Console.WriteLine("Não há juros. O pagamento está em dia.");
        }
        else
        {
            decimal juros = valor * 0.025m * diasAtraso;
            decimal valorTotal = valor + juros;

            Console.WriteLine($"\nDias em atraso: {diasAtraso}");
            Console.WriteLine($"Valor dos juros: R$ {juros:F2}");
            Console.WriteLine($"Valor total: R$ {valorTotal:F2}");
        }
    }
}