using System;
using System.Collections.Generic;
using System.IO;
using instadev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace instadev.Controllers
{
    [Route("Feed")]
    public class FeedController : Controller
    {
        Usuario usuarioModel = new Usuario();
        Publicacao publicacaoModel = new Publicacao();
        Comentario comentarioModel = new Comentario();
        public IActionResult Index()
        {
            //Temporario
            ViewBag.NomeUsuario = usuarioModel.ListarUsuarios().FindAll(x => x.IdUsuario == 1);
            //Temporario
            if(ViewBag.NomeUsuario == null)//Depende do login
            {
                return LocalRedirect("~/Login");
            }
            List<Usuario> usuarios = usuarioModel.ListarUsuarios();
            List<Publicacao> publicacoes = publicacaoModel.ListarPublicacoes();
            List<Comentario> comentarios = comentarioModel.ListarComentarios();
            List<string> publicacoesLinha = new List<string>();
            string nomebag = "";
            foreach (var item in ViewBag.NomeUsuario)
            {
                nomebag = item.NomeUsuario;
            }
            int idUsuario = usuarios.Find(x => x.NomeUsuario == nomebag).IdUsuario;
            foreach (var item in publicacoes)
            {
                string ImagemAutor = usuarios.Find(x => x.IdUsuario == item.IdUsuario).Foto;
                string AutorUsername = usuarios.Find(x => x.IdUsuario == item.IdUsuario).NomeUsuario;
                string AutorNome = usuarios.Find(x => x.IdUsuario == item.IdUsuario).Nome;

                int IdPublicacao = item.IdPublicacao;
                string PublicacaoImagem = item.Imagem;
                string PublicacaoLegenda = item.Legenda;
                int PublicacaoNumeroLikes = item.NumeroLikes;
                string UsuarioLike = "~/wwwroot/img/Feed/heart.svg";
                if(item.Likes.Exists(x => x == idUsuario))
                {
                    UsuarioLike = "~/wwwroot/img/Feed/red_heart.svg";
                }
                string ComentarioMensagem = "";
                string ComentarioUsuario = "";
                bool comentario_ = true;
                foreach (var comentario in comentarios.FindAll(x => x.IdPublicacao == IdPublicacao))
                {
                    if(!comentario_)
                    {
                        ComentarioMensagem = comentario.Mensagem;
                        ComentarioUsuario += $"{usuarios.Find(x => x.IdUsuario == comentario.IdUsuario).NomeUsuario}";
                        comentario_ = false;
                    }
                    else
                    {
                        ComentarioMensagem += $"/{comentario.Mensagem}";
                        ComentarioUsuario += $"/{usuarios.Find(x => x.IdUsuario == comentario.IdUsuario).NomeUsuario}";
                    }
                }
                publicacoesLinha.Add($"{ImagemAutor};{AutorUsername};{AutorNome};{IdPublicacao};{PublicacaoImagem};{PublicacaoLegenda};{PublicacaoNumeroLikes};{UsuarioLike};{ComentarioMensagem};{ComentarioUsuario}");
            }
            ViewBag.Usuarios = usuarios;
            ViewBag.Publicacoes = publicacoesLinha;
            return View();
        }
        [Route("Cadastrar")]
        public IActionResult CadastrarPublicacao(IFormCollection form)
        {
            //Temporario
            ViewBag.NomeUsuario = usuarioModel.ListarUsuarios().FindAll(x => x.IdUsuario == 1);
            //Temporario
            if(ViewBag.NomeUsuario == null)//Depende do login
            {
                return LocalRedirect("~/Login");
            }
            Publicacao novaPublicacao = new Publicacao();
            Random random = new Random();
            List<Publicacao> publicacoes = publicacaoModel.ListarPublicacoes();
            List<Usuario> usuarios = usuarioModel.ListarUsuarios();
            int idPub = random.Next(100000, 1000000);
            string nomebag = "";
            foreach (var item in ViewBag.NomeUsuario)
            {
                nomebag = item.NomeUsuario;
            }
            int idUsuario = usuarios.Find(x => x.NomeUsuario == nomebag).IdUsuario;
            while (publicacoes.Exists(x => x.IdPublicacao == idPub))
            {
                idPub = random.Next(100000, 1000000);
            }
            novaPublicacao.IdPublicacao = idPub;
            var file = form.Files[0];
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Publicacao");
            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", folder, file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            novaPublicacao.Imagem = file.FileName;
            novaPublicacao.Legenda = form["Legenda"];
            novaPublicacao.IdUsuario = idUsuario; //Login
            novaPublicacao.NumeroLikes = 0;
            //temporario
            List<int> likes = new List<int>();
            likes.Add(1);
            novaPublicacao.Likes = likes;
            //temporario
            publicacaoModel.CriarPublicacao(novaPublicacao);
            return LocalRedirect("~/Feed");
        }
        /* [Route("Like")]
        public IActionResult Like()
        {
            publicacaoModel.Curtir( , );//idUsuarioatual, autor
            return LocalRedirect("~/Feed");
        } */
        
        [Route("Comentar")]
        public IActionResult Comentar(IFormCollection form)
        {
            //Temporario
            ViewBag.NomeUsuario = usuarioModel.ListarUsuarios().FindAll(x => x.IdUsuario == 1);
            //Temporario
            string nomebag = "";
            foreach (var item in ViewBag.NomeUsuario)
            {
                nomebag = item.NomeUsuario;
            }
            int idUsuario = usuarioModel.ListarUsuarios().Find(x => x.NomeUsuario == nomebag).IdUsuario;
            List<Comentario> comentarios = comentarioModel.ListarComentarios();
            Comentario novoComentario = new Comentario();
            Random random = new Random();
            int idComentario_ = random.Next(100000, 1000000);
            while(comentarios.Exists(x => x.IdComentario == idComentario_))
            {
                idComentario_ = random.Next(100000, 1000000);
            }
            novoComentario.IdComentario = idComentario_;
            novoComentario.Mensagem = form["mensagem"];
            novoComentario.IdUsuario = idUsuario;
            novoComentario.IdPublicacao = int.Parse(form["idPublicacao"]);
            comentarioModel.CriarComentario(novoComentario);
            return LocalRedirect("~/Feed");
        }
    }
}