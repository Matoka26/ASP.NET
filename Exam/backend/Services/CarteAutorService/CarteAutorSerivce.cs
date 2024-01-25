using AutoMapper;
using backend.Models;
using backend.Models.DTOs;
using backend.Repositories.CarteAutorRepository;

namespace backend.Services.CarteAutorService
{
    public class CarteAutorSerivce: ICarteAutorService
    {
        private readonly ICarteAutorRepository _carteAutorRepository;
        private readonly IMapper _mapper;

        public CarteAutorSerivce(IMapper mapper,ICarteAutorRepository carteAutorService)
        {
            _mapper = mapper;
            _carteAutorRepository = carteAutorService;
        }

        public async Task AssignAuthor(RelatieDTO rel)
        {
            await _carteAutorRepository.CreateAsync(_mapper.Map<AutorCarteRelatie>(rel));
            await _carteAutorRepository.SaveAsync();
        }
    }
}
