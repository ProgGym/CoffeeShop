using System.Collections.Generic;
using System.Linq;

namespace ProgGym.CoffeeShop.ApplicationCore.Entities.BasketAggregate;

public class Basket : BaseEntity
{
    private readonly ICollection<BasketItem> _items;
    public Basket()
    {
        _items = new List<BasketItem>();
    }
    
    public void AddItem(int catalogItemId, decimal amountPrice, int quantity = 1)
    {
        var basket = new BasketItem(catalogItemId,amountPrice,quantity);
        if(_items.Any(i => i.CatalogItemId == catalogItemId))
        {
            
        }
    }
}