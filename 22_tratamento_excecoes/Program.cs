// data: 14/11/2024


// Sem tratamento de exceções
// Entrada de valores numéricos
/*
Console.Write("Informe um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
*/

// Com tratamento de exceções
try
{
    // Entrada de valores numéricos
    Console.Write("Informe um número inteiro: ");
    int num = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine($"Houve uma falha: {ex.Message}");
}
finally
{
    Console.WriteLine("Sistema finalizado.");
};