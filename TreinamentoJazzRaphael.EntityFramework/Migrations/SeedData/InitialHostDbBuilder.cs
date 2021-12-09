using TreinamentoJazzRaphael.EntityFramework;
using EntityFramework.DynamicFilters;

namespace TreinamentoJazzRaphael.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TreinamentoJazzRaphaelDbContext _context;

        public InitialHostDbBuilder(TreinamentoJazzRaphaelDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
