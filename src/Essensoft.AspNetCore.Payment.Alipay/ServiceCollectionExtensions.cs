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
            services.AddSingleton<AlipayClient>();
            services.AddSingleton<AlipayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }

        public static void AddAlipayHttpClient(
            this IServiceCollection services)
        {
            services.AddHttpClient(AlipayOptions.DefaultClientName);
        }
    }
}