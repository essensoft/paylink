using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommoditySmartcitySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketCommoditySmartcitySyncModel : AlipayObject
    {
        /// <summary>
        /// 服务基础信息
        /// </summary>
        [JsonProperty("commodity_base_info")]
        public CommodityBaseInfo CommodityBaseInfo { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonProperty("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 是否预发环境数据，1是，0否
        /// </summary>
        [JsonProperty("is_pre")]
        public string IsPre { get; set; }

        /// <summary>
        /// 新型智慧城市服务扩展信息
        /// </summary>
        [JsonProperty("smart_city_commodity_info")]
        public SmartCityCommodityInfo SmartCityCommodityInfo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
