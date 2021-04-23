using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TuitionISVAmountInfoDTO Data Structure.
    /// </summary>
    public class TuitionISVAmountInfoDTO : AlipayObject
    {
        /// <summary>
        /// 费用明细
        /// </summary>
        [JsonPropertyName("charge_details")]
        public List<TuitionISVChargeDetailDTO> ChargeDetails { get; set; }

        /// <summary>
        /// 汇率（精确到小数点后8位）
        /// </summary>
        [JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 原金额
        /// </summary>
        [JsonPropertyName("original_amount")]
        public TuitionMoneyDTO OriginalAmount { get; set; }

        /// <summary>
        /// 目标金额
        /// </summary>
        [JsonPropertyName("target_amount")]
        public TuitionMoneyDTO TargetAmount { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public TuitionMoneyDTO TotalAmount { get; set; }
    }
}
