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
            services.AddHttpClient(nameof(JDPayClient));

            services.AddSingleton<IJDPayClient, JDPayClient>();
            services.AddSingleton<IJDPayNotifyClient, JDPayNotifyClient>();

            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}