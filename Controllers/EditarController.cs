using System;
using System.IO;
using instadev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace instadev.Controllers
{
    [Route("Editar")]
    public class EditarController : Controller
    {
        Usuario usuarioModel = new Usuario();

        //DEPENDE DO LOGIN
       [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Usuarios = usuarioModel.ListarUsuarios();

            return View();
        }

        // http://localhost:5001/Editar/1
        [Route("Info/{id}")]
        public IActionResult Editar(int id, IFormCollection form)
        {     
            Usuario usuarioEdit = new Usuario();

            usuarioEdit.Nome = form[("Nome")];
            usuarioEdit.NomeUsuario = form[("NomeUsuario")];
            usuarioEdit.Senha = form[("Senha")];

            usuarioModel.EditarUsuario(usuarioEdit);
            ViewBag.Usuarios = usuarioModel.ListarUsuarios();

            return LocalRedirect("~/Editar/Listar");
        }

        // http://localhost:5001/Deletar/1
        [Route("Deletar/{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            usuarioModel.DeletarUsuario(id);

            ViewBag.Usuarios = usuarioModel.ListarUsuarios();

            return LocalRedirect("~/Editar/Listar");
        }

        [Route("Imagem")]
        public IActionResult EditarImagem(IFormCollection form)
        {
            Usuario novoUsuario = new Usuario();

            //Veirificamos se o usuário anexou algum arquivo
            if ( form.Files.Count > 0 )
            {
                //Armazenamos o arquivo na variável file
                var file = form.Files[0];

                //Feito para definir/amazenar o caminho das imagens
                var folder = Path.Combine( Directory.GetCurrentDirectory(), "wwwroot/img/FotosUsuario" );

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                                                // localhost:5001   +                   + Equipes + nome do arquivo(equipes.jpg, por exemplo) 
                var path = Path.Combine( Directory.GetCurrentDirectory(), "wwwroot/img;", folder, file.FileName );

                //FileStream: recebeu o caminho de manipulação do arquivo (neste exemplo é a criação) e digo o que fazer no arquivo (FileMode.Create)
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    //Salvamos o arquivo no caminho especifícado
                    file.CopyTo(stream);
                }

                //Atribuímos a imagem na imagem
                novoUsuario.Foto = file.FileName;
            }
            else
            {
                novoUsuario.Foto = "padrao.png";
            }

            return LocalRedirect("~/Editar/Listar");
        }
        
        
    }
}