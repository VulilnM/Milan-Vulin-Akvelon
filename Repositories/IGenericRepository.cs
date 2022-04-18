using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Akvelon_Internship_Test_Task.Repositories
{
        // Repository Pattern Implementation 
        // This is our generic repository for data access layer,
        // it will be inherited and implemented by our repository class
        public interface IGenericRepository<T> where T : class
        {
            T GetById(int id);
            IEnumerable<T> GetAll();
            IEnumerable<T> Find(Expression<Func<T, bool>> expression);
            void Add(T entity);
            void AddRange(IEnumerable<T> entities);
            void Remove(int id);
            void RemoveRange(IEnumerable<T> entities);
            void Update(T entity);
        }
}
