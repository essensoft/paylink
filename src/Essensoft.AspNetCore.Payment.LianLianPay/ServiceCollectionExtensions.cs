using System;
using Microsoft.Extensions.DependencyInjection;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    public static class ServiceCollectionExtensions
    {
        public static void AddLianLianPay(
            this IServiceCollection services)
        {
            services.AddLianLianPay(null);
        }

        public static void AddLianLianPay(
            this IServiceCollection services,
            Action<LianLianPayOptions> setupAction)
        {
            services.AddHttpClient(nameof(LianLianPayClient));

            services.AddSingleton<ILianLianPayClient, LianLianPayClient>();

#if NETCOREAPP3_0

            services.AddSingleton<ILianLianPayNotifyClient, LianLianPayNotifyClient>();

#endif

            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}