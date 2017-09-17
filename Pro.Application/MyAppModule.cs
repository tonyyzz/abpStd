using Abp.AutoMapper;
using Abp.Modules;
using Pro.Authorization.Users;
using Pro.Persons.Dto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
	[DependsOn(typeof(AbpAutoMapperModule))]
	public class MyAppModule : AbpModule
	{
		public override void PreInitialize()
		{
			Debug.WriteLine("------------ MyAppModule PreInitialize");

			Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
			{
				config.CreateMap<PersonDto, User>()
					  .ForMember(u => u.Password, options => options.Ignore())
					  .ForMember(u => u.EmailAddress, options => options.MapFrom(input => input.Email));
			});
		}
	}
}
