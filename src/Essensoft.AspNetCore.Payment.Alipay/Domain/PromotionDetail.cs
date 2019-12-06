using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromotionDetail Data Structure.
    /// </summary>
    public class PromotionDetail : AlipayObject
    {
        /// <summary>
        /// 营销ID。若营销为平台红包时，由于平台红包聚合返回，则营销可能id为空
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 营销名称。若营销为平台红包时，该值返回，其他场景本接口不返回，以alipay.business.order.consult接口返回的营销名称为准
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 状态  VALID：可用  INVALID：不可用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 不可用原因  status=INVALID时不为空
        /// </summary>
        [JsonPropertyName("unavailable_reason")]
        public string UnavailableReason { get; set; }

        /// <summary>
        /// 面值，根据券类型而定，比如满减：10，折扣：0.9(九折)  只有当status为INVALID时，才有可能券值为空
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
