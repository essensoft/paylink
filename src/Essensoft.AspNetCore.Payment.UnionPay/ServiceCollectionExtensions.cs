using System;
using Essensoft.AspNetCore.Payment.UnionPay;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddUnionPay(
            this IServiceCollection services)
        {
            services.AddUnionPay(setupAction: null);
        }

        public static void AddUnionPay(
            this IServiceCollection services,
            Action<UnionPayOptions> setupAction)
        {
            services.AddScoped<IUnionPayClient, UnionPayClient>();
            services.AddScoped<IUnionPayNotifyClient, UnionPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}