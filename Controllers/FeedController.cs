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
        public IActionResult Index()
        {
            if(ViewBag.NomeUsuario == null)//Depende do login
            {
                return LocalRedirect("~/Login");
            }
            List<Usuario> usuarios = usuarioModel.ListarUsuarios();
            List<Publicacao> publicacoes = publicacaoModel.ListarPublicacoes();
            List<string> publicacoesLinha = new List<string>();
            string nomebag = "";
            foreach (var item in ViewBag.NomeUsuario)
            {
                nomebag = item;
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
                bool UsuarioLike = item.Likes.Exists(x => x == idUsuario);
                publicacoesLinha.Add($"{ImagemAutor};{AutorUsername};{AutorNome};{IdPublicacao};{PublicacaoImagem};{PublicacaoLegenda};{PublicacaoNumeroLikes};{UsuarioLike}");
            }
            ViewBag.Usuarios = usuarios;
            ViewBag.Publicacoes = publicacoesLinha;
            return View();
        }
        [Route("Cadastrar")]
        public IActionResult CadastrarPublicacao(IFormCollection form)
        {
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
                nomebag = item;
            }
            int idUsuario = usuarios.Find(x => x.NomeUsuario == nomebag).IdUsuario;
            while (publicacoes.Exists(x => x.IdPublicacao != idPub))
            {
                idPub = random.Next(100000, 1000000);
            }
            novaPublicacao.IdPublicacao = idPub;
            var file = form.Files[0];
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwroot/img/Publicacao");
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
            publicacaoModel.CriarPublicacao(novaPublicacao);
            return LocalRedirect("~/Feed");
        }
        [Route("Like")]
        public IActionResult Like()
        {
            publicacaoModel.Curtir( , );//idUsuarioatual, autor
            return LocalRedirect("~/Feed");
        }
        [Route("Comentar")]
        public IActionResult Comentar()
        {
            
        }
    }
}