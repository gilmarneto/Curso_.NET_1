// data: 21/11/2024

using System.Collections;

ArrayList lista = new ArrayList();
// add items
lista.Add("Gilmar");
lista.Add(40);
lista.Add(8.5);
lista.Add(true);

// exibir lista
foreach(var l in lista)
{
    Console.WriteLine($"--- {l} ---");
}