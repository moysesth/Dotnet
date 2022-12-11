namespace Estoque.Models;

public record Produto
{
    public int IDProduto { get; set; }
    public string NomeProduto { get; set; } = default!;
    public int QuantiaItem { get; set; }
}
