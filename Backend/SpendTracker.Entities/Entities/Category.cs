namespace SpendTracker.Entities.Entities;

public class Category : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public ICollection<Expense>? Expenses { get; set; }
}
