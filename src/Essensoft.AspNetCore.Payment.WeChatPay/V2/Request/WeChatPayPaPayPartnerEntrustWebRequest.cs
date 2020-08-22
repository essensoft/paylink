using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 微信代扣 - 公众号签约 (服务商)
    /// </summary>
    public class WeChatPayPaPayPartnerEntrustWebRequest : IWeChatPayRequest<WeChatPayPaPayPartnerEntrustWebResponse>
    {
        /// <summary>
        /// 模板id
        /// </summary>
        public string PlanId { get; set; }

        /// <summary>
        /// 签约协议号
        /// </summary>
        public string ContractCode { get; set; }

        /// <summary>
        /// 请求序列号
        /// </summary>
        public string RequestSerial { get; set; }

        /// <summary>
        /// 用户账户展示名称
        /// </summary>
        public string ContractDisplayAccount { get; set; }

        /// <summary>
        /// 回调通知url
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 返回web
        /// </summary>
        public string ReturnWeb { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/papay/partner/entrustweb";

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetRequestUrl(string url)
        {
            requestUrl = url;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "plan_id", PlanId },
                { "contract_code", ContractCode },
                { "request_serial", RequestSerial },
                { "contract_display_account", ContractDisplayAccount },
                { "notify_url", NotifyUrl },
                { "version", Version },
                { "return_web", ReturnWeb },
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);
            sortedTxtParams.Add(WeChatPayConsts.timestamp, WeChatPayUtility.GetTimeStamp());

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}
