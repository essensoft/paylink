using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAssetQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodAssetQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 物料模板的图片url
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 物料模板的名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonPropertyName("model_number")]
        public string ModelNumber { get; set; }
    }
}
