using RequestProblem.Models;

namespace RequestProblem.Repositories
{
    public class ProblemsRepository : IProblemsRepository
    {
        private readonly ProblemMgmtContext _problemMgmtContext;

        public ProblemsRepository(ProblemMgmtContext problemMgmtContext)
        {
            _problemMgmtContext = problemMgmtContext;
        }

        public IEnumerable<Problems> GetAllProblems()
        {
            return _problemMgmtContext.Problems.ToList();
        }

        public Problems GetByIdProblems(int id)
        {
            return _problemMgmtContext.Problems.Find(id);
        }

        public void AddProblems(Problems problems)
        {
            _problemMgmtContext.Problems.Add(problems);
            _problemMgmtContext.SaveChanges();
        }

        public void UpdateProblems(Problems problems)
        {
            _problemMgmtContext.Entry(problems).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _problemMgmtContext.SaveChanges();
        }

        public void DeleteProblems(int id)
        {
            var problem = _problemMgmtContext.Problems.Find(id);
            _problemMgmtContext.Problems.Remove(problem);
            _problemMgmtContext.SaveChanges();
        }

        

        
    }
}
