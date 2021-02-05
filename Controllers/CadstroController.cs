namespace instadev.Controllers
{
    [Route("Usuario")]
    public class CadstroController
    {
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            ViewBag.Jogadores = jogadorModel.ReadAll();
            return View();
        }

        [Route("Cadastrar")]
        public IACtionResult Cadastrar(IFormColletction form)
        {
            Usuario novoUsuario             = new Usuario();
            novoUsuario.IdUsuario           = int32.Parse(form["IdUsuario"]);
            novoUsuario.NomeCompleto        = form["NomeCompleto"];
            novoUsuario.NomeUsuario         = form["NomeUsuario"];
            novoUsuario.Email               = form["Email"];
            novoUsuario.Senha               = form["senha"];


            usuarioModel.Create(novoUsuario);
            ViewBag.usuarios = usuariosModel.ReadAll();

            return LocalRedirect(~Login);
        }    
    }
}