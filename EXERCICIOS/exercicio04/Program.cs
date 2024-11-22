// data: 22/11/2024
using System;

/*
    ATIVIDADE 04

    Peça um dia de um determinado mês/ano, retorne o dia da semana.

    Observação: Neste exercício será utilizado como base o calendário de dezembro de 2024.
*/

Console.WriteLine(">>> INFORME UMA DATA, E VEJA O DIA DA SEMANA <<<");
Console.WriteLine(">>> ---------------------------------------- <<<");
Console.Write("informe uma data: ");
string dataString = Console.ReadLine();

DateTime dataConvertida = DateTime.ParseExact(dataString, "dd/MM/yyyy", null);

DayOfWeek diaDaSemana = dataConvertida.DayOfWeek;
Console.WriteLine(diaDaSemana);