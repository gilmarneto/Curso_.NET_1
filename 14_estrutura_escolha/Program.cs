// data: 12/11/2024

// vamos aprender sobre estrutura de escolha, (switch case)
string linguagem = "CSS";

// switch (linguagem)
// {
//     case "HTML":
//         Console.WriteLine("Linguagem de marcação.");
//         break;
//     case "CSS":
//         Console.WriteLine("Linguagem de estilos.");
//         break;
//     case "C#":
//         Console.WriteLine("Linguagem de programação.");
//         break;
//     default:
//         Console.WriteLine("Linguagem desconhecida.");
//         break;
// }

// Temos também Exprssão Switch
string retorno = linguagem switch
{
    "HTML" => "Linguagem de marcação",
    "CSS"  => "Linguagem de estilos",
    "C#"   => "Linguagem de programação",
    _      => "Linguagem desconhecida."
};
// Exibir retorno
Console.WriteLine(retorno);