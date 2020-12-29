using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchOpenStatusRequest Data Structure.
    /// </summary>
    public class SearchOpenStatusRequest : AlipayObject
    {
        /// <summary>
        /// 行为(关闭或开启) on off
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 申请单类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [JsonPropertyName("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 品牌box id
        /// </summary>
        [JsonPropertyName("box_id")]
        public string BoxId { get; set; }

        /// <summary>
        /// 关闭原因
        /// </summary>
        [JsonPropertyName("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
