using Animal_Glimpse.Repositories.RoleRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.RoleService
{
    public class RoleService: IRoleService
    {
        public IRoleRepository _roleRepository;
        public IMapper _mapper;

        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
    }
}
