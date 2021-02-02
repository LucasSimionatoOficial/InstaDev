using instadev.Models;

namespace instadev.Interface
{
    public interface IComentario
    {
        void CriarComentario(Comentario comentario);
        void LerComentario(int idComentario);
        void EditarComentario(Comentario comentario);
        void ExcluirComentario(int IdComentario);
    }
}