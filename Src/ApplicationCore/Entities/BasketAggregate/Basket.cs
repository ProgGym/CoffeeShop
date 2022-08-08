using System.Collections.Generic;
using System.Linq;

namespace ProgGym.CoffeeShop.ApplicationCore.Entities.BasketAggregate;

public class Basket
{
    public int Id { get; set; }
    public List<BasketItem> Items { get; private set; }

    public int TotalItems => Items.Sum(i => i.Quantity);

    public Basket()
    {
        Items = new List<BasketItem>();
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