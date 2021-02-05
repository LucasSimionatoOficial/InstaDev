using instadev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace instadev.Controllers
{
    public class UsuarioController : Controller
    {
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            ViewBag.Usuarios = usuarioModel.ListarUsuarios();

            return View();
        }

        public IActionResult EditarUsuario(IFormCollection form)
        {
            
        }
        
    }
}