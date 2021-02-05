using System;
using System.Collections.Generic;
using System.IO;
using instadev.Interface;

namespace instadev.Models
{
    public class Usuario: InstadevBase, IUsuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; } //Edição de perfil
        public string NomeUsuario{ get; set; } //Edição de perfil
        public string Foto { get; set; }
        public DateTime DataNascimento { get; set; } 
        public int NumeroSeguindo { get; set; }
        public List<int> Seguindo { get; set; } // quem o usuario logado segue
        public int NumeroSeguidores { get; set; }
        public List<int> Seguidores { get; set; } // quem segue o usuario logado
        public string Email { get; set; } //Edição de perfil
        public string Username { get; set; }
        public string Senha { get; set; }
        private string PATH = "Database/Usuario.csv";

        //Usuario.csv IdUsuario;Nome;NomeUsuario;Foto;DataNascimento;NumeroSeguindo;Seguindo;NumeroSeguidores;Seguidores;Email;Username;Senha
        //Seguindo idSeguidor1/idSeguidor2...
        //Seguidores idSeguidor1/idSeguidor2...
        //Usar split com barra para separar

        public Usuario()
        {
            CreateFolderAndFile(PATH);
        }

        private string Prepare(Usuario usuario)
        {
            string seguindo_ = "";
            bool seguindo = false;
            string seguidores_ = "";
            bool seguidores = false;
            foreach (var item in usuario.Seguindo)
            {
                if (seguindo)
                {
                    seguindo_ += $"/{item}";
                }
                else
                {
                    seguindo_ = $"{item}";
                    seguindo = true;
                }
            }
            foreach (var item in usuario.Seguidores)
            {
                if (seguidores)
                {
                    seguidores_ += $"/{item}";
                }
                else
                {
                    seguidores_ = $"{item}";
                    seguidores = true;
                }
            }
            return $"{usuario.IdUsuario};{usuario.Nome};{usuario.NomeUsuario};{usuario.Foto};{usuario.DataNascimento};{usuario.NumeroSeguindo};{seguindo_};{usuario.NumeroSeguidores};{seguidores_};{usuario.Email};{usuario.Username};{usuario.Senha}";
        }
        private List<string> PrepareList(List<Usuario> usuarios)
        {
            List<string> linhas = new List<string>();
            foreach (var usuario in usuarios)
            {
                linhas.Add(Prepare(usuario));
            }
            return linhas;
        }
        public void CadastrarUsuario(Usuario usuario)
        {
            string[] linhas = {Prepare(usuario)};
            File.AppendAllLines(PATH, linhas);
        }

        //Edição de perfil
        public void DeletarUsuario(int id)
        {
            List<Usuario> usuarios = ListarUsuarios();
            usuarios.RemoveAll(x => x.IdUsuario == id);
            Publicacao publicacao = new Publicacao();
            publicacao.ExcluirPublicacoesUsuario(id);
            RewriteCsv(PATH, PrepareList(usuarios));
            Comentario comentario = new Comentario();
            comentario.ExcluirComentariosUsuario(id);
        }

        //Edição de perfil
        public void EditarUsuario(Usuario usuario)
        {
            List<Usuario> usuarios = ListarUsuarios();
            usuarios.RemoveAll(x => x.IdUsuario == usuario.IdUsuario);
            usuarios.Add(usuario);
            RewriteCsv(PATH, PrepareList(usuarios));
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Usuario usuario = new Usuario();
                usuario.IdUsuario = int.Parse(linha.Split(";")[0]);
                usuario.Nome = linha.Split(";")[1];
                usuario.NomeUsuario = linha.Split(";")[2];
                usuario.Foto = linha.Split(";")[3];
                usuario.DataNascimento = DateTime.Parse(linha.Split(";")[4]);
                usuario.NumeroSeguindo = int.Parse(linha.Split(";")[5]);
                string seguindo_ = linha.Split(";")[6];
                string[] seguindo__ = seguindo_.Split("/");
                List<int> ListaSeguindo = new List<int>();
                foreach (var item in seguindo__)
                {
                    ListaSeguindo.Add(int.Parse(item));
                }
                usuario.NumeroSeguidores = int.Parse(linha.Split(";")[7]);
                string seguidores_ = linha.Split(";")[8];
                string[] seguidores__ = seguindo_.Split("/");
                List<int> ListaSeguidores = new List<int>();
                foreach (var item in seguidores__)
                {
                    ListaSeguidores.Add(int.Parse(item));
                }
                usuario.Email = linha.Split(";")[9];
                usuario.Username = linha.Split(";")[10];
                usuario.Senha = linha.Split(";")[11];
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public Usuario MostrarUsuario(int id)
        {
            List<Usuario> usuarios = ListarUsuarios();
            return usuarios.Find(x => x.IdUsuario == id);
        }

        public void Seguir(int idSeguidor, int idSeguindo)
        {
            List<Usuario> usuarios = ListarUsuarios();
            if (!usuarios.Find(x => x.IdUsuario == idSeguindo).Seguidores.Exists(x => x == idSeguidor))
            {
                usuarios.Find(x => x.IdUsuario == idSeguindo).NumeroSeguidores++;
                usuarios.Find(x => x.IdUsuario == idSeguindo).Seguidores.Add(idSeguidor);
                usuarios.Find(x => x.IdUsuario == idSeguidor).NumeroSeguindo++;
                usuarios.Find(x => x.IdUsuario == idSeguidor).Seguindo.Add(idSeguindo);
            }
            else
            {
                usuarios.Find(x => x.IdUsuario == idSeguindo).Seguidores.RemoveAll(x => x == idSeguidor);
                usuarios.Find(x => x.IdUsuario == idSeguindo).NumeroSeguidores = usuarios.Find(x => x.IdUsuario == idSeguindo).NumeroSeguidores -1;
                usuarios.Find(x => x.IdUsuario == idSeguidor).Seguindo.RemoveAll(x => x == idSeguindo);
                usuarios.Find(x => x.IdUsuario == idSeguidor).NumeroSeguindo = usuarios.Find(x => x.IdUsuario == idSeguidor).NumeroSeguindo - 1;
            }
            RewriteCsv(PATH, PrepareList(usuarios));
        }
    }
}