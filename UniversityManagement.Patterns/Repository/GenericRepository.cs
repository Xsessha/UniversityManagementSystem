namespace UniversityManagement.Patterns.Repository;

public class GenericRepository<T>
    : IRepository<T>
    where T : class
{
    private readonly List<T> _data = new();

    public IEnumerable<T> GetAll()
    {
        return _data;
    }

    public T? GetById(int id)
    {
        return _data.FirstOrDefault();
    }

    public void Add(T entity)
    {
        _data.Add(entity);
    }

    public void Update(T entity)
    {
    }

    public void Delete(int id)
    {
        var entity =
            _data.FirstOrDefault();

        if (entity != null)
        {
            _data.Remove(entity);
        }
    }
}