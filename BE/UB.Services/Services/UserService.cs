using AutoMapper;
using UB.Data.Repositories.Interfaces;
using UB.Services.Dtos;
using UB.Services.Interfaces;

namespace UB.Services.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userService, IMapper mapper)
        {
            _userRepository = userService;
            _mapper = mapper;
        }

        public async Task<RespModel<IList<UserDto>>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            var usersDto = _mapper.Map<IList<UserDto>>(users);
            return new RespModel<IList<UserDto>>(usersDto);
        }

        public async Task<RespModel<UserDto>> GetByIdAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(user);
            return new RespModel<UserDto>(userDto);
        }
    }
}