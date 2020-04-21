using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AftFinsecureRiskplusSecurityPolicyQueryModel Data Structure.
    /// </summary>
    public class AftFinsecureRiskplusSecurityPolicyQueryModel : AlipayObject
    {
        /// <summary>
        /// 蚁盾事件信息
        /// </summary>
        [JsonPropertyName("event_info")]
        public EventInfo EventInfo { get; set; }

        /// <summary>
        /// 产品集群ID，默认填写示例值
        /// </summary>
        [JsonPropertyName("product_instance_id")]
        public string ProductInstanceId { get; set; }
    }
}
