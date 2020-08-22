using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 企业支付 - 向员工付款 (普通商户)
    /// </summary>
    public class WeChatPayPromotionPayWwSpTrans2PockeRequest : IWeChatPayCertRequest<WeChatPayPromotionPayWwSpTrans2PockeResponse>
    {
        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 校验用户姓名选项
        /// </summary>
        public string CheckName { get; set; }

        /// <summary>
        /// 收款用户姓名
        /// </summary>
        public string ReUserName { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 付款说明
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Ip地址
        /// </summary>
        public string SpBillCreateIp { get; set; }

        /// <summary>
        /// 付款消息类型
        /// </summary>
        public string WwMsgType { get; set; }

        /// <summary>
        /// 审批单号
        /// </summary>
        public string ApprovalNumber { get; set; }

        /// <summary>
        /// 审批类型
        /// </summary>
        public string ApprovalType { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ActName { get; set; }

        /// <summary>
        /// 付款的应用id
        /// </summary>
        public string AgentId { get; set; }

        #region IWeChatPayCertificateRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/mmpaymkttransfers/promotion/paywwsptrans2pocket";

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
                { "device_info", DeviceInfo },
                { "partner_trade_no", PartnerTradeNo },
                { "openid", OpenId },
                { "check_name", CheckName },
                { "re_user_name", ReUserName },
                { "amount", Amount },
                { "desc", Desc },
                { "spbill_create_ip", SpBillCreateIp },
                { "ww_msg_type", WwMsgType },
                { "approval_number", ApprovalNumber },
                { "approval_type", ApprovalType },
                { "act_name", ActName },
                { "agentid", AgentId },
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            var signList = new List<string>
            {
                "amount",
                "appid",
                "desc",
                "mch_id",
                "nonce_str",
                "openid",
                "partner_trade_no",
                "ww_msg_type",
            };

            sortedTxtParams.Add(WeChatPayConsts.workwx_sign, WeChatPaySignature.SignWithSecret(sortedTxtParams, options.AppSecret, signList));
            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}