using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EcoRenthouseOtherAmount Data Structure.
    /// </summary>
    public class EcoRenthouseOtherAmount : AlipayObject
    {
        /// <summary>
        /// 30
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 费用名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 费用单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
