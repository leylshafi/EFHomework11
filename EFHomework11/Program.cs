using EFHomework11.Models;
using EFHomework11.Repositories;

namespace EFHomework11;

public class Program
{
    static void Main()
    {
        UnitOfWork uf = new UnitOfWork();

        var student = new Student()
        {
            Id=33,
            FirstName = "Leyla",
            LastName = "Shafiyeva",
            Id_Group = 2,
            Term=2
        };

        uf.StudentRepository.Add(student);



        var author = uf.AuthorRepository.GetById(1);

        if (author is not null)
            uf.AuthorRepository.Remove(author);

        uf.Save();

        Console.WriteLine(uf.StudentRepository.GetById(33)?.FirstName+" "+ (uf.StudentRepository.GetById(33)?.LastName));
        
        Console.WriteLine((uf.AuthorRepository.GetById(2) is null)?"Removed": uf.AuthorRepository.GetById(2).FirstName);
    }
}
