namespace Domen.Entity;

public class CustomField<TValue>: BaseEntity
{
    public string Name { get; set; }
    public TValue Value { get; set; }
}