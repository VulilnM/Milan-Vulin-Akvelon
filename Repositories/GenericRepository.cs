using Akvelon_Internship_Test_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Akvelon_Internship_Test_Task.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        // Get the context of our App/DB
        protected readonly AppDbContext _context;

        // Create a public constructor
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        // Implementation of all of the interface methods (CRUD Operations)
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        // Returns a list of specified type for all the entities int he DB that match the parameter (predicate) expression
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public void Remove(int id)
        {
            var objToRemove = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(objToRemove);
            _context.SaveChanges();
            
        }

        // Removing a range of objects from the database based on passed arrays of ids of objects to remove
        public void RemoveRange(IEnumerable<int> ids)
        {

            foreach (var id in ids) {
                var objToRemove = _context.Set<T>().Find(id);
                if (objToRemove != null)
                {
                    _context.Set<T>().Remove(objToRemove);
                }
            }
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        // Finds all the task which have the same ProjectFK as the passed project's ID
        IEnumerable<Task> IGenericRepository<T>.FindTasksForProject(Project project)
        {
            IEnumerable<Task> tasks = _context.Task.Where(t => t.ProjectFK == project.ProjectId).Distinct().ToList();
            
            return tasks;
        }

        // Finds a project to which a specific task is related to by comparing the tasks projectFK and projects ID
        Project IGenericRepository<T>.FindProjectForTask(Task task)
        {
            Project _project = _context.Project.Single(p => p.ProjectId == task.ProjectFK);

            return _project; 
        }
    }
}
