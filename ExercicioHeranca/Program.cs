using ExercicioHeranca.Entidades;
using System.Globalization;
List<Produto> produtos = new List<Produto>();
Console.Write("Entre com um numero de produtos: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Produto #{i+1}");
    Console.Write("Produto usado, comum ou importando C/U/I: ");
    char tipoProduto = char.Parse(Console.ReadLine());
    Console.Write("Nome do produto: ");
    string nome = Console.ReadLine();
    Console.Write("Valor: ");
    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(tipoProduto == 'i')
    {
        Console.Write("Taxa: ");
        double taxa = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

        produtos.Add(new ProdutoImportado(nome, valor, taxa));
    }else if (tipoProduto == 'u')
    {
        Console.Write("Data do produto: ");
        DateTime data = DateTime.Parse(Console.ReadLine());

        produtos.Add(new ProdutoUsado(nome, valor, data));
    }else if (tipoProduto == 'c')
    {
        produtos.Add(new Produto(nome, valor));

    }

    
}

Console.WriteLine("\n\nValores dos produtos: \n");

foreach (Produto produto in produtos)
{
    Console.WriteLine(produto.ValorTag());
}