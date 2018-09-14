using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddWeChatPay(
            this IServiceCollection services)
        {
            services.AddWeChatPay(setupAction: null);
        }

        public static void AddWeChatPay(
            this IServiceCollection services,
            Action<WeChatPayOptions> setupAction)
        {
            services.AddSingleton<WeChatPayClient>();
            services.AddSingleton<WeChatPayNotifyClient>();

            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }

        public static void AddWeChatPayHttpClient(
            this IServiceCollection services)
        {
            services.AddWeChatPayHttpClient(certificate: null);
        }

        public static void AddWeChatPayHttpClient(
            this IServiceCollection services,
            X509Certificate2 certificate)
        {
            services.AddHttpClient(WeChatPayUtility.DefaultClientName);

            if (certificate != null)
            {
                services.AddHttpClient(WeChatPayUtility.CertificateClientName).ConfigurePrimaryHttpMessageHandler(() =>
                {
                    var handler = new HttpClientHandler();
                    handler.ClientCertificates.Add(certificate);
                    return handler;
                });
            }
        }
    }
}