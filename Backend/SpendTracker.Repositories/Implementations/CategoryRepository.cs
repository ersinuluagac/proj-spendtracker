using Microsoft.EntityFrameworkCore;
using SpendTracker.Entities.Models;
using SpendTracker.Repositories.Contexts;
using SpendTracker.Repositories.Interfaces;

namespace SpendTracker.Repositories.Implementations;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    // Constructor (Bağımlılıkların enjekte edildiği yer)
    public CategoryRepository(AppDbContext context) : base(context)
    {
        // context bağımlılığı BaseRepository üzerinden alınıyor.
    }

    // Methods
    #region Read Methods (Veri okuma, sorgulama işlemleri)
    public async Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges)
    {
        return await FindAll(trackChanges)
            .ToListAsync();
    }
    public async Task<Category?> GetCategoryByIdAsync(int id, bool trackChanges)
    {
        return await FindByCondition(category => category.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();
    }
    #endregion

    #region Write Methods (Veri ekleme, silme, güncelleme işlemleri)
    public void CreateCategory(Category category)
    {
        Create(category);
    }
    public void DeleteCategory(Category category)
    {
        Update(category);
    }   
    public void UpdateCategory(Category category)
    {
        Delete(category);
    }
    #endregion
}
