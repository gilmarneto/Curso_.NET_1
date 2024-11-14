// data: 14/11/2024

// Tabuada Simples
Console.WriteLine("##### Tabuada #####");

try
{
    Console.Write("Informe um número inteiro, que deseja ver a tabuada: ");
    int tabuada = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Ver tabuada do: " + tabuada);
    for (int num = 1; num <= 10; num++)
    {
        Console.WriteLine($"{tabuada} x {num} = {tabuada * num}");
    }
}
catch (Exception ex)
{
    Console.WriteLine("ERRO: " + ex);
}
finally
{
    Console.WriteLine("Fim da Tabuada!");
}

Console.WriteLine("####### Fim #######");
