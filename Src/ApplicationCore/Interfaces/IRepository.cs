using Ardalis.Specification;

namespace ProgGym.CoffeeShop.ApplicationCore.Interfaces;

interface IRepository<T> : IRepositoryBase<T> where T : class
{
    
}