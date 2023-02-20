using CQRS_Example.Models;

namespace CQRS_Example.Data_Access
{
    public interface IProduct
    {   
        //get all the products
        List<Product> getAllProducts();

        //create products
        List<Product> createProduct(Product product);

        //to delete products by id
        public string deleteProduct(int id);

        //to update products
        List<Product> update(Product product);
    }
}
