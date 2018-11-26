using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 微信内H5调起支付
    /// </summary>
    public class WeChatPayH5CallPaymentRequest : IWeChatPayCallRequest
    {
        /// <summary>
        /// 公众号ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 订单详情扩展字符串
        /// </summary>
        public string Package { get; set; }

        #region IWeChatPayCalcRequest Members

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "appId", AppId },
                { "package", Package },
            };
            return parameters;
        }

        #endregion
    }
}
