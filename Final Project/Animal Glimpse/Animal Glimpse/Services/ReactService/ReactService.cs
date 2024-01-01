using Animal_Glimpse.Repositories.ReactRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.ReactService
{
    public class ReactService: IReactService
    {
        public IReactRepository _reactRepository;
        public IMapper _mapper;

        public ReactService(IReactRepository reactRepository, IMapper mapper)
        {
            _reactRepository = reactRepository;
            _mapper = mapper;
        }
    }
}
