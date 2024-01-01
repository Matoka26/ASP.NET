using Animal_Glimpse.Repositories.InstanceRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.IInstanceService
{
    public class InstanceService: IInstanceService
    {
        public IInstanceRepository _instanceRepository;
        public IMapper _mapper;

        public InstanceService(IInstanceRepository instanceRepository, IMapper mapper)
        {
            _instanceRepository = instanceRepository;
            _mapper = mapper;
        }
    }
}
