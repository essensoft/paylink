using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherAuthSendModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherAuthSendModel : AlipayObject
    {
        /// <summary>
        /// 外部业务订单号，用于幂等控制
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 经过用户授权过后的发券码
        /// </summary>
        [JsonPropertyName("send_code")]
        public string SendCode { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
