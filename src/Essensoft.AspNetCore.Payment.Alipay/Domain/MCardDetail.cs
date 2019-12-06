using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MCardDetail Data Structure.
    /// </summary>
    public class MCardDetail : AlipayObject
    {
        /// <summary>
        /// 储值卡可用余额
        /// </summary>
        [JsonPropertyName("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 储值卡名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 储值卡支付金额
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }
    }
}
