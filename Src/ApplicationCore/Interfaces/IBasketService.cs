using ProgGym.CoffeeShop.ApplicationCore.Entities.BasketAggregate;

namespace ProgGym.CoffeeShop.ApplicationCore.Interfaces;

public interface IBasketService
{
    Task<Basket> AddItemAsync(Guid userId, int catalogItemId, decimal price, int quentity = 1);
    Task<Basket> DeleteItemAsync(int catalogItemId);
    Task DeleteBasketAsync(Guid basketId);
}
