using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodItemOfflineModel Data Structure.
    /// </summary>
    public class AlipayInsSceneInshealthserviceprodItemOfflineModel : AlipayObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
