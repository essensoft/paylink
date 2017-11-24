using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// WelfareEcoStoreInfo Data Structure.
    /// </summary>
    public class WelfareEcoStoreInfo : AlipayObject
    {
        /// <summary>
        /// 门店具体位置（中文）
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
