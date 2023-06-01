using CityBikeApp.Data;
using CityBikeApp.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using CityBikeApp.Services.IServices;

namespace CityBikeApp.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        private readonly DbSet<T> dbSet;

        public Service(ApplicationDbContext db)
        {
            _db = db;
            dbSet = db.Set<T>();
        }

        public void Create(T entity)
        {
            dbSet.Add(entity);
            
        }

        public T Get(short id)
        {
            return dbSet.Find(id);
        }

        public List<T> GetAll()
        {
                     
            return dbSet.ToList();
        }
    }
}
