using AutoMapper;
using UB.Data.Repositories.Interfaces;
using UB.Services.Dtos;
using UB.Services.Interfaces;

namespace UB.Services.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userService;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<RespModel<IList<UserDto>>> GetAllAsync()
        {
            var users = await _userService.GetAllAsync();
            var usersDto = _mapper.Map<IList<UserDto>>(users);
            return new RespModel<IList<UserDto>>(usersDto);
        }
    }
}