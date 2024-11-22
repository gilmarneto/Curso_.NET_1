// data: 22/11/2024

/*
    ATIVIDADE 05

    Peça um ano e retorne se é bissexto ou não.

    Dica: um ano bissexto ocorre a cada 4 anos.
*/

Console.Write("informe um ano: ");
int ano = Convert.ToInt16(Console.ReadLine());

string anoBissexto = (ano%4 == 0 ? "Ano bissexto":"Ano não bissexto");
Console.WriteLine(anoBissexto);