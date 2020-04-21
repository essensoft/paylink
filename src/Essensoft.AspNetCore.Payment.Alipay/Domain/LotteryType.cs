using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LotteryType Data Structure.
    /// </summary>
    public class LotteryType : AlipayObject
    {
        /// <summary>
        /// 彩种ID
        /// </summary>
        [JsonPropertyName("lottery_type_id")]
        public long LotteryTypeId { get; set; }

        /// <summary>
        /// 彩种名称
        /// </summary>
        [JsonPropertyName("lottery_type_name")]
        public string LotteryTypeName { get; set; }
    }
}
