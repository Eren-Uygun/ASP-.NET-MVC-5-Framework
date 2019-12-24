using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YMS5570_Repository_Pattern.DAL.ORM.Context;
using YMS5570_Repository_Pattern.DAL.ORM.Entity.Abstract;
using YMS5570_Repository_Pattern.DAL.ORM.Entity.Concrete;

namespace YMS5570_Repository_Pattern.BLL.Repository
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private ProjectContext db;
        protected DbSet<T> table;

        public BaseRepository()
        {
            db = new ProjectContext();
            table = db.Set<T>();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public void Add(T item)
        {
            table.Add(item);
            Save();
        }

        public void Add(List<T> items)
        {
            table.AddRange(items);
            Save();
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public List<T> GetActive()
        {
            return table.Where(x => x.Status == Status.Active).ToList();
        }

        public T GetById(Guid id)
        {
            return table.Find(id);
        }

        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
            return table.Where(exp).FirstOrDefault();
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return table.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            T item = GetById(id);
            item.Status = Status.Passive;
            Update(item);
        }

        public void RemoveAll(Expression<Func<T, bool>> exp)
        {
            foreach (var item in GetDefault(exp))
            {
                item.Status = Status.Passive;
                Update(item);
            }
        }

        public void Update(T item)
        {
            T updated = GetById(item.ID);
            DbEntityEntry entry = db.Entry(updated);
            entry.CurrentValues.SetValues(item);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp) => table.Any(exp);
    }
}
