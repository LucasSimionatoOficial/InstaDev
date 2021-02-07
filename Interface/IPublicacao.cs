using System.Collections.Generic;
using instadev.Models;

namespace instadev.Interface
{
    public interface IPublicacao
    {
        void CriarPublicacao(Publicacao publicacao);
        List<Publicacao> ListarPublicacoes();
        void EditarPublicacao(Publicacao publicacao);
        void ExcluirPublicacao(int id);
        void Curtir(int IdUsuarioAtual, int IdPublicacao);
    }
}