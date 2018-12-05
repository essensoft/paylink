using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 授权码查询openid
    /// </summary>
    public class WeChatPayAuthCodeToOpenIdRequest : IWeChatPayRequest<WeChatPayAuthCodeToOpenIdResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 子商户应用ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 授权码
        /// </summary>
        public string AuthCode { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/tools/authcodetoopenid";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "appid", AppId },
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
                { "auth_code", AuthCode }
            };
            return parameters;
        }

        public bool IsCheckResponseSign()
        {
            return true;
        }

        #endregion
    }
}
