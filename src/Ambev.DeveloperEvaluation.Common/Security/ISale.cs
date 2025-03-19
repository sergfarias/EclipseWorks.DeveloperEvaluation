namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de uma venda no sistema.
    /// </summary>
    public interface ISale
    {
        /// <summary>
        /// Obtém o identificador único da venda.
        /// </summary>
        /// <returns>O ID do venda como uma string.</returns>
        public string Id { get; }

        /// <summary>
        /// Obtém o número da venda.
        /// </summary>
        /// <returns>O núm ero da venda.</returns>
        public string SaleNumber { get; }

        /// <summary>
        /// Obtém o data da venda.
        /// </summary>
        /// <returns>O data da venda.</returns>
        public DateTime SaleDate { get;  }

        public Guid CustomerId { get; }

        public decimal TotalSaleAmount { get; }

        public decimal Discounts { get; }

        public Guid BranchId { get; }

    }
}
