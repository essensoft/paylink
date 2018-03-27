using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// pid下的门店列表
        /// </summary>
        [JsonProperty("shop_ids")]
        public List<string> ShopIds { get; set; }
    }
}
