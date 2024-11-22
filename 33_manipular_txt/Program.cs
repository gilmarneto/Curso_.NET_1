// data: 21/11/2024

// texto
string texto = "Gerando um arquivo (.txt), utilizando C#.";

// vamos aprender a criar um arquivo txt e também abrir
File.WriteAllText("arquivo.txt", texto);

// lendo um arquivo (.txt), utilizando C#
string lerArquivoGerado = File.ReadAllText("arquivo.txt");

// exibindo valor do arquivo
Console.WriteLine(lerArquivoGerado);