using LojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public abstract class UsuarioDAO
    {
        private EntidadesContext context;

        public UsuarioDAO()
        {
            context = new EntidadesContext();
        }

        public void Create(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public void Update()
        {
            context.SaveChanges();
        }

        public Usuario GetById(int id)
        {
            return context.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public void Remove(Usuario usuario)
        {
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }
    }
}
