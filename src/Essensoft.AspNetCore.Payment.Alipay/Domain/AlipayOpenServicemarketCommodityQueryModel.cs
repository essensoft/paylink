using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketCommodityQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务插件ID
        /// </summary>
        [JsonProperty("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 服务创建者ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
