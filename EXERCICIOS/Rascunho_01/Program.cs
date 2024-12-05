// data: 04/12/2024

// Dicionário com Array
Dictionary<int, string[]> produtos = new Dictionary<int, string[]>();

// Create
produtos[1] = new string[] {"11", "12"};
produtos[2] = new string[] {"1001", "1002"};

// Read
foreach(var lista in produtos)
{
    Console.WriteLine(lista.Key+" ----- "+lista.Value[0]+" ----- "+lista.Value[1]);
}

// Update
produtos[1] = new string[] {"101", "102"};
// foreach(var lista in produtos)
// {
//     Console.WriteLine(lista.Key+" ----- "+lista.Value[0]+" ----- "+lista.Value[1]);
// }

// Delete
produtos.Remove(1);
foreach(var lista in produtos)
{
    Console.WriteLine(lista.Key+" ----- "+lista.Value[0]+" ----- "+lista.Value[1]);
}

