namespace LabLibrary;

public interface IProductLogic
{
    Task<IEnumerable<ProductModel>> GetProductsForCategory(string category);
}