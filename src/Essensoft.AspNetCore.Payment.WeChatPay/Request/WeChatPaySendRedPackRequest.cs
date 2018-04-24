using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 发放普通红包
    /// </summary>
    public class WeChatPaySendRedPackRequest : IWeChatPayCertificateRequest<WeChatPaySendRedPackResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MchBillNo { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 公众账号appid
        /// </summary>
        public string WXAppId { get; set; }

        /// <summary>
        /// 触达用户appid
        /// </summary>
        public string MsgAppId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string SendName { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string ReOpenId { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// 红包发放总人数
        /// </summary>
        public int TotalNum { get; set; }

        /// <summary>
        /// 红包祝福语
        /// </summary>
        public string Wishing { get; set; }

        /// <summary>
        /// Ip地址
        /// </summary>
        public string ClientIp { get; set; }

        /// <summary>
        /// 活动名称
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

        /// <summary>
        /// 活动信息
        /// </summary>
        public string RiskInfo { get; set; }

        /// <summary>
        /// 扣钱方mchid
        /// </summary>
        public string ConsumeMchId { get; set; }

        #region IWeChatPayCertificateRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/sendredpack";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "mch_billno", MchBillNo },
                { "sub_mch_id", SubMchId },
                { "wxappid", WXAppId },
                { "msgappid", MsgAppId },
                { "send_name", SendName },
                { "re_openid", ReOpenId },
                { "total_amount", TotalAmount },
                { "total_num", TotalNum },
                { "wishing", Wishing },
                { "client_ip", ClientIp },
                { "act_name", ActName },
                { "remark", Remark },
                { "scene_id", SceneId },
                { "risk_info", RiskInfo },
                { "consume_mch_id", ConsumeMchId },
            };
            return parameters;
        }

        #endregion
    }
}
