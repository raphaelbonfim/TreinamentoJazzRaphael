using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TreinamentoJazzRaphael.EntityFramework;

namespace TreinamentoJazzRaphael.Migrator
{
    [DependsOn(typeof(TreinamentoJazzRaphaelDataModule))]
    public class TreinamentoJazzRaphaelMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TreinamentoJazzRaphaelDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}