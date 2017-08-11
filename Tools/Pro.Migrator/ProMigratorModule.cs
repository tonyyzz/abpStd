using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Pro.EntityFramework;

namespace Pro.Migrator
{
    [DependsOn(typeof(ProDataModule))]
    public class ProMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ProDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}