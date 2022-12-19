using COMP584.API.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace COMP584.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
