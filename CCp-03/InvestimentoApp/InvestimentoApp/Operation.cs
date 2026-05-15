using System;

namespace InvestimentoApp
{
    // Critério 2: POO (Abstrata) | Critério 5: Partial Class
    public abstract partial class Operation
    {
        // Critério 3: Geração de IDs com static
        private static int _nextId = 1;

        public int Id { get; }
        public string Ticker { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; }

        protected Operation(string ticker, int quantity, decimal price)
        {
            Id = _nextId++;
            Ticker = ticker.ToUpper();
            Quantity = quantity;
            Price = price;
            Date = DateTime.Now;
        }

        // Critério 2: Polimorfismo
        public abstract string GetDetails();

        public decimal GetTotalValue() => Quantity * Price;
    }
}