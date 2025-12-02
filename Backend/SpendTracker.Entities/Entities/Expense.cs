namespace SpendTracker.Entities.Entities;

public class Expense : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime ExpenseDate { get; set; }
    public int CategoryId { get; set; }

    public Category? Category { get; set; }

}
