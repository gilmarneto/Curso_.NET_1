// data: 22/11/2024

// Manipular Data

// ex-01 -> obtendo data e hora atual
DateTime agora = DateTime.Now;
Console.WriteLine(agora); 

// ex-02 -> obtendo apenas a data atual
DateTime dataAtual = DateTime.Today;
Console.WriteLine(dataAtual);

// ex-03 -> obtendo o mês de uma data
int mes = agora.Month;
Console.WriteLine(mes);

// ex-04 -> obtendo o dia da semana de uma data
DayOfWeek diaDaSemana = agora.DayOfWeek;
Console.WriteLine(diaDaSemana);

// ex-05 -> adicionando dias a uma data
DateTime dataFutura = agora.AddDays(8);
Console.WriteLine(dataFutura);

// ex-06 -> calculando a diferença entre duas datas
TimeSpan diferencaDatas = dataFutura - dataAtual;
Console.WriteLine(diferencaDatas);

// ex-07 -> subtraindo dias de uma data
DateTime dataPassada = agora.AddDays(-8);
Console.WriteLine(dataPassada);