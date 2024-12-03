/* 
    >>>>> Teste final <<<<<

    nome: Cadastro de Produtos
    by: Gilmar Neto
    data início: 25/11/2024
*/

/*
    Para este projeto eu vou utilizar:
    - Console ReadLine;
    - While;
    - Dictionary:
        - add;
*/

Dictionary<int, string> produtos = new Dictionary<int, string>();

int opcao = 1;

try
{
    do
    {
        Console.WriteLine(">>> Cadastro de Produtos <<<");
        Console.WriteLine("");
        Console.WriteLine("1 - Novo produto");
        Console.WriteLine("2 - Exibir produtos");
        Console.WriteLine("3 - Alterar produto");
        Console.WriteLine("4 - Remover produto");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("----------------------------");
        Console.Write("Digite a opção: ");
        opcao = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("----------------------------");
        // Opção 1 > Cadastrar novo produto
        if(opcao == 1)
        {
            Console.Write("informe o código do produto: ");
            int codProduto = Convert.ToInt16(Console.ReadLine());
            Console.Write("informe o nome do produto: ");
            string nomeProduto = Console.ReadLine();
            produtos.Add(codProduto, nomeProduto);
        }
        // Opção 2 > Exibir todos os produtos cadastrados
        else if(opcao == 2)
        {
            Console.WriteLine("--- Produtos Cadastrados ---");
            Console.WriteLine("");
            foreach(var produto in produtos)
            {
                Console.WriteLine($"Código: {produto.Key} ----- Produto: {produto.Value}");
            }
        }
        // Opção 3 > Alterar produto conforme código informado
        else if(opcao == 3)
        {
            Console.WriteLine("--- Alterar Produto ---");
            Console.WriteLine("");
            Console.Write("informe o código do produto que deseja alterar: ");
            int codProduto = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Produto Selecionado: ");
            Console.WriteLine(">>> " + produtos[codProduto]);
            Console.Write("informe a alteração: ");
            string nomeProduto = Console.ReadLine();
            produtos[codProduto] = nomeProduto;
            Console.WriteLine("--- Alteração realizada com sucesso. ---");
        }
        else if(opcao == 4)
        {
            
        }
        Console.WriteLine("----------------------------");
    }
    while(opcao != 0);
}
catch(Exception err)
{
    Console.WriteLine($"FALHA!! {err}");
}
finally
{
    Console.WriteLine("--- Sistema finalizado. ---");
};



