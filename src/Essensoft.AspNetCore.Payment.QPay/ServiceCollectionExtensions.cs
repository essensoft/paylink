using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using Essensoft.AspNetCore.Payment.QPay;

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
            services.AddScoped<IQPayClient, QPayClient>();
            services.AddScoped<IQPayNotifyClient, QPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}