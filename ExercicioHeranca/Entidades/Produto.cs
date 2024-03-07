using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca.Entidades
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public virtual string ValorTag()
        {
            return Nome + " $ " + Valor.ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
