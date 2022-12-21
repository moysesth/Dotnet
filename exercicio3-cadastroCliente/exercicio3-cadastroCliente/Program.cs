using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Cliente.entity;
using Cliente.services;
using Cliente.interfaces;

internal class Program
{
    private static void Main(string[] args)

    {
        List<xCliente> clienteLista = new List<xCliente>();
        List<Clientes> clienteDeserialiser = new List<Clientes>();
        var path = @"D:\Users\moyses\Moyses-AsusDesktop\codigo-do-futuro\Dotnet\exercicio3-cadastroCliente\exercicio3-cadastroCliente\exports\clientes.json";

        while (true)
        {
            Console.Clear();
            Console.WriteLine("""
                Bem vindo ao Sistema de Cadastros.
                Selecione qual opção você deseja acessar:
                1 - Cadastrar Cliente PJ
                2 - Cadastrar Cliente PF
                3 - Listar usuários cadastrados
                4 - Sair
                Qual a sua opção ?
                """);

            int escolha = int.Parse(Console.ReadLine().Trim());
            Console.Clear();
            bool quit = false;
            switch (escolha)
            {
                case 1:
                    Console.Clear();
                    var fornecedor = new Fornecedor() { TipoCliente = "J" };
                    ClienteService.CadastrarCliente(fornecedor, clienteLista, "Nome Fantasia", "CNPJ");
                    ClienteService.SerializerClientes(fornecedor, path);
                    break;
                case 2:
                    var usuario = new UsuarioPf() { TipoCliente = "F" };
                    ClienteService.CadastrarCliente(usuario, clienteLista, "Nome", "CPF");
                    ClienteService.SerializerClientes(usuario, path);
                    break;
                case 3:
                    ClienteService.LerUsuarios(path);
                    break;
                case 4:
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
}