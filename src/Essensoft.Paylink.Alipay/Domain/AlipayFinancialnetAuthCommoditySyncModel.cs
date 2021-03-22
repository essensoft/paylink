using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthCommoditySyncModel Data Structure.
    /// </summary>
    public class AlipayFinancialnetAuthCommoditySyncModel : AlipayObject
    {
        /// <summary>
        /// 同步商品信息
        /// </summary>
        [JsonPropertyName("commodity_infos")]
        public List<CommodityInfoList> CommodityInfos { get; set; }

        /// <summary>
        /// 幂等字段
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 平台标识
        /// </summary>
        [JsonPropertyName("platform_id")]
        public string PlatformId { get; set; }
    }
}
