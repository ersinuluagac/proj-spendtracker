namespace SpendTracker.Repositories.Interfaces;

public interface IRepositoryManager
{
    ICategoryRepository Category { get; }

    Task SaveAsync();
}
