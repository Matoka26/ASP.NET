using Animal_Glimpse.Models.DTOs.ReactDTO;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Glimpse.Services.ReactService
{
    public interface IReactService
    {
        Task<List<ReactGetDTO>> GetAllReacts();
        Task CreateReact(ReactCreateDTO react);
        Task DeleteReact(Guid id);
        Task UpdateReact(ReactUpdateDTO react);
    }
}
