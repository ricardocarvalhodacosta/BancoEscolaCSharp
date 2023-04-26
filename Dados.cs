using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Security.Permissions;

namespace Escola
{
    public class Dados
    {
        public int Matricula { get; set; }
        public string Sala { get; set; }
        public string Aluno { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Media { get; set; }

        public Dados (int matricula, string sala, string aluno, float nota1, float nota2, float media)
        {
            Matricula = matricula;
            Sala = sala;
            Aluno = aluno;
            Nota1 = nota1;
            Nota2 = nota2;
            Media = (nota1 + nota2) / 2;
        }

        public Dados()
        {
        }

        public bool JsonSerializar(Dados dados, string path)
        {
            var strJson = JsonConvert.SerializeObject(dados);
            return SaveFileDados(strJson, path);
        }

        // método para desserializar objeto em formato JSON
        public static Dados JsonDesserializar(string path)
        {
            var strJson = OpenFileDados(path);
            if (strJson.Substring(0, 5) != "Falha")
                return JsonConvert.DeserializeObject<Dados>(strJson);
            else
            {
                var dados = new Dados();
                dados.Aluno = strJson;
                return dados;
            }
        }

        public bool JsonSerializarLista(List<Dados> lista, string path)
        {
            var strJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
            return SaveFileDados(strJson, path);
        }

        private bool SaveFileDados(string strJson, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(strJson);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
                return false;
            }
        }

        public static List<Dados> JsonDesserializarLista(string path)
        {
            var strJson = OpenFileDados(path);
            if (strJson.Substring(0, 5) != "Falha")
                return JsonConvert.DeserializeObject<List<Dados>>(strJson);
            else
            {
                var listaDados = new List<Dados>();
                var dados = new Dados();
                dados.Aluno = strJson;
                listaDados.Add(dados);
                dados.Aluno = strJson;
                return listaDados;
            }
        }

        private static string OpenFileDados(string path)
        {
            try
            {
                var strJson = "";

                using (StreamReader sr = new StreamReader(path))
                {
                    strJson = sr.ReadToEnd();
                }
                return strJson;
            }
            catch (Exception ex)
            {
                return "Falha: " + ex.Message;
            }
        }
    }
}

