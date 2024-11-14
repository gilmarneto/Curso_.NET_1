// data: 14/11/2024

/*
    ATIVIDADE 01

    Peça dois números inteiros, se forem iguais realize a soma, se forem diferentes realize a multiplicação.
*/

Console.Write("informe um número inteiro: ");
int ?n1 = Convert.ToInt16(Console.ReadLine());
Console.Write("informe outro número inteiro: ");
int ?n2 = Convert.ToInt16(Console.ReadLine());

if(n1 == n2)
{
    Console.WriteLine($"A soma entre {n1} e {n2} é: {n1 + n2}");
} else {
    Console.WriteLine($"A multiplicação entre {n1} e {n2} é: {n1 * n2}");
}

Console.Write("-- Fim --");
