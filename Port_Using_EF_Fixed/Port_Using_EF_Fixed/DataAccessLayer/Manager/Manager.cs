using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccessLayer.DataContextConfiguration;
using DataAccessLayer.Repository;
using DataAccessLayer.Validation;
using FluentValidation;

namespace DataAccessLayer.Manager
{
    public class Manager<T> : IManager<T> where T :BaseEntity
    {
        private IDictionary<string, object> _dictionaryValidators;
        private IDictionary<string, IRepository<T>> _dictionaryRepositories;
        private DataContext _context;

        private Manager()
        {

        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public DbSet<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryable<int> ListId()
        {
            throw new NotImplementedException();
        }
    }
}
