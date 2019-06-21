using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 微信代扣 - 乘车码代扣 - 申请签约
    /// </summary>
    public class WeChatPayPaPayPartnerEntrustWebRequest : IWeChatPayRequest<WeChatPayPaPayPartnerEntrustWebResponse>
    {
        /// <summary>
        /// 子商户应用号
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

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
        /// 返回app
        /// </summary>
        public string ReturnApp { get; set; }

        /// <summary>
        /// 返回web
        /// </summary>
        public string ReturnWeb { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/papay/partner/entrustweb";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
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
                { "return_app", ReturnApp },
                { "return_web", ReturnWeb },
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return WeChatPaySignType.MD5;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
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
