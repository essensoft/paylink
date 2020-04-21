using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringItemModifyResponse.
    /// </summary>
    public class KoubeiCateringItemModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑体系内部商品的唯一标识
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
