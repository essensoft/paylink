using System;
using Microsoft.Extensions.DependencyInjection;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAlipay(
            this IServiceCollection services)
        {
            services.AddAlipay(null);
        }

        public static void AddAlipay(
            this IServiceCollection services,
            Action<AlipayOptions> setupAction)
        {
            services.AddHttpClient(nameof(AlipayClient));

            services.AddSingleton<AlipayCertificateManager>();
            services.AddSingleton<IAlipayClient, AlipayClient>();

#if NETCOREAPP3_1

            services.AddSingleton<IAlipayNotifyClient, AlipayNotifyClient>();
#endif

            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}