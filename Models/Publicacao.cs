using instadev.Interface;

namespace instadev.Models
{
    public class Publicacao : InstadevBase, IPublicacao
    {
        public int IdPublicacao { get; set; }
        public string Imagem { get; set; }
        public string Legenda { get; set; }
        public int IdUsuario { get; set; }
        public int Likes { get; set; }
        //Organizaxao do csv: IdPublicacao;Imagem;Legenda;IdUsuario;Likes/idlike1/idlike2/idlike3 ...

        //Usar a barra como separador para saber quem deu o like; idlike = id de alguem que deu like
        public void CriarPublicacao(Publicacao publicacao)
        {
            throw new System.NotImplementedException();
        }

        public void Curtir(int id)
        {
            throw new System.NotImplementedException();
        }

        public void EditarPublicacao(Publicacao publicacao)
        {
            throw new System.NotImplementedException();
        }

        public void ExcluirPublicacao(int id)
        {
            throw new System.NotImplementedException();
        }

        public void ListarPublicacoes()
        {
            throw new System.NotImplementedException();
        }
    }
}