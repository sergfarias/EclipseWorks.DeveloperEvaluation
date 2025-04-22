using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseWorks.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de um histórico no sistema.
    /// </summary>
    public interface IHistory
    {
        public string Id { get; }

        public Guid TaskId { get; }

        public string Details { get; }

    }
}


