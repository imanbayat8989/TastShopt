using TastShopt.Models;

namespace TastShopt.Repository.IRepository
{
    public interface IProductRepo: IRepo<Product>
    {
        Task<Product> UpdateAsync(Product entity);
    }
}
