namespace MvcDemo.Common.Entities
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
