using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class LibraryRepository : BaseRepository<Library>, ILibraryRepository
    {
        public int GetCount()
        {
            return AppDbContext<Library>.Datas.Count();
        }

        public List<Library> GetLibrariesByName(string name)
        {
            return AppDbContext<Library>.Datas.Where(m => m.Name == name).ToList();
        }
    }
}
