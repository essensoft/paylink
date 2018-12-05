using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.Notify;
using Essensoft.AspNetCore.Payment.WeChatPay.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayNotifyClient : IWeChatPayNotifyClient
    {
        private readonly ILogger _logger;
        private readonly IOptionsSnapshot<WeChatPayOptions> _optionsSnapshotAccessor;

        #region WeChatPayNotifyClient Constructors

        public WeChatPayNotifyClient(
            ILogger<WeChatPayNotifyClient> logger,
            IOptionsSnapshot<WeChatPayOptions> optionsAccessor)
        {
            _logger = logger;
            _optionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        #region IWeChatPayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : WeChatPayNotifyResponse
        {
            return await ExecuteAsync<T>(request, null);
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request, string optionsName) where T : WeChatPayNotifyResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? _optionsSnapshotAccessor.Value : _optionsSnapshotAccessor.Get(optionsName);
            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();
            _logger.Log(options.LogLevel, "Request:{body}", body);

            var parser = new WeChatPayXmlParser<T>();
            var rsp = parser.Parse(body);
            if (rsp is WeChatPayRefundNotifyResponse)
            {
                var key = MD5.Compute(options.Key).ToLower();
                var data = AES.Decrypt((rsp as WeChatPayRefundNotifyResponse).ReqInfo, key, AESCipherMode.ECB, AESPaddingMode.PKCS7);
                _logger.Log(options.LogLevel, "Decrypt Content:{data}", data); // AES-256-ECB
                rsp = parser.Parse(body, data);
            }
            else
            {
                CheckNotifySign(rsp, options);
            }
            return rsp;
        }

        #endregion

        #region Common Method

        private void CheckNotifySign(WeChatPayNotifyResponse response, WeChatPayOptions options)
        {
            if (response?.Parameters?.Count == 0)
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            if (!response.Parameters.TryGetValue("sign", out var sign))
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            var cal_sign = WeChatPaySignature.SignWithKey(response.Parameters, options.Key);
            if (cal_sign != sign)
            {
                throw new Exception("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}