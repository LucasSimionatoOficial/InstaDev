using instadev.Models;

namespace instadev.Interface
{
    public interface IPublicacao
    {
        void CriarPublicacao(Publicacao publicacao);
        void ListarPublicacoes();
        void EditarPublicacao(Publicacao publicacao);
        void ExcluirPublicacao(int id);
        void Curtir(int id);
    }
}