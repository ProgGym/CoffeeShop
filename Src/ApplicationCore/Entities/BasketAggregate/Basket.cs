using System.Collections.Generic;
using System.Linq;

namespace ProgGym.CoffeeShop.ApplicationCore.Entities.BasketAggregate;

public class Basket
{
    public Guid Id { get; set; }
    public List<BasketItem> Items { get; private set; }
    public Guid UserId { get; private set; }

    public DateTime CreateTime { get; private set; }
    public DateTime LastChengeTime => DateTime.Now;

    public int TotalItems => Items.Sum(i => i.Quantity);

    public Basket(Guid userId)
    {
        Items = new List<BasketItem>();
        UserId = userId;
        CreateTime = DateTime.Now;
    }
    
    public void AddItem(int catalogItemId, decimal amountPrice, int quantity = 1)
    {
        if(Items.Any(i => i.CatalogItemId == catalogItemId))
        {
            var existingItem = Items.FirstOrDefault(i => i.CatalogItemId == catalogItemId);
            existingItem.AddQuantity(quantity);
        }
        else
        {
            var newBasketItem = new BasketItem(catalogItemId,amountPrice,quantity);
            Items.Add(newBasketItem);
        }
    }

    public void DeleteItem(int catalogItemId)
    {
        var existingItem = Items.FirstOrDefault(i => i.CatalogItemId == catalogItemId);
        existingItem.DeleteQuantity();
    }

    public void RemoveEmptyItems()
    {
        Items.RemoveAll(i => i.Quantity == 0);
    }
}