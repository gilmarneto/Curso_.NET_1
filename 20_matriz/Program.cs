// data: 12/11/2024

// Matriz(linhas e colunas)
string[,] dados = {
    {"João", "RJ"},
    {"Paulo", "SP"},
    {"Maria", "MG"}
};

// vamos exibir o nome de Maria
Console.WriteLine(dados[2,0]); // primeiro linha, depois coluna

// vamos ver utilizando o foreach
foreach(string dado in dados)
{
    Console.WriteLine(dado);
}