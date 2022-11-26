using AutoMapper;
using UB.Data.Domain;
using UB.Data.Repositories.Interfaces;
using UB.Data.UnitOfWork;
using UB.Services.Dtos;
using UB.Services.Services.Interfaces;
using UB.Services.ViewModels;

namespace UB.Services.Services
{
    internal class WelcomeFormService : IWelcomeFormService
    {
        private readonly IUserRepository _userRepository;
        private readonly IGradeRepository _gradeRepository;
        private readonly ISpecializationRepository _specializationRepository;
        private readonly IWelcomeFormRepository _welcomeFormRepository;
        private readonly IMapper _mapper;
        private readonly IUoW _UoW;

        public WelcomeFormService(
            IUserRepository userRepository,
            IGradeRepository gradeRepository,
            ISpecializationRepository specializationRepository,
            IWelcomeFormRepository welcomeFormRepository,
            IMapper mapper,
            IUoW UoW)
        {
            _userRepository = userRepository;
            _gradeRepository = gradeRepository;
            _specializationRepository = specializationRepository;
            _welcomeFormRepository = welcomeFormRepository;
            _mapper = mapper;
            _UoW = UoW;
        }

        public async Task<RespModel<WelcomeFormDto>> ProcessAsync(WelcomeFormVM welcomeFormVM)
        {
            var user = await _userRepository.GetByUserNameAsync(welcomeFormVM.UserName);
            if (user is null)
            {
                user = new()
                {
                    UserName = welcomeFormVM.UserName,
                };
                await _userRepository.InsertAsync(user);
            }

            var specialization = await _specializationRepository.GetByIdAsync(welcomeFormVM.SpecializationId);
            if (specialization is null)
            {
                return new RespModel<WelcomeFormDto>($"Specialization with id: {welcomeFormVM.SpecializationId} not found");
            }

            var grade = await _gradeRepository.GetByIdAsync(welcomeFormVM.GradeId);
            if (grade is null)
            {
                return new RespModel<WelcomeFormDto>($"Grade with id {welcomeFormVM.GradeId} is not found");
            }

            var welcomeForm = new WelcomeForm
            {
                User = user,
                Grade = grade,
                Specialization = specialization,
                IsDocWriter = welcomeFormVM.IsDocWriter,
                IsPM = welcomeFormVM.IsPM,
                Comment = welcomeFormVM.Comment,
            };
            await _welcomeFormRepository.InsertAsync(welcomeForm);

            await _UoW.SaveAsync();

            var formDto = _mapper.Map<WelcomeFormDto>(welcomeForm);

            return new RespModel<WelcomeFormDto>(formDto);
        }
    }
}
