using System;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.QPay.Parser;
using Essensoft.AspNetCore.Payment.QPay.Utility;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayClient : IQPayClient
    {
        public const string Prefix = nameof(QPayClient) + ".";

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly QPayCertificateManager _certificateManager;

        #region QPayClient Constructors

        public QPayClient(IHttpClientFactory httpClientFactory, QPayCertificateManager certificateManager)
        {
            _httpClientFactory = httpClientFactory;
            _certificateManager = certificateManager;
        }

        #endregion

        #region IQPayClient Members

        public async Task<T> ExecuteAsync<T>(IQPayRequest<T> request, QPayOptions options) where T : QPayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.MchId))
            {
                throw new ArgumentNullException(nameof(options.MchId));
            }

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new ArgumentNullException(nameof(options.Key));
            }

            var sortedTxtParams = new QPayDictionary(request.GetParameters());

            request.PrimaryHandler(options, sortedTxtParams);

            var client = _httpClientFactory.CreateClient(nameof(QPayClient));
            var body = await client.PostAsync(request.GetRequestUrl(), sortedTxtParams);
            var parser = new QPayXmlParser<T>();
            var rsp = parser.Parse(body);

            if (request.GetNeedCheckSign())
            {
                CheckResponseSign(rsp, options);
            }

            return rsp;
        }

        #endregion

        #region IQPayClient Members

        public async Task<T> ExecuteAsync<T>(IQPayCertRequest<T> request, QPayOptions options) where T : QPayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.MchId))
            {
                throw new ArgumentNullException(nameof(options.MchId));
            }

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new ArgumentNullException(nameof(options.Key));
            }

            if (string.IsNullOrEmpty(options.Certificate))
            {
                throw new ArgumentNullException(nameof(options.Certificate));
            }

            var sortedTxtParams = new QPayDictionary(request.GetParameters());

            request.PrimaryHandler(options, sortedTxtParams);

            var hash = options.GetCertificateHash();
            if (!_certificateManager.Contains(hash))
            {
                var certificate = File.Exists(options.Certificate) ?
                    new X509Certificate2(options.Certificate, options.CertificatePassword, X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.MachineKeySet) :
                    new X509Certificate2(Convert.FromBase64String(options.Certificate), options.CertificatePassword, X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.MachineKeySet);

                _certificateManager.TryAdd(hash, certificate);
            }

            var client = _httpClientFactory.CreateClient(Prefix + hash);
            var body = await client.PostAsync(request.GetRequestUrl(), sortedTxtParams);
            var parser = new QPayXmlParser<T>();
            var rsp = parser.Parse(body);

            if (request.GetNeedCheckSign())
            {
                CheckResponseSign(rsp, options);
            }

            return rsp;
        }

        #endregion

        #region Common Method

        private void CheckResponseSign(QPayResponse response, QPayOptions options)
        {
            if (string.IsNullOrEmpty(response.ResponseBody))
            {
                throw new QPayException("sign check fail: Body is Empty!");
            }

            if (response.ResponseParameters.Count == 0)
            {
                throw new QPayException("sign check fail: Parameters is Empty!");
            }

            if (response.ResponseParameters["return_code"] == "SUCCESS")
            {
                if (!response.ResponseParameters.TryGetValue("sign", out var sign))
                {
                    throw new QPayException("sign check fail: sign is Empty!");
                }

                var cal_sign = QPaySignature.SignWithKey(response.ResponseParameters, options.Key);
                if (cal_sign != sign)
                {
                    throw new QPayException("sign check fail: check Sign and Data Fail!");
                }
            }
        }

        #endregion
    }
}
