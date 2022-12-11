
using System.Collections.Generic;
using Estoque.Models;

namespace Estoque.Services;

public class ProdutoServico
{
    public List<Produto> listaProdutos = new List<Produto>();
    private static ProdutoServico estoque = default!;

    private ProdutoServico() { }

    public static ProdutoServico Get()
    {
        if (estoque == null) estoque = new ProdutoServico();
        return estoque;
    }
    public List<Produto> Lista = new List<Produto>();

    private readonly Random _random = new Random();
    
}