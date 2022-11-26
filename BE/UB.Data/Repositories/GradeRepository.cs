using UB.Data.Domain;
using UB.Data.Repositories.Interfaces;

namespace UB.Data.Repositories
{
    internal class GradeRepository : BaseRepository<Grade>, IGradeRepository
    {
        public GradeRepository(AppDbContext context) : base(context)
        {
        }


    }
}
