using backend.Models.DTOs;
using backend.Models;

namespace backend.Services.CarteService
{
    public interface ICarteService
    {
        Task<List<Carte>> GetAll();
        Task CreateCarte(CarteDTO carte);
        

    }
}
