using backend.Models.DTOs;
using backend.Models;
using backend.Repositories.AutorRepository;
using AutoMapper;

namespace backend.Services.AutorService
{
    public class AutorService: IAutorService
    {
        private readonly IAutorRepository _autorRepository;
        private readonly IMapper _mapper;


        public AutorService(IAutorRepository autorRepository,IMapper mapper)
        {
            _autorRepository = autorRepository;
            _mapper = mapper;
        }

        public async Task CreateAutor(AutorDTO autor)
        {
            await _autorRepository.CreateAsync(_mapper.Map<Autor>(autor));
            await _autorRepository.SaveAsync();
        }

        public async Task<List<Autor>> GetAll()
        {
            return await _autorRepository.GetAllAsync();
        }
    }
}
