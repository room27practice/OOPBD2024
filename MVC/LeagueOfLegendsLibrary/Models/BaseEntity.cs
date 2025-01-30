
public abstract class DeletableEntity
{
    protected DeletableEntity()
    {
        DeletedOn = null;
    }
    public bool IsDeleted { get; private set; }
    public DateTime? DeletedOn { get; private set; }
    public void Delete()
    {
        IsDeleted = true;
        DeletedOn = DateTime.UtcNow;
    }

}
public class BaseEntity<T> : DeletableEntity
{
    public T Id { get; set; }
    public DateTime CreatedOn { get; set; }

    public BaseEntity()
    {
        CreatedOn = DateTime.UtcNow;

    }
}
