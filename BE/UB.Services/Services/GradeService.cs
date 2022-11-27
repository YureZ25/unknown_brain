using AutoMapper;
using UB.Data.Repositories.Interfaces;
using UB.Services.Dtos;
using UB.Services.Services.Interfaces;

namespace UB.Services.Services
{
    internal class GradeService : IGradeService
    {
        private readonly IGradeRepository _gradeService;
        private readonly IMapper _mapper;

        public GradeService(IGradeRepository gradeService, IMapper mapper)
        {
            _gradeService = gradeService;
            _mapper = mapper;
        }

        public async Task<RespModel<IList<GradeDto>>> GetAllAsync()
        {
            var grades = await _gradeService.GetAllAsync();
            var gradesDto = _mapper.Map<IList<GradeDto>>(grades);
            return new RespModel<IList<GradeDto>>(gradesDto);
        }
    }
}