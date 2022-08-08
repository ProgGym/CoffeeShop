namespace ProgGym.CoffeeShop.ApplicationCore.Entities.BasketAggregate;

public class BasketItem
{
    public int Id { get; set; }
    public decimal AmountPrice { get; private set; }
    public int Quantity { get; private set; }
    public int CatalogItemId { get; private set; }
    public CatalogItem CatalogItem { get; private set; }

    public BasketItem(int catalogItemId, decimal amountPrice, int quantity)
    {
        CatalogItemId = catalogItemId;
        AmountPrice = amountPrice;
        Quantity = quantity;
    }

    public void AddQuantity(int quantity)
    {
        Quantity += quantity;
    }

    public void DeleteQuantity()
    {
        Quantity -= 1;
    }

}