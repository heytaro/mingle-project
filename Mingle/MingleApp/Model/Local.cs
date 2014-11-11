using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingleApp.Model
{
    public class Local
    {
        public string cidade, rua, numero, estado, pais, nome, predio;
        public Local(string cidade, string rua, string numero, string estado, string pais, string nome, string predio)
        {
            this.cidade = cidade;
            this.numero = numero;
            this.estado = estado;
            this.pais = pais;
            this.nome = nome;
            this.predio = predio;
            this.rua = rua;
        }
        public String toString()
        {
            return nome + " " + predio + " " + rua + " " + numero + " " + cidade + " " + estado + " " + pais;
        }
    }
}
