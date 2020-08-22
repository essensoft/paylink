using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    // <summary>
    /// 微信代扣 - H5签约 (服务商)
    /// </summary>
    public class WeChatPayPaPayPartnerH5EntrustWebRequest : IWeChatPayRequest<WeChatPayPaPayPartnerH5EntrustWebResponse>
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
        /// 客户端 IP
        /// </summary>
        public string ClientIp { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public string Deviceid { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// QQ号
        /// </summary>
        public string QQ { get; set; }

        /// <summary>
        /// 微信OpenId
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string CreId { get; set; }

        /// <summary>
        /// 商户侧用户标识
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 回调应用
        /// </summary>
        public string ReturnAppId { get; set; }

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
                { "clientip", ClientIp },
                { "deviceid", Deviceid },
                { "mobile", Mobile },
                { "email", Email },
                { "qq", QQ },
                { "creid", CreId },
                { "outerid", OuterId },
                { "return_appid", ReturnAppId },
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return WeChatPaySignType.HMAC_SHA256;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);
            sortedTxtParams.Add(WeChatPayConsts.timestamp, WeChatPayUtility.GetTimeStamp());

            if (signType == WeChatPaySignType.HMAC_SHA256)
            {
                sortedTxtParams.Add(WeChatPayConsts.sign_type, WeChatPayConsts.HMAC_SHA256);
            }

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}