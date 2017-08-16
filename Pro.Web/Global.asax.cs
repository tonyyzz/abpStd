using System;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Castle.Facilities.Logging;
using System.Web;
using Abp.PlugIns;

//[assembly: PreApplicationStartMethod(typeof(PreStarter), "Start")]
namespace Pro.Web
{
    public class MvcApplication : AbpWebApplication<ProWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig("log4net.config")
            );
            //MvcApplication.AbpBootstrapper.PlugInSources.AddFolder(@"C:\MyPlugIns\");
            //MvcApplication.AbpBootstrapper.PlugInSources.AddToBuildManager();

            base.Application_Start(sender, e);
        }
    }
}
