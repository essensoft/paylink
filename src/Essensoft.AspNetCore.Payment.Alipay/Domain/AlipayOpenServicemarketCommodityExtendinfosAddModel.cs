using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityExtendinfosAddModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketCommodityExtendinfosAddModel : AlipayObject
    {
        /// <summary>
        /// 公服扩展信息列表
        /// </summary>
        [JsonPropertyName("commodity_ext_infos")]
        public List<CommodityPublicExtInfos> CommodityExtInfos { get; set; }

        /// <summary>
        /// 服务插件ID
        /// </summary>
        [JsonPropertyName("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
