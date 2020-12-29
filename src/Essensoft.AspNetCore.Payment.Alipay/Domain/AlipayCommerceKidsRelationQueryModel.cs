using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceKidsRelationQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceKidsRelationQueryModel : AlipayObject
    {
        /// <summary>
        /// 家长支付宝userId，用于查询与该家长关联的孩子
        /// </summary>
        [JsonPropertyName("parent_uid")]
        public string ParentUid { get; set; }

        /// <summary>
        /// 场景码，接入前需要进行申请,如：PHILANTHROPY
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景码，需要提前沟通，如：XB_SELECT
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
