// data: 28/11/2024

// vamos aprender sobre dicionário
Dictionary<int, string> nomes = new Dictionary<int, string>();

nomes.Add(1, "Gilmar");
nomes.Add(2, "Andreia");
nomes.Add(3, "Kelwin");

int codigo = 0;

// exibir chaves e valores do dicionário
foreach(var lista in nomes)
{
    Console.WriteLine(lista.Key + " ----- " + lista.Value);
    codigo = lista.Key;
}

Console.WriteLine(codigo);

Console.Write("informe um nome: ");
string nome = Console.ReadLine();
codigo = codigo + 1;
nomes.Add(codigo,nome);

// exibir chaves e valores do dicionário
foreach(var lista in nomes)
{
    Console.WriteLine(lista.Key + " ----- " + lista.Value);
}