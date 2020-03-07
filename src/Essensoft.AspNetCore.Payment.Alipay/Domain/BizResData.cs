using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizResData Data Structure.
    /// </summary>
    public class BizResData : AlipayObject
    {
        /// <summary>
        /// 支用金额
        /// </summary>
        [JsonPropertyName("biz_amount")]
        public long BizAmount { get; set; }

        /// <summary>
        /// 支用日期
        /// </summary>
        [JsonPropertyName("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务借据号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务消费者唯一标志
        /// </summary>
        [JsonPropertyName("biz_user_id")]
        public string BizUserId { get; set; }
    }
}
