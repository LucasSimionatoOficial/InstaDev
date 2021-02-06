using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using instadev.Models;
using System.Collections.Generic;

namespace InstaDev.Controllers
{   
    [Route("Perfil")]
    public class PerfilController : Controller
    {   
        private const string path = "Database/Usuario.csv";
        Usuario usuarioModel = new Usuario();
        Publicacao publicacaoModel = new Publicacao();

        public IActionResult Perfil()
        {  
            List<string> Usuarios = usuarioModel.ReadAllLinesCSV(path);
            // HttpContext.Session.SetString("IdUsuario", UsuarioPerfil.Split(";") [1]);
            // HttpContext.Session.SetString("NomeUsuario", UsuarioPerfil.Split(";") [2]);
            // HttpContext.Session.SetString("FotoUsuario", UsuarioPerfil.Split(";") [3]);

            // ViewBag.Username = HttpContext.Session.GetString("NomeUsuario");

            // var UsuarioPerfil = Usuarios.Find(                     
            // x =>           
            // x.Split(";")[0] == IdUsuarioLogado);
            
            ViewBag.ListaPubs = publicacaoModel.ListarPublicacoes();
            return View();
        }

        [Route("Perfil/{Id}")]
        public IActionResult ExibirPerfil(int Id)
        {
            ViewBag.Perfil = usuarioModel.ListarUsuarios().Find(x=> x.IdUsuario == Id);
            // ViewBag.PerfilPublicacoes = publicacaoModel.FindAll(x=> x.IdUsuario == Id);
            return View();
        }
    }
}