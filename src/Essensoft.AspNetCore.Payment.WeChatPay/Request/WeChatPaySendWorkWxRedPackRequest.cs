using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 企业支付 - 发放企业红包
    /// </summary>
    public class WeChatPaySendWorkWxRedPackRequest : IWeChatPayCertificateRequest<WeChatPaySendWorkWxRedPackResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MchBillNo { get; set; }

        /// <summary>
        /// 公众账号appid
        /// </summary>
        public string WxAppId { get; set; }

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

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/sendworkwxredpack";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "mch_billno", MchBillNo },
                { "wxappid", WxAppId },
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

        public bool IsCheckResponseSign()
        {
            return true;
        }

        #endregion
    }
}
