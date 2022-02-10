namespace PizzaApplication.Services
{
    public interface IRepo<K, T> 
    {
        bool Add(T t);
        bool Update(K k, T t);
        bool Delete(K k);
        ICollection<T> GetAll();
        T GetT(K k);
    }
}
