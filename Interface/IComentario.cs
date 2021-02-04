using System.Collections.Generic;
using instadev.Models;

namespace instadev.Interface
{
    public interface IComentario
    {
        void CriarComentario(Comentario comentario);
        List<Comentario> ListarComentarios();
        void EditarComentario(Comentario comentario);
        void ExcluirComentario(int IdComentario);
    }
}