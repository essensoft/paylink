using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FinanceCreditItem Data Structure.
    /// </summary>
    public class FinanceCreditItem : AlipayObject
    {
        /// <summary>
        /// 授信id
        /// </summary>
        [JsonPropertyName("credit_id")]
        public string CreditId { get; set; }

        /// <summary>
        /// 版本，从1开始，0表示最新版本
        /// </summary>
        [JsonPropertyName("ver")]
        public long Ver { get; set; }
    }
}
