namespace ProgGym.CoffeeShop.ApplicationCore.Entities;

public class CatalogType : BaseEntity
{
    public string Type { get; set; }
    public CatalogType(string type)
    {
        Type = type;
    }
}
