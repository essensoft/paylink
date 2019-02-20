using Essensoft.AspNetCore.Payment.LcswPay.Parser;
using Essensoft.AspNetCore.Payment.LcswPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.LcswPay
{
    /// <summary>
    /// 利楚商务扫呗支付客户端默认实现
    /// </summary>
    public class LcswPayClient : ILcswPayClient
    {
        private readonly ILogger _logger;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IOptionsSnapshot<LcswPayOption> _optionsSnapshotAccessor;

        #region LcswPayClient Constructors

        public LcswPayClient(
            ILogger<LcswPayClient> logger,
            IHttpClientFactory clientFactory,
            IOptionsSnapshot<LcswPayOption> optionsAccessor)
        {
            _logger = logger;
            _clientFactory = clientFactory;
            _optionsSnapshotAccessor = optionsAccessor;
        }

        #endregion
        public async Task<T> ExecuteAsync<T>(ILcswPayResquest<T> request) where T : LcswPayResponse
        {
            return await ExecuteAsync(request, null);
        }

        public async Task<T> ExecuteAsync<T>(ILcswPayResquest<T> request, string optionsName) where T : LcswPayResponse
        {
            var option = _optionsSnapshotAccessor.Get(optionsName);
            //赋值通用参数
            request.PayVersion = option.Version;
            request.MerchantNo = option.MerchantNo;
            request.TerminalId = option.TerminalId;
            //计算签名
            var signParas = request.GetSignInfo();
            var requestParas = signParas.GetAllParasAndSign(option);
            //执行请求
            var url = request.GetRequestUrl().ToFullApiUrl(option.ApiBaseUrl);
            var content = JsonConvert.SerializeObject(requestParas);
            _logger.Log(option.LogLevel, $"Request content:{content};url:{url}");
            using (var client = _clientFactory.CreateClient())
            {
                var body = await client.DoPostAsync(url, content);
                //处理响应
                _logger.Log(option.LogLevel, "Response:{body}", body);
                var parser = new LcswPayJsonParser<T>();
                var response = parser.Parse(body);

                if (request.IsCheckResponseSign())
                {
                    response.CheckSign();
                }
                return response;
            }
        }
    }
}
