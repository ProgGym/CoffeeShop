namespace ProgGym.CoffeeShop.ApplicationCore.Entities;

public class CatalogItem
{
    public int Id { get; set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public string PictureUri { get; private set; }
    public int CatalogTypeId { get; private set; }
    public CatalogType CatalogType { get; private set; }


    public CatalogItem(string name, string description, decimal price,string pictureUri, int catalogItemId)
    {
        Name = name;
        Description = description;
        Price = price;
        PictureUri = pictureUri;
        CatalogTypeId = catalogItemId;
    }
}
