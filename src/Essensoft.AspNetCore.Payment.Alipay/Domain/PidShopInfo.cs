using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PidShopInfo Data Structure.
    /// </summary>
    public class PidShopInfo : AlipayObject
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// pid下的门店列表
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public List<string> ShopIds { get; set; }
    }
}
