using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TbapiQueryAmountResponse Data Structure.
    /// </summary>
    public class TbapiQueryAmountResponse : AlipayObject
    {
        /// <summary>
        /// 指定产品码额度
        /// </summary>
        [JsonPropertyName("amt_map")]
        public string AmtMap { get; set; }

        /// <summary>
        /// 可用产品组额度
        /// </summary>
        [JsonPropertyName("available_group_amt")]
        public string AvailableGroupAmt { get; set; }
    }
}
