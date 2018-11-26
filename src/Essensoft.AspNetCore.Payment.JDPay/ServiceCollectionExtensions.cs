using System;
using Essensoft.AspNetCore.Payment.JDPay;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddJDPay(
            this IServiceCollection services)
        {
            services.AddJDPay(setupAction: null);
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