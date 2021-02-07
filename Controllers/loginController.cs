using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using instadev.Models;
using System;

namespace InstaDev.Controllers
{
    public class LoginController : Controller
    {
        // Comentario novoComentario = new Comentario(); // -> instanciar o objeto novoComentario

        Usuario usuarioModel = new Usuario();
        [TempData]
        public string Mensagem { get; set; }

        public IActionResult Index()
        {
            return View();
        }


        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            // Lemos todos os arquivos do CSV
            List<string> csv = usuarioModel.ReadAllLinesCSV("Database/Usuario.csv");

            // Verificamos se as informações passadas existe na lista de string
            var logado = 
            csv.Find(
                x => 
                x.Split(";")[9] == form["Email"] && 
                x.Split(";")[10] == form["Senha"]
            );
            var logado2 = 
            csv.Find(
                x => 
                x.Split(";")[2] == form["Email"] &&
                x.Split(";")[10] == form["Senha"]
            );


            // Redirecionamos o usuário logado caso encontrado
            if(logado != null)
            {
                Console.WriteLine("Estou logado");
                
                // Definimos os valores a serem salvos na sessão
                HttpContext.Session.SetString("_UserName", logado.Split(";")[2]);

                return LocalRedirect("~/Feed");
            }
            if(logado2 != null)
            {
                Console.WriteLine("Estou logado");
                
                // Definimos os valores a serem salvos na sessão
                HttpContext.Session.SetString("_UserName", logado2.Split(";")[1]);

                return LocalRedirect("~/Feed");
            }

            Mensagem = "Dados incorretos, tente novamente";

            Console.WriteLine("Não estou logado");
            

            // Mensagem = "Dados incorretos, tente novamente...";
            return LocalRedirect("~/Login");
        } 
    }
}