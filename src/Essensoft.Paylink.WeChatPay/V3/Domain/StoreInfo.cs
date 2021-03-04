using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 商户门店信息
    /// </summary>
    public class StoreInfo : WeChatPayObject
    {
        /// <summary>
        /// 门店编号
        /// </summary>
        /// <remarks>
        /// 商户侧门店编号
        /// <para>示例值：0001</para>
        /// </remarks>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        /// <remarks>
        /// 商户侧门店名称
        /// <para>示例值：腾讯大厦分店</para>
        /// </remarks>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 地区编码
        /// </summary>
        /// <remarks>
        /// 地区编码，详细请见省市区编号对照表。
        /// <para>示例值：440305</para>
        /// </remarks>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        /// <remarks>
        /// 详细的商户门店地址
        /// <para>示例值：广东省深圳市南山区科技中一道10000号</para>
        /// </remarks>
        [JsonPropertyName("address")]
        public string Address { get; set; }
    }
}
