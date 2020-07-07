using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 商户门店信息
    /// </summary>  
    public class StoreInfo : WeChatPayObject
    {
        /// <summary>
        /// 门店编号
        /// 商户侧门店编号
        /// 示例值：0001
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 门店名称
        /// 商户侧门店名称
        /// 示例值：腾讯大厦分店
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 地区编码
        /// 地区编码，详细请见省市区编号对照表。
        /// 示例值：440305
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 详细地址
        /// 详细的商户门店地址
        /// 示例值：广东省深圳市南山区科技中一道10000号
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
    }
}
