// data: 12/11/2024

double valor = 50.00;
string pagamento = "à vista";

if(valor == 100.00 && pagamento == "à vista")
{
    Console.WriteLine($"Valor à pagar com 10% de desconto: R${valor*0.9}");
} else {
    Console.WriteLine($"Valor para pagamento: R${valor}");
}