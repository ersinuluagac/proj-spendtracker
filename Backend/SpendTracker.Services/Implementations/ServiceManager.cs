using SpendTracker.Services.Interfaces;

namespace SpendTracker.Services.Implementations;

public class ServiceManager : IServiceManager
{
    private readonly ICategoryService _categoryService;

    public ServiceManager(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public ICategoryService CategoryService => _categoryService;
}
