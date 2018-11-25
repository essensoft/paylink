using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 确认付款
    /// </summary>
    public class LianLianPayConfirmPaymentRequest : ILianLianPayRequest<LianLianPayConfirmPaymentResponse>
    {
        /// <summary>
        /// 平台来源
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 商户付款流水号
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 确认付款验证码
        /// </summary>
        public string ConfirmCode { get; set; }

        /// <summary>
        /// 服务器异步通知地址
        /// </summary>
        public string NotifyUrl { get; set; }

        #region ILianLianPayRequest

        private string ApiVersion = "1.0";

        public string GetRequestUrl()
        {
            return "https://instantpay.lianlianpay.com/paymentapi/confirmPayment.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "platform", Platform },
                { "api_version", ApiVersion },
                { "no_order", NoOrder },
                { "confirm_code", ConfirmCode },
                { "notify_url", NotifyUrl },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return ApiVersion;
        }

        public void SetApiVersion(string apiVersion)
        {
            ApiVersion = apiVersion;
        }

        #endregion
    }
}
