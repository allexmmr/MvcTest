using System.Data.Entity.Infrastructure;

namespace MvcTest.Data
{
    public class MvcTestContextFactory : IDbContextFactory<MvcTestContext>
    {
        public MvcTestContext Create()
        {
            return new MvcTestContext("Server=(localdb)\\mssqllocaldb;Database=MvcTest;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}