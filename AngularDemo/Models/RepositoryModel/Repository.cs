using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo.Models.Repositories
{
    public class Repository<T> where T : class
    {
        MusicStoreDataContext musicDbContext = null;
        protected DbSet<T> DbSet { get; set; }

        public Repository()
        {
            musicDbContext = new MusicStoreDataContext();
            DbSet = musicDbContext.Set<T>();
        }

        public Repository(MusicStoreDataContext context)
        {
            musicDbContext = context;
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Update(T entity)
        {
            musicDbContext.Entry<T>(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public void SaveChanges()
        {
            musicDbContext.SaveChanges();
        }

    }
}