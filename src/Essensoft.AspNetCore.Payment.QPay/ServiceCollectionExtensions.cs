using System;
using Microsoft.Extensions.DependencyInjection;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public static class ServiceCollectionExtensions
    {
        public static void AddQPay(
            this IServiceCollection services)
        {
            services.AddQPay(null);
        }

        public static void AddQPay(
            this IServiceCollection services,
            Action<QPayOptions> setupAction)
        {
            services.AddScoped<IQPayClient, QPayClient>();
            services.AddScoped<IQPayNotifyClient, QPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}