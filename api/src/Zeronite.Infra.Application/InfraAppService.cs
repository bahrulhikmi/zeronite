using System;
using System.Collections.Generic;
using System.Text;
using Zeronite.Infra.Localization;
using Volo.Abp.Application.Services;

namespace Zeronite.Infra
{
    /* Inherit your application services from this class.
     */
    public abstract class InfraAppService : ApplicationService
    {
        protected InfraAppService()
        {
            LocalizationResource = typeof(InfraResource);
        }
    }
}
