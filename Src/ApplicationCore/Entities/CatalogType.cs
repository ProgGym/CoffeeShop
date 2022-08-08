namespace ProgGym.CoffeeShop.ApplicationCore.Entities;

public class CatalogType
{
    public int Id { get; set; }
    public string Type { get; private set; }
    public CatalogType(string type)
    {
        Type = type;
    }
}
