using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using TreinamentoJazzRaphael.EntityFramework;

namespace TreinamentoJazzRaphael
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(TreinamentoJazzRaphaelCoreModule))]
    public class TreinamentoJazzRaphaelDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TreinamentoJazzRaphaelDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
