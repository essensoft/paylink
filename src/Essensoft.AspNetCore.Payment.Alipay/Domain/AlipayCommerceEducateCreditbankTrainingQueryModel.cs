using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankTrainingQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateCreditbankTrainingQueryModel : AlipayObject
    {
        /// <summary>
        /// 学分银行ID
        /// </summary>
        [JsonPropertyName("cb_id")]
        public string CbId { get; set; }

        /// <summary>
        /// 渠道，默认值：shcreditbank(上海学分银行)
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
