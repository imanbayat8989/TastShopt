using TastShopt.Data;
using TastShopt.Models;
using TastShopt.Repository.IRepository;

namespace TastShopt.Repository
{
    public class ProductRepo:Repo<Product>, IProductRepo
    {
        private readonly ApplicationDbContext _db;
        public ProductRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Product> UpdateAsync(Product entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.products.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
