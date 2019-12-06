using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherConfirmResponse.
    /// </summary>
    public class AlipayMarketingVoucherConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 用于决定在用户确认领券后是否重定向。可枚举：true表示需要重定向，false表示不需要重定向
        /// </summary>
        [JsonPropertyName("need_redirect")]
        public bool NeedRedirect { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 重定向地址，用于接收支付宝返回的领取码，必须使用utf-8编码
        /// </summary>
        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 发券码。如果发生异常sendCode为空
        /// </summary>
        [JsonPropertyName("send_code")]
        public string SendCode { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 指定的用户确认页面主题名称
        /// </summary>
        [JsonPropertyName("theme")]
        public string Theme { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
