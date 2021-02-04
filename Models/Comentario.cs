using System.Collections.Generic;
using System.IO;
using instadev.Interface;
namespace instadev.Models
{
    public class Comentario: InstadevBase, IComentario
    {
        public int IdComentario { get; set; }
        public string Mensagem { get; set; }
        public int IdUsuario { get; set; }//usuario que comentou
        public int IdPublicacao { get; set; }
        private string PATH = "Database/comentarios.csv";
        //comentario.csv IdComentario;Mensagem;IdUsuario;IdPublicacao
        
        public Comentario()
        {
            CreateFolderAndFile(PATH);
        }
        private string Prepare(Comentario comentario)
        {
            return $"{comentario.IdComentario};{comentario.Mensagem};{comentario.IdUsuario};{comentario.IdPublicacao}";
        }
        private List<string> PrepareList(List<Comentario> comentarios)
        {
            List<string> linhas = new List<string>();
            foreach(var comentario in comentarios)
            {
                string linha = Prepare(comentario);
                linhas.Add(linha);
            }
            return linhas;
        }
        public void CriarComentario(Comentario comentario)
        {
            string[] linhas = {Prepare(comentario)};
            File.AppendAllLines(PATH, linhas);
        }

        public void EditarComentario(Comentario comentario)
        {
            List<Comentario> comentarios = ListarComentarios();
            comentarios.RemoveAll(x => x.IdComentario == comentario.IdComentario);
            comentarios.Add(comentario);
            RewriteCsv(PATH, PrepareList(comentarios));
        }

        public void ExcluirComentario(int IdComentario)
        {
            List<Comentario> comentarios = ListarComentarios();
            comentarios.RemoveAll(x => x.IdComentario== IdComentario);
            RewriteCsv(PATH, PrepareList(comentarios));
        }
        public void ExcluirComentariosPublicacao(int id)
        {
            List<Comentario> comentarios = ListarComentarios();
            comentarios.RemoveAll(x => x.IdPublicacao == id);
            RewriteCsv(PATH, PrepareList(comentarios));
        }
        public void ExcluirComentariosUsuario(int id)
        {
            List<Comentario> comentarios = ListarComentarios();
            comentarios.RemoveAll(x => x.IdUsuario == id);
            RewriteCsv(PATH, PrepareList(comentarios));
        }

        public List<Comentario> ListarComentarios()
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            List<Comentario> comentarios = new List<Comentario>();
            foreach (var linha in linhas)
            {
                Comentario comentario = new Comentario();
                comentario.IdComentario = int.Parse(linha.Split(";")[0]);
                comentario.Mensagem = linha.Split(";")[1];
                comentario.IdUsuario = int.Parse(linha.Split(";")[2]);
                comentario.IdPublicacao = int.Parse(linha.Split(";")[3]);
                comentarios.Add(comentario);
            }
            return comentarios;
        }
    }
}