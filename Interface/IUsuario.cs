using instadev.Models;

namespace instadev.Interface
{
    public interface IUsuario
    {
        void CadastrarUsuario(Usuario usuario);
        void MostrarUsuario(int id);
        void EditarUsuario(Usuario usuario);
        void DeletarUsuario(int id);
        void ListarUsuarios();
        void Logar();
        void Seguir(int id);
    }
}