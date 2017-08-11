using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Pro.Authorization.Roles;
using Pro.Authorization.Users;
using Pro.MultiTenancy;

namespace Pro.EntityFramework
{
    public class ProDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ProDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ProDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ProDbContext since ABP automatically handles it.
         */
        public ProDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ProDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ProDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("Pro");
            
            //修改表前缀：
            //nuget包管理器控制台  add-migration  添加迁移  然后在更新  update-database
        }
    }
}
