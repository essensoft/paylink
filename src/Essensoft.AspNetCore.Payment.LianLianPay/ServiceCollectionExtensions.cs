using System;
using Essensoft.AspNetCore.Payment.LianLianPay;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddLianLianPay(
            this IServiceCollection services)
        {
            services.AddLianLianPay(setupAction: null);
        }

        public static void AddLianLianPay(
            this IServiceCollection services,
            Action<LianLianPayOptions> setupAction)
        {
            services.AddScoped<ILianLianPayClient, LianLianPayClient>();
            services.AddScoped<ILianLianPayNotifyClient, LianLianPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}