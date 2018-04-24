using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// APP支付 调起支付
    /// </summary>
    public class WeChatPayAppCallPaymentRequest : IWeChatPayCalcRequest
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string PartnerId { get; set; }

        /// <summary>
        /// 预支付交易会话ID
        /// </summary>
        public string PrepayId { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        public string Package { get; set; } = "Sign=WXPay";

        #region IWeChatPayCalcRequest Members

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "appid", AppId },
                { "partnerid", PartnerId },
                { "prepayid", PrepayId },
                { "package", Package },
            };
            return parameters;
        }

        #endregion
    }
}
