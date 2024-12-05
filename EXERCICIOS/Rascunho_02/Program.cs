// data: 05/12/2024

List<(int, string, double)> produtos = new List<(int, string, double)>();

produtos.Add((1, "leite", 2.50));

Console.WriteLine(produtos.Count);

foreach (var produto in produtos)
{
    Console.WriteLine(produto);
}