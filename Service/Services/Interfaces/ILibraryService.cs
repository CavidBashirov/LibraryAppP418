using Domain.Models;

namespace Service.Services.Interfaces
{
    public interface ILibraryService
    {
        void Create(Library library);
        void Delete(Library library);
        Library GetById(int id);
        List<Library> GetAll();
        List<Library> GetAllByName(string name);
    }
}
