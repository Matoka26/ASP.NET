using backend.Models.DTOs;
using backend.Models;

namespace backend.Services.AutorService
{
    public interface IAutorService
    {
        Task<List<Autor>> GetAll();
        Task CreateAutor(AutorDTO autor);
    }
}
