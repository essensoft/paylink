using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GFAOpenAPIQueryRequest Data Structure.
    /// </summary>
    public class GFAOpenAPIQueryRequest : AlipayObject
    {
        /// <summary>
        /// 业财受理单id
        /// </summary>
        [JsonPropertyName("acceptance_id")]
        public string AcceptanceId { get; set; }

        /// <summary>
        /// 两码-业务事件码
        /// </summary>
        [JsonPropertyName("biz_ev_code")]
        public string BizEvCode { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonPropertyName("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 业务唯一标识
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 业务流水子单号
        /// </summary>
        [JsonPropertyName("sub_out_business_no")]
        public string SubOutBusinessNo { get; set; }

        /// <summary>
        /// 是否用 biz_ev_code 字段筛选
        /// </summary>
        [JsonPropertyName("use_biz_ev_code")]
        public bool UseBizEvCode { get; set; }

        /// <summary>
        /// 是否使用 sub_out_business_no 字段做筛选
        /// </summary>
        [JsonPropertyName("use_sub_out_business_no")]
        public bool UseSubOutBusinessNo { get; set; }
    }
}
