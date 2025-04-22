using System;

namespace EclipseWorks.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de uma tarefa no sistema.
    /// </summary>
    public interface ITask
    {
        public string Id { get; }

        public Guid ProjectId { get; }

        public string Title { get; }

        public string Description { get; }

        public string Details { get; }

        public DateTime DueDate { get; }

    }
}
