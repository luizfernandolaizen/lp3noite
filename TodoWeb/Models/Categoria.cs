using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoWeb.Models
{
   public  class Categoria
    {
        public int categoriaId { get; set; }
        public string Nome { get; set; }

        //Chave Estrangeira//
        #region Chave Estrangeira
        public int UsuarioId { get; set; }
        #endregion

    }
}
