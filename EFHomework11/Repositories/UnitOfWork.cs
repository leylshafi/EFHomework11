using EFHomework11.Contexts;
using EFHomework11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework11.Repositories;

public class UnitOfWork : IDisposable
{
    private readonly LibraryDbContext context;
    private Repository<Author> authorRepository;
    private Repository<Book> bookRepository;
    private Repository<Category> categoryRepository;
    private Repository<Department> departmentRepository;
    private Repository<Faculty> facultyRepository;
    private Repository<Group> groupRepository;
    private Repository<Lib> libRepository;
    private Repository<Press> pressRepository;
    private Repository<S_Card> s_CardRepository;
    private Repository<Student> studentRepository;
    private Repository<T_Card> t_CardRepository;
    private Repository<Teacher> teacherRepository;
    private Repository<Theme> themeRepository;

    public Repository<Theme> ThemeRepository
    {
        get
        {
            if (themeRepository == null)
                themeRepository = new Repository<Theme>(context);

            return themeRepository;
        }
    }


    public Repository<Teacher> TeacherRepository
    {
        get
        {
            if (teacherRepository == null)
                teacherRepository = new Repository<Teacher>(context);

            return teacherRepository;
        }
    }


    public Repository<T_Card> T_CardRepository
    {
        get
        {
            if (t_CardRepository == null)
                t_CardRepository = new Repository<T_Card>(context);

            return t_CardRepository;
        }
    }


    public Repository<Student> StudentRepository
    {
        get
        {
            if (studentRepository == null)
                studentRepository = new Repository<Student>(context);

            return studentRepository;
        }
    }


    public Repository<S_Card> S_CardRepository
    {
        get
        {
            if (s_CardRepository == null)
                s_CardRepository = new Repository<S_Card>(context);

            return s_CardRepository;
        }
    }


    public Repository<Press> PressRepository
    {
        get
        {
            if (pressRepository == null)
                pressRepository = new Repository<Press>(context);

            return pressRepository;
        }
    }


    public Repository<Lib> LibRepository
    {
        get
        {
            if (libRepository == null)
                libRepository = new Repository<Lib>(context);

            return libRepository;
        }
    }


    public Repository<Group> GroupRepository
    {
        get
        {
            if (groupRepository == null)
                groupRepository = new Repository<Group>(context);

            return groupRepository;
        }
    }


    public Repository<Faculty> RacultyRepository
    {
        get
        {
            if (facultyRepository == null)
                facultyRepository = new Repository<Faculty>(context);

            return facultyRepository;
        }
    }


    public Repository<Department> DepartmentRepository
    {
        get
        {
            if (departmentRepository == null)
                departmentRepository = new Repository<Department>(context);

            return departmentRepository;
        }
    }

    public Repository<Category> CategoryRepository
    {
        get
        {
            if (categoryRepository == null)
                categoryRepository = new Repository<Category>(context);

            return categoryRepository;
        }
    }

    public Repository<Book> BookRepository
    {
        get
        {
            if (bookRepository == null)
                bookRepository = new Repository<Book>(context);

            return bookRepository;
        }
    }

    public Repository<Author> AuthorRepository
    {
        get
        {
            if (authorRepository == null)
                authorRepository = new Repository<Author>(context);

            return authorRepository;
        }
    }


    public UnitOfWork() => context = new();

    public void Save() => context.SaveChanges();
    public async void SaveAsync() => await context.SaveChangesAsync();
    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        this.disposed = true;
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
