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
            services.AddSingleton<QPayClient>();
            services.AddSingleton<QPayNotifyClient>();

            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }

        public static void AddQPayHttpClient(
            this IServiceCollection services)
        {
            services.AddHttpClient(QPayOptions.DefaultClientName);
        }

        public static void AddQPayCertificateHttpClient(
            this IServiceCollection services,
            X509Certificate2 certificate)
        {
            services.AddQPayCertificateHttpClient(certificateName: "Default", certificate: certificate);
        }

        public static void AddQPayCertificateHttpClient(
            this IServiceCollection services,
            string certificateName,
            X509Certificate2 certificate)
        {
            services.AddHttpClient(QPayOptions.CertificateClientName + "." + certificateName).ConfigurePrimaryHttpMessageHandler(() =>
            {
                var handler = new HttpClientHandler();
                handler.ClientCertificates.Add(certificate);
                return handler;
            });
        }
    }
}