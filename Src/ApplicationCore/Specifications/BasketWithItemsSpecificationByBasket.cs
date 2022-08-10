using Ardalis.Specification;
using ProgGym.CoffeeShop.ApplicationCore.Entities.BasketAggregate;

namespace ProgGym.CoffeeShop.ApplicationCore.Specifications;

public sealed class BasketWithItemsSpecificationByBasket : Specification<Basket>, ISingleResultSpecification
{
    public BasketWithItemsSpecificationByBasket(Guid basketId) 
    {
        Query
            .Where(b => b.Id == basketId)
            .Include(b => b.Items);
    }
}
