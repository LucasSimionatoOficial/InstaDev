using System;
using instadev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace instadev.Controllers
{
    [Route("Equipe")]
    public class UsuarioController : Controller
    {
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            ViewBag.Usuarios = usuarioModel.ListarUsuarios();

            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Usuario novoUsuario = new Usuario();

            novoUsuario.IdUsuario = Int32.Parse( form["IdUsuario"] );
            novoUsuario.Nome = form["Nome"];
            novoUsuario.NomeUsuario = form["NomeUsuario"];
            novoUsuario.Foto = form["Foto"];
            novoUsuario.DataNascimento = DateTime.Parse( form["DataNascimento"] );
            novoUsuario.Email = form["Email"];
            novoUsuario.Username = form["Username"];
            novoUsuario.Senha = form["Senha"];

            usuarioModel.CadastrarUsuario(novoUsuario);
            ViewBag.Usuarios = usuarioModel.ListarUsuarios();

            return LocalRedirect("~/Usuario/Listar");
            
        }

        public IActionResult EditarUsuario(IFormCollection form)
        {
            

            return View();
        }
        
        
    }
}