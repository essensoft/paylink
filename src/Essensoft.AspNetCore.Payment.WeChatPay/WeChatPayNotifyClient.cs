using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.Notify;
using Essensoft.AspNetCore.Payment.WeChatPay.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MD5 = Essensoft.AspNetCore.Payment.Security.MD5;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 通知解析客户端。
    /// </summary>
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

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : WeChatPayNotify
        {
            return await ExecuteAsync<T>(request, null);
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request, string optionsName) where T : WeChatPayNotify
        {
            var options = _optionsSnapshotAccessor.Get(optionsName);
            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();
            _logger.Log(options.LogLevel, "Request:{body}", body);

            var parser = new WeChatPayXmlParser<T>();
            var notify = parser.Parse(body);
            if (notify is WeChatPayRefundNotify)
            {
                var key = MD5.Compute(options.Key).ToLower();
                var data = AES.Decrypt((notify as WeChatPayRefundNotify).ReqInfo, key, CipherMode.ECB, PaddingMode.PKCS7);
                _logger.Log(options.LogLevel, "Decrypt Content:{data}", data); // AES-256-ECB 解密内容
                notify = parser.Parse(body, data);
            }
            else
            {
                CheckNotifySign(notify, options);
            }

            return notify;
        }

        #endregion

        #region Common Method

        private void CheckNotifySign(WeChatPayNotify notify, WeChatPayOptions options)
        {
            if (string.IsNullOrEmpty(notify.Body))
            {
                throw new WeChatPayException("sign check fail: Body is Empty!");
            }

            if (notify.Parameters.Count == 0)
            {
                throw new WeChatPayException("sign check fail: Parameters is Empty!");
            }

            if (!notify.Parameters.TryGetValue("sign", out var sign))
            {
                throw new WeChatPayException("sign check fail: sign is Empty!");
            }

            var cal_sign = WeChatPaySignature.SignWithKey(notify.Parameters, options.Key);
            if (cal_sign != sign)
            {
                throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}