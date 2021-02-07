using System;
using System.IO;
using instadev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace instadev.Controllers
{
    [Route("Editar")]
    public class EditarPerfilController : Controller
    {
        Usuario usuarioModel = new Usuario();

        //DEPENDE DO LOGIN
       /* [Route("Listar")] */
        public IActionResult Index()
        {
            ViewBag.Usuarios = usuarioModel.ListarUsuarios();
            ViewBag.UsuarioAtual = usuarioModel.ListarUsuarios().Find(x => x.NomeUsuario == HttpContext.Session.GetString("_UserName"));

            return View();
        }

        [Route("EditarPerfil")]
        public IActionResult EditarPerfil(IFormCollection form)
        {
            Usuario novoUsuario = new Usuario();

            if(form["nome"] != "")
            {
                novoUsuario.Nome = form["nome"];
            }
            if(form["nomeUsuario"] != "")
            {
                novoUsuario.NomeUsuario = form["nomeUsuario"];
            }
            if(form["email"]!= "")
            {
                novoUsuario.Email = form["email"];
            }
            novoUsuario.IdUsuario = int.Parse(form["id"]);


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
            usuarioModel.EditarUsuario(novoUsuario);

            return LocalRedirect("~/Editar");
        }
        
        // http://localhost:5001/Deletar/1
        [Route("Deletar/{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            usuarioModel.DeletarUsuario(id);

            ViewBag.Usuarios = usuarioModel.ListarUsuarios();

            return LocalRedirect("~/Login");
        }
        
    }
}