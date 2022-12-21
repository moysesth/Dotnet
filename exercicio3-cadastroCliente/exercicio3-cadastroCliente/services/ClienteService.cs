using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Cliente.entity;
using Cliente.interfaces;

namespace Cliente.services
{
    internal class ClienteService
    {

        public static void CadastrarCliente(xCliente xCliente, List<xCliente> listaCliente, string nomeUsuario, string documentoCliente)
        {
            Console.Clear();
            Random rnd = new Random();
            xCliente.IdCliente = rnd.Next(30);
            Console.WriteLine($"Digite o {nomeUsuario} do cliente");
            xCliente.NomeCliente = Console.ReadLine();
            Console.WriteLine($"Digite o {documentoCliente} do cliente");
            xCliente.DocumentoCliente = Console.ReadLine();
            listaCliente.Add(xCliente);
        }

        public static void SerializerClientes(xCliente xCliente, string path)
        {
            string jsonString = JsonSerializer.Serialize(xCliente);
            using StreamWriter file = new StreamWriter(path, append: true);
            file.WriteLine(jsonString);
        }

        public static void LerUsuarios(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json;
                while ((json = r.ReadLine()) != null)
                {
                    var cliente = JsonSerializer.Deserialize<Clientes>(json);
                    Console.WriteLine(cliente.IdCliente);
                    Console.WriteLine("--------------------------");
                }
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                Console.ReadKey();
            }
        }
    }
}
