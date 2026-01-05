using SpendTracker.Entities.Models;

namespace SpendTracker.Repositories.Interfaces;

public interface ICategoryRepository : IBaseRepository<Category>
{
    /// <summary>
    /// Bütün kategori kayıtlarını veritabanından asenkron olarak getirir.
    /// </summary>
    /// <param name="trackChanges">
    /// Verilerin değişiklik takibinin (Change Tracker) yapılıp yapılmayacağını belirler.
    /// Sadece okuma işlemleri için 'false' verilmesi performansı artırır.
    /// </param>
    /// <returns>
    /// Veritabanından çekilen kategorilerin listesini içeren asenkron görev.
    /// </returns>
    Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges);

    /// <summary>
    /// Verilen ID'ye sahip kategori kaydını veritabanından asenkron olarak getirir.
    /// </summary>
    /// <param name="id">
    /// Getirilecek kategorinin ID değeri.
    /// </param>
    /// <param name="trackChanges">
    /// Verilerin değişiklik takibinin (Change Tracker) yapılıp yapılmayacağını belirler.
    /// Sadece okuma işlemleri için 'false' verilmesi performansı artırır.
    /// </param>
    /// <returns>
    /// Bulunursa ilgili kategori nesnesi, bulunamazsa 'null' değerini içeren asenkron görev.
    /// </returns>
    Task<Category?> GetCategoryByIdAsync(int id, bool trackChanges);

    /// <summary>
    /// Veritabanına eklenmek üzere yeni bir kategori kaydı oluşturur.
    /// </summary>
    /// <param name="category">
    /// Veritabanına kaydedilecek kategori nesnesi.
    /// </param>
    void CreateCategory(Category category);

    /// <summary>
    /// Veritabanındaki mevcut bir kategori kaydını günceller.
    /// </summary>
    /// <param name="category">
    /// Veritabanında güncellenecek kategori nesnesi.
    /// </param>
    void UpdateCategory(Category category);

    /// <summary>
    /// Veritabanındaki bir kategori kaydını siler.
    /// </summary>
    /// <param name="category">
    /// Veritabanından silinecek kategori nesnesi.
    /// </param>
    void DeleteCategory(Category category);
}
