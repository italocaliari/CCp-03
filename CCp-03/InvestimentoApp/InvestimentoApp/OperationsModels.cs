namespace InvestimentoApp
{
    // Critério 2: Herança e Polimorfismo
    public class BuyOperation : Operation
    {
        public BuyOperation(string ticker, int quantity, decimal price)
            : base(ticker, quantity, price) { }

        public override string GetDetails() =>
            $"COMPRA: [{Id:D3}] {Date:dd/MM/yyyy HH:mm} - {Ticker} x{Quantity} @ R$ {Price:N2} = R$ {GetTotalValue():N2}";
    }

    public class SellOperation : Operation
    {
        public SellOperation(string ticker, int quantity, decimal price)
            : base(ticker, quantity, price) { }

        public override string GetDetails() =>
            $"VENDA:  [{Id:D3}] {Date:dd/MM/yyyy HH:mm} - {Ticker} x{Quantity} @ R$ {Price:N2} = R$ {GetTotalValue():N2}";
    }
}