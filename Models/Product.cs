namespace NexaShop.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }

    #region Relacionamentos

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    
    #endregion
}