using System;
using Microsoft.Extensions.DependencyInjection;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    public static class ServiceCollectionExtensions
    {
        public static void AddUnionPay(
            this IServiceCollection services)
        {
            services.AddUnionPay(null);
        }

        public static void AddUnionPay(
            this IServiceCollection services,
            Action<UnionPayOptions> setupAction)
        {
            services.AddHttpClient(nameof(UnionPayClient));

            services.AddSingleton<IUnionPayClient, UnionPayClient>();

#if NETCOREAPP3_1

            services.AddSingleton<IUnionPayNotifyClient, UnionPayNotifyClient>();
#endif

            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}