using System;
using System.Collections.Generic;
using instadev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace instadev.Controllers
{
    [Route("Cadastrar")]
    public class CadastroController : Controller
    {

        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            ViewBag.Usuarios = usuarioModel.ListarUsuarios();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {

            //Gerar numero aleatorio para o id
            Random random = new Random();
            int idUsuario_ = 0;
            List<Usuario> usuarios = usuarioModel.ListarUsuarios();
            while (usuarios.Exists(x => x.IdUsuario != idUsuario_) && idUsuario_ != 0)
            {
                idUsuario_ = random.Next(100000, 1000000);
            }

            Usuario novoUsuario = new Usuario();
            novoUsuario.IdUsuario           = idUsuario_;
            novoUsuario.Nome                = form["NomeCompleto"];
            novoUsuario.NomeUsuario         = form["NomeUsuario"];
            novoUsuario.Email               = form["Email"];
            novoUsuario.Senha               = form["senha"];
            novoUsuario.NumeroSeguidores    = 0;
            novoUsuario.NumeroSeguindo      = 0;


            usuarioModel.CadastrarUsuario(novoUsuario);
            ViewBag.Usuarios = usuarioModel.ListarUsuarios();

            return LocalRedirect("~/Login");
        }    
    }
}