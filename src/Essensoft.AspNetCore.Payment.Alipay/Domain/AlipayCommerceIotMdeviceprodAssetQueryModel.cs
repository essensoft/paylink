using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAssetQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodAssetQueryModel : AlipayObject
    {
        /// <summary>
        /// 模板ID（物料系统的item_id）
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
