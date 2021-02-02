using System.Collections.Generic;
using System.IO;

namespace instadev.Models
{
    public class InstadevBase
    {
        public void CreateFolderAndFile(string path){
            string folder = path.Split("/")[0];
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
        public List<string> ReadAllLinesCSV(string path){
            List<string> linhas = new List<string>();
            string linha;
            using(StreamReader file = new StreamReader(path))
            {
                while((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }
            return linhas;
        }
        public void RewriteCsv(string path, List<string> linhas){
            using (StreamWriter output = new StreamWriter(path))
            {
                foreach (var linha in linhas)
                {
                    output.Write($"{linha}\n");
                }
            }
        }
    }
}