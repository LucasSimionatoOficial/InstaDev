using System.Collections.Generic;
using instadev.Models;

namespace instadev.Interface
{
    public interface IUsuario
    {
        void CadastrarUsuario(Usuario usuario);
        Usuario MostrarUsuario(int id);
        void EditarUsuario(Usuario usuario);
        void DeletarUsuario(int id);
        List<Usuario> ListarUsuarios();
        void Seguir(int idSeguidor,int idSeguido, bool seguir);
    }
}