using Ardalis.Specification;
using ProgGym.CoffeeShop.ApplicationCore.Entities.BasketAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgGym.CoffeeShop.ApplicationCore.Specifications;

public sealed class BasketWithItemsSpecificationByUser : Specification<Basket>, ISingleResultSpecification
{
    public BasketWithItemsSpecificationByUser(Guid buyerId)
    {

        Query
            .Where(b => b.UserId == buyerId)
            .Include(b => b.Items);
    }
}
