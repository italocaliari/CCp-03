using System;
using System.Collections.Generic;
using System.Linq;

namespace InvestimentoApp
{
    class Program
    {
        // Critério 6: Armazenamento em List
        static List<Operation> database = new List<Operation>();

        static void Main(string[] args)
        {
            int option = -1;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("=== SISTEMA DE ATIVOS - NOTA 10 ===");
                    Console.WriteLine("1-Registrar operação");
                    Console.WriteLine("2-Listar operações");
                    Console.WriteLine("3-Mostrar valor total");
                    Console.WriteLine("0-Sair");
                    Console.Write("\nEscolha: ");

                    if (!int.TryParse(Console.ReadLine(), out option))
                        throw new Exception("Digite um número válido!");

                    switch (option)
                    {
                        case 1: Registrar(); break;
                        case 2: Listar(); break;
                        case 3: Totais(); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nErro: {ex.Message}");
                    Console.ResetColor();
                }
                if (option != 0) { Console.WriteLine("\nPressione qualquer tecla..."); Console.ReadKey(); }
            } while (option != 0);
        }

        static void Registrar()
        {
            Console.Write("Tipo (1=Compra, 2=Venda): ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Ativo (ex: PETR4): ");
            string ticker = Console.ReadLine();
            Console.Write("Qtd: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Preço: ");
            decimal p = decimal.Parse(Console.ReadLine());

            if (t == 1) database.Add(new BuyOperation(ticker, q, p));
            else database.Add(new SellOperation(ticker, q, p));
            Console.WriteLine("OK!");
        }

        static void Listar()
        {
            Console.WriteLine("\n--- Histórico ---");
            database.ForEach(o => Console.WriteLine(o.GetDetails()));
        }

        static void Totais()
        {
            var compras = database.Where(o => o is BuyOperation).Sum(o => o.GetTotalValue());
            var vendas = database.Where(o => o is SellOperation).Sum(o => o.GetTotalValue());
            Console.WriteLine($"Total Compras: R$ {compras:N2}");
            Console.WriteLine($"Total Vendas: R$ {vendas:N2}");
        }
    }
}