using System.ComponentModel.DataAnnotations;

namespace API.Entities.OrderCollection;

public class Order
{
    public int Id { get; set; }
    public string BuyerId { get; set; }
    [Required] public ShippingAddress ShippingAddress { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public List<OrderItem> OrderItems { get; set; }
    public long SubTotal { get; set; }
    public long DeliveryFee { get; set; }
    public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;

    public long GetTotal()
    {
        return SubTotal + DeliveryFee;
    }

}
