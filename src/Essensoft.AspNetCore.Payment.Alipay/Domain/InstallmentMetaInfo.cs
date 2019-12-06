using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstallmentMetaInfo Data Structure.
    /// </summary>
    public class InstallmentMetaInfo : AlipayObject
    {
        /// <summary>
        /// 结束期数，包含此值
        /// </summary>
        [JsonPropertyName("end_term")]
        public long EndTerm { get; set; }

        /// <summary>
        /// 开始期数，包含此值
        /// </summary>
        [JsonPropertyName("start_term")]
        public long StartTerm { get; set; }

        /// <summary>
        /// 分期值（如还款方式、利率等）
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
