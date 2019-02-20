using System;
using Essensoft.AspNetCore.Payment.LcswPay.Parser;
using Microsoft.Extensions.DependencyInjection;

namespace Essensoft.AspNetCore.Payment.LcswPay
{
    public static class ServiceCollectionExtensions
    {
        public static void AddLcswPay(
            this IServiceCollection services)
        {
            services.AddLcswPay(null);
        }

        public static void AddLcswPay(
            this IServiceCollection services,
            Action<LcswPayOption> setupAction)
        {
            services.AddScoped<ILcswPayClient, LcswPayClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}