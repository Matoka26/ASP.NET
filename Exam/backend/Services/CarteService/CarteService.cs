using backend.Models.DTOs;
using backend.Models;
using backend.Repositories.CarteRepository;
using AutoMapper;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using backend.Repositories.AutorRepository;
using Microsoft.EntityFrameworkCore;
using backend.Repositories.CarteAutorRepository;

namespace backend.Services.CarteService
{
    public class CarteService: ICarteService
    {
        private readonly ICarteRepository _carteRepository;
        //private readonly IAutorRepository _autorRepository;
        //private readonly ICarteAutorRepository _carteAutorRepository;
        private readonly IMapper _mapper;

        public CarteService(ICarteRepository carteRepository, IMapper mapper)
                            //IAutorRepository autorRepository)
                            //ICarteAutorRepository carteAutorRepository)
        {
            _carteRepository = carteRepository;
            _mapper = mapper;
            //_autorRepository = autorRepository;
            //_carteAutorRepository = carteAutorRepository;
        }

        public async Task CreateCarte(CarteDTO carte)
        {
            await _carteRepository.CreateAsync(_mapper.Map<Carte>(carte));
            await _carteRepository.SaveAsync();
        }

        public async Task<List<Carte>> GetAll()
        {
            return await _carteRepository.GetAllAsync();
        }
    }
}
