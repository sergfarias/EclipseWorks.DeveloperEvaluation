namespace EclipseWorks.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de um usuário no sistema.
    /// </summary>
    public interface IUser
    {
        public string Id { get; }

        public string Username { get; }

        public string Role { get; }
    }
}
