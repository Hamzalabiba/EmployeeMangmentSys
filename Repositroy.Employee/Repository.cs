using Domain.Employee;
using Domain.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DtoModel;

namespace Repositroy
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        readonly EmpMangementSysContext _context;
        readonly DbSet<T> _entities;

        public Repository(EmpMangementSysContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }


        public void Delete(T entity)
        {
            try
            {
                if (entity is not null)
                {
                    _entities.Remove(entity);
                }
            }
            catch
            {

            }
        }

        public IEnumerable<T> GetAll()
        {
            if (_entities is not null)
            {
                return _entities;
            }
            return Enumerable.Empty<T>();
        }

        public T GetById(Guid Id)
        {
            var entity = _entities.FirstOrDefault(x => x.Id == Id);
            if (entity is not null)
                return entity;
            return entity;
        }

        public void Insert(T entity)
        {
            if (!_entities.Contains(entity))
            { 
                _entities.Add(entity);
                
            }
        }


        public void Update(T entity)
        {
            if (entity is not null)
            {
                _entities.Entry(entity).State = EntityState.Modified;
            }
        }
    }
}
