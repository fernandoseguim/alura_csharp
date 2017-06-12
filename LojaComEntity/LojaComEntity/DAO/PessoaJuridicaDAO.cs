using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity.DAO
{
    public class PessoaJuridicaDAO : UsuarioDAO
    {
        private EntidadesContext context;

        public PessoaJuridicaDAO()
        {
            context = new EntidadesContext();
        }
    }
}
