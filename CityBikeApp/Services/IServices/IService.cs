using System.Linq.Expressions;

namespace CityBikeApp.Services.IServices
{
    public interface IService<T> where T : class
    {
        T Get(short id);
        List<T> GetAll();
        void Create(T entity);
    }
}
