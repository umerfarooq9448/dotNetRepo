using CQRS_Example.Data_Access;
using CQRS_Example.Models;

namespace CQRS_Example.Repositories
{
    public class ProductRepositories : IProduct
    {
        private readonly ProductDatabaseContext _dbContext;


        public ProductRepositories(ProductDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Product> createProduct(Product product)
        {
            

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return _dbContext.Products.ToList();
        }

        public string deleteProduct(int id)
        {
            var data = _dbContext.Products.FirstOrDefault(x => x.ProductId == id);

            if (data != null)
            {

                _dbContext.Products.Remove(data);   
                _dbContext.SaveChanges ();
            }
            return "deleted boss";
        }

        public List<Product> getAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public List<Product> update(Product product)
        {
            var findProduct = _dbContext.Products.Find(product.ProductId);

            if(findProduct != null)
            {
                findProduct.ProductName = product.ProductName;
                findProduct.ProductPrice = product.ProductPrice;
                _dbContext.SaveChanges();
            }
             
            return _dbContext.Products.ToList();
        }
    }
}
