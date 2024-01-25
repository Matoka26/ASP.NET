using backend.Models.DTOs;

namespace backend.Services.CarteAutorService
{
    public interface ICarteAutorService
    {
        Task AssignAuthor(RelatieDTO rel);
    }
}
