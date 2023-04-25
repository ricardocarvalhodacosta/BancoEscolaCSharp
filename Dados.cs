using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Escola
{
    public class Dados
    {
        public int Matricula { get; set; }
        public char Sala { get; set; }
        public string Aluno { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Media { get; set; }

        public string JsonSerializar(Dados dados)
        {
            return JsonConvert.SerializeObject(dados);
        }

        // método para desserializar objeto em formato JSON
        public static Dados JsonDesserializar(string json)
        {
            return JsonConvert.DeserializeObject<Dados>(json);
        }
    }
}

