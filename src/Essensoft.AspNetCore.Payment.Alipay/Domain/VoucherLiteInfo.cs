using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherLiteInfo Data Structure.
    /// </summary>
    public class VoucherLiteInfo : AlipayObject
    {
        /// <summary>
        /// 发券时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 券状态，可枚举，分别为“可用”(ENABLED)和“不可用”(DISABLED)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
