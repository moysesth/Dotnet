//ENUNCIADO:
//Seu roberto é um comerciante e precisa de um sistema 
//para armazenar os produtos do seu armazem

//Crie um programa que tenha um menu mostrando as opções de cadastro.

//1 - Cadastrar produto
//2 - Listar produtos cadastrados
//3 - Quantidade total de itens no estoque
//4 - Sair

//no produto terá os atributos
//- id
//- nome
//- quantidade

using System;
using System.IO;
using Estoque.Services;
using Estoque.Models;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("""
                Bem vindo ao Sistema do seu Armazém.
                Selecione qual opção você deseja acessar:
                1 - Cadastrar produtos
                2 - Listar produtos cadastrados
                3 - Quantidade total de itens no estoque
                4 - Sair
                Qual a sua opção ?
                """);

                var escolha = Console.ReadLine().Trim();

                Console.Clear();
                bool quit = false;

                switch (escolha)
                {
                    case "1":
                        Console.Clear();
                        cadastrarNovoProduto();
                        break;
                    case "2":
                        listarEstoque();
                        Console.Clear();
                        break;
                    case "3":
                        quantiaTotal();
                        Console.Clear();
                        break;
                    case "4":
                        quit = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                if (quit) break;
            }
        }

        static void cadastrarNovoProduto()
        {
            Random rnd = new Random();

            Console.Clear();
            int idProduto = rnd.Next(30);
            Console.WriteLine("Digite o nome do novo produto: ");
            var nomeProduto = Console.ReadLine();
            Console.WriteLine("Qual a quantia em estoque desse produto?");
            var quantiaItem = Convert.ToInt16(Console.ReadLine());

            ProdutoServico.Get().Lista.Add(new Produto
            {
                IDProduto = idProduto,
                NomeProduto = nomeProduto ?? "[Novo produto]",
                QuantiaItem = quantiaItem
            });

            Console.WriteLine("O produto " + nomeProduto + " foi adicionado com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadKey();
        }

        static void listarEstoque()
        {
            Console.Clear();
            if (ProdutoServico.Get().Lista.Count == 0)
            {
                Console.WriteLine("Não há produtos cadastrados");
            }
            else
            {
                Console.WriteLine("Abaixo estão os seus produtos cadastrados no estoque:");
                foreach (var produto in ProdutoServico.Get().Lista)
                {
                    Console.WriteLine("ID do produto: " + produto.IDProduto + "\n Nome do Produto: " + produto.NomeProduto + "\r\n--------");
                }
            }
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadKey();
        }

        static void quantiaTotal()
        {
            if (ProdutoServico.Get().Lista.Count == 0)
            {
                Console.WriteLine("Não existem produtos cadastrados!");
            }
            else
            {
                foreach (var produto in ProdutoServico.Get().Lista)
                {
                    Console.WriteLine("Nome do Produto: " + produto.NomeProduto + "\nQuantia em Estoque: " + produto.QuantiaItem + "\r\n--------");
                }
            }
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadKey();
        }



    }
}