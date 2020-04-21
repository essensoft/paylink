using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemModifyResponse.
    /// </summary>
    public class KoubeiItemModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑体系内部商品的唯一标识，后续的增删改查接口都使用该ID作为主键
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 即入参中的request_id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
