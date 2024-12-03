﻿/* 
    >>>>> Teste final <<<<<

    nome: Cadastro de Produtos
    by: Gilmar Neto
    data início: 25/11/2024
*/
// Variáveis
int opcao = 1;
bool exibirMenu = true;
string menuOuContinuar = "";
// Dicionário de produtos
Dictionary<int, string> produtos = new Dictionary<int, string>();

Console.Clear();
try{
    do
    {
        if(exibirMenu == true)
        {
            Console.WriteLine(">>> Cadastro de Produtos <<<");
            Console.WriteLine("");
            Console.WriteLine("1 - Novo produto");
            Console.WriteLine("2 - Exibir produtos");
            Console.WriteLine("3 - Alterar produto");
            Console.WriteLine("4 - Remover produto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.Write("Digite a opção: ");
            opcao = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("----------------------------");
            exibirMenu = false;
        }

        if(opcao == 1)
        {
            do{
                Console.Clear();
                Console.WriteLine(">>> Novo Produto <<<");
                Console.WriteLine("");
                Console.Write("informe o código do produto: ");
                int codProduto = Convert.ToInt16(Console.ReadLine());
                Console.Write("informe o nome do produto: ");
                string ?nomeProduto = Console.ReadLine();
                produtos.Add(codProduto, nomeProduto);
                Console.WriteLine("");
                Console.WriteLine("Cadastro realizado com sucesso.");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("");
                Console.Write("Digite, m=menu ou c=continuar: ");
                menuOuContinuar = Console.ReadLine();
                if(menuOuContinuar == "m")
                {
                    exibirMenu = true;
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                }
            } while(menuOuContinuar != "m");
        }
        else if(opcao == 2)
        {
            Console.Clear();
            Console.WriteLine(">>> Listar Produtos <<<");
            Console.WriteLine("");
            Console.WriteLine("Código     Produto");
            foreach(var lista in produtos)
            {
                Console.WriteLine($"{lista.Key}          {lista.Value}");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.Write("Digite, m=menu: ");
            menuOuContinuar = Console.ReadLine();
            Console.Clear();
            exibirMenu = true;
        }
        else if(opcao == 3)
        {
            Console.Clear();
            Console.WriteLine(">>> Alterar Produto <<<");
            Console.WriteLine("");
            Console.Write("informe o código do produto que deseja alterar: ");
            int codProduto = Convert.ToInt16(Console.ReadLine());
            string ?produtoSelecionado = produtos[codProduto];
            Console.WriteLine("");
            Console.WriteLine($"Produto selecionado: {produtoSelecionado}");
            Console.Write("Digite sua alteração: ");
            string ?alteracao = Console.ReadLine();
            produtos[codProduto] = alteracao;
            Console.WriteLine("");
            Console.WriteLine("Alteração realizada com sucesso.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.Write("Digite, m=menu: ");
            menuOuContinuar = Console.ReadLine();
            Console.Clear();
            exibirMenu = true;
        }
        else if(opcao == 4)
        {
            Console.Clear();
            Console.WriteLine(">>> Remover Produto <<<");
            Console.WriteLine("");
            Console.Write("informe o código do produto que deseja remover: ");
            int codProduto = Convert.ToInt16(Console.ReadLine());
            string ?produtoSelecionado = produtos[codProduto];
            Console.WriteLine("");
            Console.WriteLine($"Produto selecionado: {produtoSelecionado}");
            produtos.Remove(codProduto);
            Console.WriteLine("");
            Console.WriteLine("Produto removido com sucesso.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.Write("Digite, m=menu: ");
            menuOuContinuar = Console.ReadLine();
            Console.Clear();
            exibirMenu = true;
        }
    }while(opcao != 0);
}
catch(Exception err)
{
    Console.WriteLine($"##### FALHA!!! {err.Message} #####");
}
finally
{
    Console.WriteLine($"##### Sistema finalizado. #####");
}
