using Abp.Web.Mvc.Views;

namespace Pro.Web.Views
{
    public abstract class ProWebViewPageBase : ProWebViewPageBase<dynamic>
    {

    }

    public abstract class ProWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ProWebViewPageBase()
        {
            LocalizationSourceName = ProConsts.LocalizationSourceName;
        }
    }
}