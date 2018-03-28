using Essensoft.AspNetCore.Payment.QPay;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddQPay(
            this IServiceCollection services)
        {
            services.AddQPay(setupAction: null);
        }

        public static void AddQPay(
            this IServiceCollection services,
            Action<QPayOptions> setupAction)
        {
            services.AddSingleton<QPayClient>();
            services.AddSingleton<QPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}