using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppDetectReportQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppDetectReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务唯一id. 如迭代id
        /// </summary>
        [JsonPropertyName("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 外部业务标识.如pipeline id、蚂蚁流id等
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
