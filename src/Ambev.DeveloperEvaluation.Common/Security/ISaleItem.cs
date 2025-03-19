namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de um item de venda no sistema.
    /// </summary>
    public interface ISaleItem
    {
        /// <summary>
        /// Obtém o identificador único do item de venda.
        /// </summary>
        /// <returns>O ID do item de venda como uma string.</returns>
        public string Id { get; }

        public Guid SaleId { get; }

        public Guid ProductId { get; }

        public decimal TotalAmount { get; }

        public int Quantities { get; }

    }
}
