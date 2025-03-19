namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de uma filial no sistema.
    /// </summary>
    public interface IBranch
    {
        /// <summary>
        /// Obtém o identificador único do filial.
        /// </summary>
        /// <returns>O ID da filial como uma string.</returns>
        public string Id { get; }

        /// <summary>
        /// Obtém o nome de filial.
        /// </summary>
        /// <returns>O nome de filial.</returns>
        public string Name { get; }
    }
}
