using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherSendModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherSendModel : AlipayObject
    {
        /// <summary>
        /// 券金额。浮点数，格式为#.00，单位是元。红包发放时填写，其它情形不能填
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展参数，当前仅允许传入的key值为"alipayMiniAppToken"
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 支付宝登录ID，手机或邮箱 。user_id, login_id, taobao_nick不能同时为空，优先级依次降低
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 发券备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部业务订单号，用于幂等控制，相同template_id和out_biz_no认为是同一次业务
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 淘宝昵称 。user_id, login_id, taobao_nick不能同时为空，优先级依次降低
        /// </summary>
        [JsonPropertyName("taobao_nick")]
        public string TaobaoNick { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户ID 。user_id, login_id, taobao_nick不能同时为空，优先级依次降低
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
