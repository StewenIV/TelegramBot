namespace Application.Interfaces;

public interface IRepository<TEntity>
{
    public List<TEntity> Get();
    public TEntity GetByid(Guid id);
    public TEntity Add(TEntity person);
    public TEntity Update(TEntity person);
    public void Delete(TEntity person);
}