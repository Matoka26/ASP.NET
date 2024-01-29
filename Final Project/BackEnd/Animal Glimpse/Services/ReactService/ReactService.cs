using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.ReactDTO;
using Animal_Glimpse.Repositories.ReactRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.ReactService
{
    public class ReactService : IReactService
    {
        public IReactRepository _reactRepository;
        public IMapper _mapper;

        public ReactService(IReactRepository reactRepository, IMapper mapper)
        {
            _reactRepository = reactRepository;
            _mapper = mapper;
        }

        public async Task CreateReact(ReactCreateDTO react)
        {
            if(react.Color < 0 ||  react.Color > 0xffffff)
            {
                throw new Exception("Invalid color");
            }

            await _reactRepository.CreateAsync(_mapper.Map<React>(react));
            await _reactRepository.SaveAsync();
        }

        public async Task DeleteReact(Guid id)
        {
            var existingReact = _reactRepository.FindById(id);
            if(existingReact == null)
            {
                throw new Exception("Invalid React");
            }

            _reactRepository.Delete(existingReact);
            await _reactRepository.SaveAsync();

        }

        public async Task<List<ReactGetDTO>> GetAllReacts()
        {
            var reacts = await _reactRepository.GetAllAsync();
            return _mapper.Map<List<ReactGetDTO>>(reacts);
        }

        public async Task UpdateReact(ReactUpdateDTO react)
        {
            var existingReact = _reactRepository.FindById(react.Id);
            if (existingReact == null)
            {
                throw new Exception("Invalid React");
            }

            existingReact.LastModifiedTime = DateTime.Now;
            if (react.Name != "" && react.Name != null) existingReact.Name = react.Name;
            if(react.Logo != "" && react.Logo != null) existingReact.Logo = react.Logo;
            if(react.Color != null && react.Color == 0) existingReact.Color = react.Color;

            _reactRepository.Update(existingReact);
            await _reactRepository.SaveAsync();
        }
    }
}
