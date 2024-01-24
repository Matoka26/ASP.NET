using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;

namespace backend.Repositories.TestRepository;

public class TestRepository : GenericRepository<Test>, ITestRepository
{
    public TestRepository(DatabaseContext dbContext) : base(dbContext) {}
}