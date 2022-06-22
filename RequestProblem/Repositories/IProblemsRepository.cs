using RequestProblem.Models;

namespace RequestProblem.Repositories
{
    public interface IProblemsRepository
    {
        IEnumerable<Problems> GetAllProblems();

        Problems GetByIdProblems(int id);
        void AddProblems(Problems problems);
        void UpdateProblems(Problems problems);
        void DeleteProblems(int id);
    }
}
