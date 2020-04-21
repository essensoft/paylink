using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RechargeDetail Data Structure.
    /// </summary>
    public class RechargeDetail : AlipayObject
    {
        /// <summary>
        /// 真实资金，单位元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 面额，单位元
        /// </summary>
        [JsonPropertyName("assetamount")]
        public string Assetamount { get; set; }

        /// <summary>
        /// 内部订单号
        /// </summary>
        [JsonPropertyName("orderno")]
        public string Orderno { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("outorderno")]
        public string Outorderno { get; set; }
    }
}
