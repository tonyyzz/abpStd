﻿using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Hangfire;
using Abp.Hangfire.Configuration;
using Abp.Zero.Configuration;
using Abp.Modules;
using Abp.Web.Mvc;
using Abp.Web.SignalR;
using Pro.Api;
using Castle.MicroKernel.Registration;
using Hangfire;
using Microsoft.Owin.Security;
using Abp.Configuration.Startup;
using System.Diagnostics;
using Abp.Localization;
using System;
using Abp.Runtime.Caching.Redis;
using Abp.Timing;

namespace Pro.Web
{
	[DependsOn(
		typeof(ProDataModule),
		typeof(ProApplicationModule),
		typeof(ProWebApiModule),
		typeof(AbpWebSignalRModule),
		typeof(AbpRedisCacheModule),
		//typeof(AbpHangfireModule), - ENABLE TO USE HANGFIRE INSTEAD OF DEFAULT JOB MANAGER
		typeof(AbpWebMvcModule))]
	public class ProWebModule : AbpModule
	{
		public override void PreInitialize()
		{
			Debug.WriteLine("------------ ProWebModule PreInitialize");

			//Enable database based localization
			Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

			//Configure navigation/menu
			Configuration.Navigation.Providers.Add<ProNavigationProvider>();

			//Configure Hangfire - ENABLE TO USE HANGFIRE INSTEAD OF DEFAULT JOB MANAGER
			//Configuration.BackgroundJobs.UseHangfire(configuration =>
			//{
			//    configuration.GlobalConfiguration.UseSqlServerStorage("Default");
			//});

			Configuration.Modules.AbpWeb().AntiForgery.IsEnabled = false;




			//Configuration for all caches
			Configuration.Caching.ConfigureAll(cache =>
			{
				cache.DefaultSlidingExpireTime = TimeSpan.FromHours(2);
			});

			//Configuration for a specific cache
			Configuration.Caching.Configure("MyCache", cache =>
			{
				cache.DefaultSlidingExpireTime = TimeSpan.FromHours(8);
			});

			//cache  redis  要安装redis服务
			//Configuration.Caching.UseRedis();



			

		}

		public override void Initialize()
		{
			Debug.WriteLine("------------ ProWebModule Initialize");
			IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

			IocManager.IocContainer.Register(
				Component
					.For<IAuthenticationManager>()
					.UsingFactoryMethod(() => HttpContext.Current.GetOwinContext().Authentication)
					.LifestyleTransient()
			);

			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}

		public override void PostInitialize()
		{
			Debug.WriteLine("------------ ProWebModule PostInitialize");
		}

		public override void Shutdown()
		{
			Debug.WriteLine("------------ ProWebModule Shutdown");
		}
	}
}
