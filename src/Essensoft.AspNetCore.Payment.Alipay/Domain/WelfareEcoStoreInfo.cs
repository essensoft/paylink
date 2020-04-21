using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WelfareEcoStoreInfo Data Structure.
    /// </summary>
    public class WelfareEcoStoreInfo : AlipayObject
    {
        /// <summary>
        /// 门店具体位置（中文）
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
