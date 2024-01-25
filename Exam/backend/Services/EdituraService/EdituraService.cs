using AutoMapper;
using backend.Models;
using backend.Models.DTOs;
using backend.Repositories.EdituraRepository;

namespace backend.Services.EdituraService
{
    public class EdituraService: IEdituraService
    {
        private readonly IEdituraRepository _edituraRepository;
        private readonly IMapper _mapper;

        public EdituraService(IEdituraRepository edituraRepository,IMapper mapper)
        {
            _edituraRepository = edituraRepository;
            _mapper = mapper;
        }

        public async Task CreateEditura(EdituraDTO editura)
        {
            await _edituraRepository.CreateAsync(_mapper.Map<Editura>(editura));
            _edituraRepository.SaveAsync();
        }

        public async Task<List<Editura>> GetAll()
        {
            return await _edituraRepository.GetAllAsync();
        }
    }
}
