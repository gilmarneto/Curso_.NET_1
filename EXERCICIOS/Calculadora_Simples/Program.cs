// data: 13/11/2024

// Calculadora Simples
Console.WriteLine("########## Calculadora Simples ##########");
Console.Write("informe um número: ");
int ?n1 = Convert.ToInt16(Console.ReadLine());
Console.Write("informe o operador: ");
string ?op = Console.ReadLine();
Console.Write("informe outro número: ");
int ?n2 = Convert.ToInt16(Console.ReadLine());

// Calcular
string resultado = op switch
{
    "+" => $"{n1+n2}",
    "-" => $"{n1-n2}",
    "*" => $"{n1*n2}",
    "/" => $"{n1/n2}",
    _   => "Operador inválido!!"
};

// Exibir resultado
Console.WriteLine($"Resultado: {n1} {op} {n2} = {resultado}");

Console.WriteLine("################## FIM ##################");