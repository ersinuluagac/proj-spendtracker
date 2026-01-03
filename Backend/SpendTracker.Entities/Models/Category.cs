namespace SpendTracker.Entities.Models;

public class Category : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public ICollection<Expense>? Expenses { get; set; }
}
