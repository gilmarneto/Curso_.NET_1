// data: 28/11/2024

// dicionario
Dictionary<int, string> nomes = new Dictionary<int, string>();

int opcao = 1;
int cod = 0;

do
{
    Console.Write("informe um nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("------------------------------");
    nomes.Add(cod+1, nome);

    foreach(var lista in nomes)
    {
        Console.WriteLine(lista.Key + " -----> " + lista.Value);
        cod = lista.Key;
    }
    Console.WriteLine("------------------------------");
    Console.Write("Digite 1 para continuar ou 0 para finalizar sistema: ");
    opcao = Convert.ToInt16(Console.ReadLine());
} while(opcao != 0);
Console.WriteLine("------------ Fim -------------");