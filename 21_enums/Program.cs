// data: 14/11/2024

// Vamos aprender sobre o Enum.

enum Pais // O nome sempre com a primeira letra em maiúscula
{
    Brasil,
    Canada, // não pode conter caractéres especiais
    Estados_Unidos,
    Mexico 
}

// Vamos exibir:
// Console.WriteLine(Pais.Brasil); // vai acontecer um erro, pois precisamos criar uma classe para chamar o Enum.

// Vamos criar uma classe

class Program
{
    static void Main()
    {
        Console.WriteLine(Pais.Brasil);
    }
}