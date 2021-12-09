using Abp.Web.Mvc.Views;

namespace TreinamentoJazzRaphael.Web.Views
{
    public abstract class TreinamentoJazzRaphaelWebViewPageBase : TreinamentoJazzRaphaelWebViewPageBase<dynamic>
    {

    }

    public abstract class TreinamentoJazzRaphaelWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TreinamentoJazzRaphaelWebViewPageBase()
        {
            LocalizationSourceName = TreinamentoJazzRaphaelConsts.LocalizationSourceName;
        }
    }
}