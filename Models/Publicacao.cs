using System.Collections.Generic;
using System.IO;
using instadev.Interface;

namespace instadev.Models
{
    public class Publicacao : InstadevBase, IPublicacao
    {
        public int IdPublicacao { get; set; }
        public string Imagem { get; set; }
        public string Legenda { get; set; }
        public int IdUsuario { get; set; }
        public int NumeroLikes { get; set; }
        public List<int> Likes { get; set; }
        private string PATH = "Database/Publicacoes.csv";
        //Organizaxao do csv: IdPublicacao;Imagem;Legenda;IdUsuario;NumeroLikes;Likes
        //Likes idlike1/idlike2...

        //Usar a barra como separador para saber quem deu o like; idlike = id de alguem que deu like
        public Publicacao()
        {
            CreateFolderAndFile(PATH);
        }
        private string Prepare(Publicacao publicacao)
        {
            string likes_ = "";
            bool likes = false;
            foreach (var item in publicacao.Likes)
            {
                if (likes)
                {
                    likes_ += $"/{item}";
                }
                else
                {
                    likes_ = $"{item}";
                    likes = true;
                }
            }
            return $"{publicacao.IdPublicacao};{publicacao.Imagem};{publicacao.Legenda};{publicacao.IdUsuario};{publicacao.NumeroLikes};{likes_}";
        }
        private List<string> PrepareList(List<Publicacao> publicacoes)
        {
            List<string> linhas = new List<string>();
            foreach (var publicacao in publicacoes)
            {
                linhas.Add(Prepare(publicacao));
            }
            return linhas;
        }
        public void CriarPublicacao(Publicacao publicacao)
        {
            string[] linhas = {Prepare(publicacao)};
            File.AppendAllLines(PATH, linhas);
        }

        public void Curtir(int IdUsuarioAtual, int idAutor, int IdPublicacao)
        {
            List<Publicacao> publicacoes = ListarPublicacoes();
            if (publicacoes.Find(x => x.IdPublicacao == IdPublicacao).Likes.Exists(x => x == IdUsuarioAtual))
            {
                publicacoes.Find(x => x.IdPublicacao == IdPublicacao).Likes.RemoveAll(x => x == IdUsuarioAtual);
            }
            else
            {
                publicacoes.Find(x => x.IdPublicacao == IdPublicacao).Likes.Add(IdUsuarioAtual);
            }
            RewriteCsv(PATH, PrepareList(publicacoes));
        }

        public void EditarPublicacao(Publicacao publicacao)
        {
            List<Publicacao> publicacoes = ListarPublicacoes();
            publicacoes.RemoveAll(x => x.IdPublicacao == publicacao.IdPublicacao);
            publicacoes.Add(publicacao);
        }

        public void ExcluirPublicacao(int id)
        {
            List<Publicacao> publicacoes = new List<Publicacao>();
            publicacoes.RemoveAll(x => x.IdPublicacao == id);
            RewriteCsv(PATH, PrepareList(publicacoes));
            Comentario comentario = new Comentario();
            comentario.ExcluirComentariosPublicacao(id);
        }
        public void ExcluirPublicacoesUsuario(int id)
        {
            List<Publicacao> publicacoes = ListarPublicacoes();
            List<Publicacao> id_ = publicacoes.FindAll(x => x.IdUsuario == id);
            publicacoes.RemoveAll(x => x.IdUsuario == id);
            RewriteCsv(PATH, PrepareList(publicacoes));
            List<int> id__ = new List<int>();
            foreach (var publicacao in id_)
            {
                id__.Add(publicacao.IdPublicacao);
            }
            Comentario comentario = new Comentario();
            foreach (var item in id__)
            {
                comentario.ExcluirComentariosPublicacao(item);
            }

        }

        public List<Publicacao> ListarPublicacoes()
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            List<Publicacao> publicacoes = new List<Publicacao>();
            foreach (var linha in linhas)
            {
                Publicacao publicacao = new Publicacao();
                publicacao.IdPublicacao = int.Parse(linha.Split(";")[0]);
                publicacao.Imagem = linha.Split(";")[1];
                publicacao.Legenda = linha.Split(";")[2];
                publicacao.IdUsuario = int.Parse(linha.Split(";")[3]);
                publicacao.NumeroLikes = int.Parse(linha.Split(";")[4]);
                string likes_ = linha.Split(";")[5];
                string[] likes__ = likes_.Split("/");
                foreach (var item in likes__)
                {
                    publicacao.Likes.Add(int.Parse(item));
                }
                publicacoes.Add(publicacao);
            }
            return publicacoes;
        }
    }
}