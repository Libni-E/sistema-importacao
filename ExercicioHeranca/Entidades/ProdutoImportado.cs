using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioHeranca.Entidades
{
    internal class ProdutoImportado:Produto

    {
        public double Taxa { get; set; }

        public ProdutoImportado()
        {

        }

        public ProdutoImportado(string nome, double valor, double taxa) :base(nome, valor)
        {
            Taxa = taxa;
        }

        public override string ValorTag()
        {
            double valorTotal = Valor + Taxa;
            return Nome + " $ " + valorTotal.ToString("f2", CultureInfo.InvariantCulture) + " Taxa de importação: $ " + Taxa.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
