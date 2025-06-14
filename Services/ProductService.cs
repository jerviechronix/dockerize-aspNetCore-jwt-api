using dockerize_aspNetCore_jwt_api.Models;

namespace dockerize_aspNetCore_jwt_api.Services;

public class ProductService
{
    private readonly List<Product> _products = [];
    private int _nextId = 1;

    public List<Product> GetAll() => _products;
    public Product? Get(int id) => _products.FirstOrDefault(p => p.Id == id);

    public Product Add(Product product)
    {
        product.Id = _nextId++;
        _products.Add(product);
        return product;
    }

    public bool Update(int id, Product updated)
    {
        var existing = Get(id);
        if (existing == null) return false;
        existing.Name = updated.Name;
        existing.Price = updated.Price;
        return true;
    }

    public bool Delete(int id)
    {
        var product = Get(id);
        return product != null && _products.Remove(product);
    }
}
