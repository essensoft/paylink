using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OperationExtDataModel Data Structure.
    /// </summary>
    [Serializable]
    public class OperationExtDataModel : AlipayObject
    {
        /// <summary>
        /// 奖品金额,单位分
        /// </summary>
        [JsonProperty("prize_amount")]
        public string PrizeAmount { get; set; }

        /// <summary>
        /// 奖品 id
        /// </summary>
        [JsonProperty("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [JsonProperty("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 营销错误码
        /// </summary>
        [JsonProperty("promo_error_code")]
        public string PromoErrorCode { get; set; }
    }
}
