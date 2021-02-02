using System;
using System.Collections.Generic;
using instadev.Interface;

namespace instadev.Models
{
    public class Usuario: InstadevBase, IUsuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public DateTime DataNascimento { get; set; }
        public int NumeroSeguindo { get; set; }
        public List<int> Seguindo { get; set; } // quem o usuario logado segue
        public int NumeroSeguidores { get; set; }
        public List<int> Seguidores { get; set; } // quem segue o usuario logado
        public string Email { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }

        //Usuario.csv IdUsuario;Nome;Foto;DataNascimento;NumeroSeguindo;Seguindo;NumeroMeSegue;MeSegue;Email;Username;Senha
        //Seguindo idSeguidor1/idSeguidor2...
        //MeSegue idSeguidor1/idSeguidor2...
        //Usar split com barra para separar

        public void CadastrarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void DeletarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public void EditarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void ListarUsuarios()
        {
            throw new NotImplementedException();
        }

        public void Logar()
        {
            throw new NotImplementedException();
        }

        public void MostrarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public void Seguir(int id)
        {
            throw new NotImplementedException();
        }
    }
}