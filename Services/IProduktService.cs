using MattiasHandel.Models;

namespace MattiasHandel.Services
{
    public interface IProduktService
    {
        IEnumerable<Produkt> GetAllProducts();
        Produkt GetProductById(int productId);
        void AddProduct(Produkt product);
        void UpdateProduct(Produkt product);
        void DeleteProduct(int productId);
    }
}
