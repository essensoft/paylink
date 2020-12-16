using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeProductModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAmpeProductModifyModel : AlipayObject
    {
        /// <summary>
        /// 产品id，必填
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 设备产品名称, 必填，最大长度32，单oid下唯一
        /// </summary>
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配，必填
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
