using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityExtendinfosAddModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketCommodityExtendinfosAddModel : AlipayObject
    {
        /// <summary>
        /// 公服扩展信息列表
        /// </summary>
        [JsonProperty("commodity_ext_infos")]
        public List<CommodityPublicExtInfos> CommodityExtInfos { get; set; }

        /// <summary>
        /// 服务插件ID
        /// </summary>
        [JsonProperty("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
