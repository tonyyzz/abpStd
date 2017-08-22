using System.Reflection;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Modules;
using Pro.Authorization.Roles;
using Pro.Authorization.Users;
using Pro.Roles.Dto;
using Pro.Users.Dto;
using System.Diagnostics;
using Pro.Persons;
using Abp.Dependency;

namespace Pro
{
    [DependsOn(typeof(ProCoreModule), typeof(AbpAutoMapperModule))]
    public class ProApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Debug.WriteLine("------------ ProApplicationModule PreInitialize");
        }

        public override void Initialize()
        {
            Debug.WriteLine("------------ ProApplicationModule Initialize");
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //Using IocManager
            IocManager.Register<IPersonManager, MyPersonManager>(DependencyLifeStyle.Transient);

            // TODO: Is there somewhere else to store these, with the dto classes
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Role and permission
                cfg.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
                cfg.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

                cfg.CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                cfg.CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

                cfg.CreateMap<CreateUserDto, User>();
                cfg.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
            });
        }

        public override void PostInitialize()
        {
            Debug.WriteLine("------------ ProApplicationModule PostInitialize");
        }

        public override void Shutdown()
        {
            Debug.WriteLine("------------ ProApplicationModule Shutdown");
        }
    }
}
