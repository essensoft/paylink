using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketItemCreateResponse.
    /// </summary>
    public class AlipayOfflineMarketItemCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑体系内部商品的唯一标识，后续的增删改查接口都使用该ID作为主键
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 支持英文字母和数字，由开发者自行定义（不允许重复），在商品notify消息中也会带有该参数，以此标明本次notify消息是对哪个请求的回应
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
