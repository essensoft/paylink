using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HbMeiWeiMerchantInfo Data Structure.
    /// </summary>
    public class HbMeiWeiMerchantInfo : AlipayObject
    {
        /// <summary>
        /// 商家ID
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [JsonPropertyName("shop_list")]
        public List<HbMeiWeishopInfo> ShopList { get; set; }
    }
}
