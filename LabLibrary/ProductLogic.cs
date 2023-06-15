using Microsoft.Extensions.Logging;

namespace LabLibrary;

public class ProductLogic : IProductLogic
{
    private readonly ILogger<ProductLogic> _logger;

    public ProductLogic(ILogger<ProductLogic> logger)
    {
        _logger = logger;
    }
    public Task<IEnumerable<ProductModel>> GetProductsForCategory(string category)
    {
        _logger.LogInformation("Getting products in logic for {category}", category);
        return Task.FromResult(GetAllProducts().Where(a =>
            string.Equals("all", category, StringComparison.InvariantCultureIgnoreCase) ||
            string.Equals(category, a.Category, StringComparison.InvariantCultureIgnoreCase)));
    }

    private static IEnumerable<ProductModel> GetAllProducts()
    {
        return new List<ProductModel>
        {
            new ProductModel
            {
                Id = 1, Name = "Hell Bus", Category = "vehicle", Price = 666.66,
                Description = "Best bus you can drive to hell"
            },
            new ProductModel
            {
                Id = 2, Name = "Equalizer", Category = "sound", Price = 12.23,
                Description = "Make it even, all of it"
            },
            new ProductModel
            {
                Id = 3, Name = "Man of Wood", Category = "sculpture", Price = 263.12,
                Description = "You will never, ever be alone again"
            },
            new ProductModel
            {
                Id = 4, Name = "Motorcycle", Category = "vehicle", Price = 8347.12,
                Description = "You too can be a bad ass!"
            }
        };
    }
}
