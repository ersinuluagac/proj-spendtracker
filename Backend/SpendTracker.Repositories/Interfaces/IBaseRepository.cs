using System.Linq.Expressions;

namespace SpendTracker.Repositories.Interfaces;

public interface IBaseRepository<T> where T : class
{
    /// <summary>
    /// Bütün kayıtları getirecek sorguyu oluşturur.
    /// </summary>
    /// <param name="trackChanges">
    /// Verilerin değişiklik takibinin (Change Tracker) yapılıp yapılmayacağını belirler.
    /// Sadece okuma işlemleri için 'false' verilmesi performansı artırır.
    /// </param>
    /// <returns>
    /// Filtreleme veya sıralama eklenebilecek temel sorgu.
    /// </returns>
    IQueryable<T> FindAll(bool trackChanges);

    /// <summary>
    /// Verilen koşula (expression) uyan kayıtları getirmek üzere sorguyu hazırlar.
    /// </summary>
    /// <param name="expression">
    /// Veritabanı sorgusunda 'WHERE' şartı olarak işlenecek lambda ifadesi.
    /// </param>
    /// <param name="trackChanges">
    /// Verilerin değişiklik takibinin (Change Tracker) yapılıp yapılmayacağını belirler.
    /// Sadece okuma işlemleri için 'false' verilmesi performansı artırır.
    /// </param>
    /// <returns>
    /// Koşula uyan, üzerinde zincirleme işlem (OrderBy, Select vb.) yapılabilecek sorgu sonucu.</returns>
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

    /// <summary>
    /// Veritabanına eklenmek üzere yeni bir nesneyi işaretler (State: Added).
    /// </summary>
    /// <param name="entity">
    /// Veritabanına kaydedilecek olan varlık (entity).
    /// </param>
    void Create(T entity);

    /// <summary>
    /// Veritabanında güncellenmek üzere bir nesneyi işaretler (State: Modified).
    /// </summary>
    /// <param name="entity">
    /// Veritabanında güncellenecek olan varlık (entity).
    /// </param>
    void Update(T entity);

    /// <summary>
    /// Veritabanından silinmek üzere bir nesneyi işaretler (State: Deleted).
    /// </summary>
    /// <param name="entity">
    /// Veritabanından silinecek olan varlık (entity).
    /// </param>
    void Delete(T entity);
}
