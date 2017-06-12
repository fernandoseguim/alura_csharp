using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity.DAO
{
    public class PessoaFisicaDAO : UsuarioDAO
    {
        private EntidadesContext context;

        public PessoaFisicaDAO() 
        {
            context = new EntidadesContext();
        }

    }
}
