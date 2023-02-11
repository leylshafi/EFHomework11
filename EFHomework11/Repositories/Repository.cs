using EFHomework11.Contexts;
using EFHomework11.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework11.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly LibraryDbContext _libraryDbContext;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(LibraryDbContext libraryDbContext)
    {
        ArgumentNullException.ThrowIfNull(libraryDbContext, nameof(libraryDbContext));

        _dbSet = libraryDbContext.Set<TEntity>();
        _libraryDbContext = libraryDbContext;
    }

    public void Add(TEntity entity)
    {
        _dbSet.Add(entity);
    }

    public TEntity? GetById(int Id)
    {
        return _dbSet.Find(Id);
    }

    public IEnumerable<TEntity>? GetList(Func<TEntity, bool>? predicate = null)
    {
        return predicate is null ? _dbSet.ToList() : _dbSet.Where(predicate).ToList();
    }

    public void Remove(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
    }
}