using CLean_arch_Application.Products.DTOs;

namespace CLean_arch_Application.Products
{
    public interface IProductService
    {
        void AddProduct(AddProductDto command);
        void EditProduct(EditProductDto command);
        ProductDto GetProductById(Guid Productid);

        List<ProductDto> GetProductS();
    }
}
