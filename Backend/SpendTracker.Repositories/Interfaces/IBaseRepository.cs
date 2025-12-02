namespace SpendTracker.Repositories.Interfaces;

public interface IBaseRepository<T> where T : class
{
    IQueryable<T> FindAll(bool trackChanges);
}
