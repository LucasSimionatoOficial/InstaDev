using instadev.Interface;
namespace instadev.Models
{
    public class Comentario: InstadevBase, IComentario
    {
        public int IdComentario { get; set; }
        public string Mensagem { get; set; }
        public int IdUsuario { get; set; }
        public int IdPublicacao { get; set; }
        //comentario.csv IdComentario;Mensagem;IdUsuario;IdPublicacao

        public void CriarComentario(Comentario comentario)
        {
            throw new System.NotImplementedException();
        }

        public void EditarComentario(Comentario comentario)
        {
            throw new System.NotImplementedException();
        }

        public void ExcluirComentario(int IdComentario)
        {
            throw new System.NotImplementedException();
        }

        public void LerComentario(int idComentario)
        {
            throw new System.NotImplementedException();
        }
    }
}