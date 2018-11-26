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
            services.AddScoped<ILianLianPayClient, LianLianPayClient>();
            services.AddScoped<ILianLianPayNotifyClient, LianLianPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}