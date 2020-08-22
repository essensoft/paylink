using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 企业支付 - 发放企业红包 (普通商户)
    /// </summary>
    public class WeChatPaySendWorkWxRedPackRequest : IWeChatPayCertRequest<WeChatPaySendWorkWxRedPackResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MchBillNo { get; set; }

        /// <summary>
        /// 发送者名称
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// 发送红包的应用id
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 发送者头像
        /// </summary>
        public string SenderHeaderMediaId { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string ReOpenId { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// 红包祝福语
        /// </summary>
        public string Wishing { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ActName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        public string SceneId { get; set; }

        #region IWeChatPayCertificateRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/mmpaymkttransfers/sendworkwxredpack";

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
                { "mch_billno", MchBillNo },
                { "sender_name", SenderName },
                { "agentid", AgentId },
                { "sender_header_media_id", SenderHeaderMediaId },
                { "re_openid", ReOpenId },
                { "total_amount", TotalAmount },
                { "wishing", Wishing },
                { "act_name", ActName },
                { "remark", Remark },
                { "scene_id", SceneId },
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.wxappid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            var signList = new List<string>
            {
                "act_name",
                "mch_billno",
                "mch_id",
                "nonce_str",
                "re_openid",
                "total_amount",
                "wxappid",
            };

            sortedTxtParams.Add(WeChatPayConsts.workwx_sign, WeChatPaySignature.SignWithSecret(sortedTxtParams, options.AppSecret, signList));
            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        #endregion
    }
}
