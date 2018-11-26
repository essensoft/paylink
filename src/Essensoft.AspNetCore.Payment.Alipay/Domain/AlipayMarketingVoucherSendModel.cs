using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherSendModel : AlipayObject
    {
        /// <summary>
        /// 券金额。浮点数，格式为#.00，单位是元。红包发放时填写，其它情形不能填
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝登录ID，手机或邮箱 。user_id, login_id, taobao_nick不能同时为空，优先级依次降低
        /// </summary>
        [JsonProperty("login_id")]
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 发券备注
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部业务订单号，用于幂等控制，相同template_id和out_biz_no认为是同一次业务
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 淘宝昵称 。user_id, login_id, taobao_nick不能同时为空，优先级依次降低
        /// </summary>
        [JsonProperty("taobao_nick")]
        [XmlElement("taobao_nick")]
        public string TaobaoNick { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonProperty("template_id")]
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户ID 。user_id, login_id, taobao_nick不能同时为空，优先级依次降低
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
