using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TuitionISVChargeDetailDTO Data Structure.
    /// </summary>
    public class TuitionISVChargeDetailDTO : AlipayObject
    {
        /// <summary>
        /// 费用金额
        /// </summary>
        [JsonPropertyName("fee_amount")]
        public TuitionMoneyDTO FeeAmount { get; set; }

        /// <summary>
        /// 费用名称
        /// </summary>
        [JsonPropertyName("fee_name")]
        public string FeeName { get; set; }
    }
}
