using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace HUIT_ASPMVC.Repositories
{
    public class GenericRepo<T> where T : class, new()
    {

        public GenericRepo() { }
        public GenericRepo(DbContext context)
        {
            this._entities = context;
        }

        private DbContext _entities;

        public DbContext Context
        {
            get { return _entities; }
            set { _entities = value; }
        }

        public virtual T Add(T entity)
        {
            _entities.Set<T>().Add(entity);
            return entity;
        }


        //public virtual T GetBy(Expression<Func<T, bool>> predicate)
        //{
        //    return _entities.Set<T>().Where(predicate).FirstOrDefault();
        //}

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Attach(entity);
            _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _entities.Set<T>().Where(predicate);
        }

        public virtual IQueryable<T> GetAll()
        {
            return _entities.Set<T>();
        }

        public virtual T Find(params object[] keyValues)
        {
            return _entities.Set<T>().Find(keyValues);
        }

        //public virtual PagingModel<T> GetPaged(IQueryable<T> query, int pageNumber, int pageSize)
        //{
        //    var result = new PagingModel<T>();
        //    result.CurrentPage = pageNumber;
        //    result.PageSize = pageSize;
        //    result.RowCount = query.Count();

        //    var pageCount = (double)result.RowCount / pageSize;
        //    result.PageCount = (int)Math.Ceiling(pageCount);

        //    var skip = (pageNumber - 1) * pageSize;
        //    result.Results = query.Skip(skip).Take(pageSize).ToList();

        //    return result;
        //}

        public virtual T Save(T entity)
        {
            _entities.SaveChanges();
            return entity;
        }

        public virtual T Insert(T entity)
        {
            Add(entity);
            return Save(entity);
        }

        public virtual T Update(T entity)
        {
            Edit(entity);
            return Save(entity);
        }
    }
}