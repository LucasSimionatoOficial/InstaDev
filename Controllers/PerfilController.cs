using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using instadev.Models;

namespace InstaDev.Controllers
{   
    [Route("Perfil")]
    public class PerfilController : Controller
    {   
        Usuario usuarioModel = new Usuario();
        
        public IActionResult Perfil()
        {
            return View();
        }
    }
}