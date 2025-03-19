namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de um cliente no sistema.
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// Obtém o identificador único do cliente.
        /// </summary>
        /// <returns>O ID do cliente como uma string.</returns>
        public string Id { get; }

        /// <summary>
        /// Obtém o nome de cliente.
        /// </summary>
        /// <returns>O nome de cliente.</returns>
        public string Name { get; }

      
    }
}
