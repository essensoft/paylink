using System;
using Microsoft.Extensions.DependencyInjection;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    public static class ServiceCollectionExtensions
    {
        public static void AddJDPay(
            this IServiceCollection services)
        {
            services.AddJDPay(null);
        }

        public static void AddJDPay(
            this IServiceCollection services,
            Action<JDPayOptions> setupAction)
        {
            services.AddScoped<IJDPayClient, JDPayClient>();
            services.AddScoped<IJDPayNotifyClient, JDPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}