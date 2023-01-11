using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ServicesLayer.Interface
{
    public interface ILibraryService
    {
        Library Create(Library library);
        Library Delete(int id);
        Library GetById(int id);
        List<Library> Search(string searchText);
        List<Library> GetAll();

    }
}
