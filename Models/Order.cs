namespace NexaShop.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public decimal TotalAmount { get; set; }
    public List<OrderItem> Items { get; set; } = [];

    #region Relacionamentos

    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
    
    #endregion
}