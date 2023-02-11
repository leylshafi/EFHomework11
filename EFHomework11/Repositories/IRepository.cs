using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework11.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    IEnumerable<TEntity>? GetList(Func<TEntity, bool>? predicate = null);
    TEntity? GetById(int Id);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Remove(TEntity entity);
}
