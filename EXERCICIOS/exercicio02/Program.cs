// data: 14/11/2024

/*
    ATIVIDADE 02

    Peça um número e retorne se é par ou ímpar.
    DICA: Para sabermos se um número é par ou ímpar, será necessário utilizarmos o módulo (resto da divisão -> %)
*/

Console.WriteLine("----- Par ou Ímpar -----");
Console.Write("informe um número: ");
int ?num = Convert.ToInt32(Console.ReadLine());

// Com condicional
if(num%2 == 0)
{
    Console.WriteLine("O número informado é: PAR");
} else {
    Console.WriteLine("O número informado é: ÍMPAR");
}

// Com operador ternário
Console.WriteLine(num % 2 == 0 ? "Par" : "Ímpar");

