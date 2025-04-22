namespace EclipseWorks.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de projeto no sistema.
    /// </summary>
    public interface IProject
    {
        public string Id { get; }

        public string ProjectNumber { get; }

        public DateTime ProjectDate { get;  }

        public Guid UserId { get; }

    }
}
