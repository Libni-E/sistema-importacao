using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca.Entidades
{
    internal class ProdutoUsado:Produto
    {
        public DateTime Manufatura { get; set; }

        public ProdutoUsado() { }

        public ProdutoUsado(string nome, double valor, DateTime manufatura) : base(nome, valor)
        {
            Manufatura = manufatura;
        }

        public override string ValorTag()
        {
            return Nome + " (usado) " + Valor.ToString("f2",CultureInfo.InvariantCulture) + " Data de manufatura: " + Manufatura.ToString("dd/MM/yyyy"); 
        }
    }
}
