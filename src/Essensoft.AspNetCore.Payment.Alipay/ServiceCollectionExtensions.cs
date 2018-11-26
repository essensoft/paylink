using System;
using Essensoft.AspNetCore.Payment.Alipay;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAlipay(
            this IServiceCollection services)
        {
            services.AddAlipay(setupAction: null);
        }

        public static void AddAlipay(
            this IServiceCollection services,
            Action<AlipayOptions> setupAction)
        {
            services.AddScoped<IAlipayClient, AlipayClient>();
            services.AddScoped<IAlipayNotifyClient, AlipayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}