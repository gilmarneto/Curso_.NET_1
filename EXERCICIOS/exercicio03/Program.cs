// data: 14/11/2024

/*
    ATIVIDADE 03

    Peça dua notas, em seguida realize a média e retorne a situação:
    > 7 - 10  = Aprovado
    > 5 - 6.9 = Recuperação
    > 0 - 4.9 = Reprovado(a)
*/

Console.WriteLine("##### Média Escolar #####");

Console.Write("informe a nota-1: ");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write("informe a nota-2: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2) / 2;

Console.Write("Média final do aluno: " + media + " ----- Status: ");

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media >= 5)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}

Console.WriteLine("########## Fim ##########");