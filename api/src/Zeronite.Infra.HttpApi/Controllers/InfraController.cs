using Zeronite.Infra.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Zeronite.Infra.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class InfraController : AbpController
    {
        protected InfraController()
        {
            LocalizationResource = typeof(InfraResource);
        }
    }
}