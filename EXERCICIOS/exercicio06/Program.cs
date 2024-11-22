// data: 22/11/2024

/*
    ATIVIDADE 06

    Peça um número inteiro, retorne se é um número positivo, neutro ou negativo

    Exemplos:
    -5: negativo
    34: positivo
    -3: negativo
     0: neutro
*/
Console.Write("informe um número: ");
int numero = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(numero);

if(numero > 0)
{
    Console.WriteLine("O número informado é positivo.");
} 
else if(numero < 0)
{
    Console.WriteLine("O número informado é negativo.");
}
else
{
    Console.WriteLine("O número informado é nulo.");
}
