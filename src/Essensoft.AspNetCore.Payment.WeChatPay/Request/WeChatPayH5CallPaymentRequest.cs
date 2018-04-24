using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 小程序调起支付API
    /// </summary>
    public class WeChatPayLiteAppCallPaymentRequest : IWeChatPayCalcRequest
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 扩展字段
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
