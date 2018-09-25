using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using Essensoft.AspNetCore.Payment.WeChatPay;

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
            services.AddHttpClient(WeChatPayOptions.DefaultClientName);
        }

        public static void AddWeChatPayCertificateHttpClient(
            this IServiceCollection services,
            X509Certificate2 certificate)
        {
            services.AddWeChatPayCertificateHttpClient(certificateName: "Default", certificate: certificate);
        }

        public static void AddWeChatPayCertificateHttpClient(
            this IServiceCollection services,
            string certificateName,
            X509Certificate2 certificate)
        {
            services.AddHttpClient(WeChatPayOptions.CertificateClientName + "." + certificateName).ConfigurePrimaryHttpMessageHandler(() =>
            {
                var handler = new HttpClientHandler();
                handler.ClientCertificates.Add(certificate);
                return handler;
            });
        }
    }
}