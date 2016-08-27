using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoWeb.Models
{
    public class Tarefa
    {
        public int tarefaId { get; set; }
        public string Texto { get; set; }
        public bool Concluida { get; set; }

        #region Chaves Estrangeiras
        public int UsuaioId { get; set; }
        public int categoriaId { get; set; }
        #endregion
    }
}
