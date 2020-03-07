using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OperationExtDataModel Data Structure.
    /// </summary>
    public class OperationExtDataModel : AlipayObject
    {
        /// <summary>
        /// 奖品金额,单位分
        /// </summary>
        [JsonPropertyName("prize_amount")]
        public string PrizeAmount { get; set; }

        /// <summary>
        /// 奖品 id
        /// </summary>
        [JsonPropertyName("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [JsonPropertyName("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 营销错误码
        /// </summary>
        [JsonPropertyName("promo_error_code")]
        public string PromoErrorCode { get; set; }
    }
}
