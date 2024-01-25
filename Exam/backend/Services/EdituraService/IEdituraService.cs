using backend.Models;
using backend.Models.DTOs;

namespace backend.Services.EdituraService
{
    public interface IEdituraService
    {
        Task<List<Editura>> GetAll();
        Task CreateEditura(EdituraDTO editura);
    }
}
