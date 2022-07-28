namespace ProgGym.CoffeeShop.ApplicationCore.Entities.BasketAggregate;

public class BasketItem : BaseEntity
{
    public decimal AmountPrice { get; private set; }
    public int Quantity { get; private set; }
    public int CatalogItemId { get; private set; }
    public BasketItem(int catalogItemId, decimal amountPrice, int quantity)
    {
        CatalogItemId = catalogItemId;
        AmountPrice = amountPrice;
        Quantity = quantity;
    }

}