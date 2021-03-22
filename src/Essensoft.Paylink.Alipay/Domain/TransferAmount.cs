using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TransferAmount Data Structure.
    /// </summary>
    public class TransferAmount : AlipayObject
    {
        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 金额，对应币种的最小单位
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
