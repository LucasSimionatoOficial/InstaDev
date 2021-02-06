using System;
using instadev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace instadev.Controllers
{
    [Route("Editar")]
    public class EditarController : Controller
    {
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            ViewBag.Usuarios = usuarioModel.ListarUsuarios();

            return View();
        }

        [Route("{id}")]
        public IActionResult EditarUsuario(int id, IFormCollection form)
        {     
            return View();
        }

        [Route("{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            usuarioModel.DeletarUsuario(id);

            ViewBag.Usuarios = usuarioModel.ListarUsuarios();

            return LocalRedirect("~/Editar/Listar");
        }
        
        
    }
}