using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdCreativeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdCreativeCreateModel : AlipayObject
    {
        /// <summary>
        /// 广告创意与物料信息；是否唯一(不需要)；用于新增广告创意与创意下包含的物料信息；天猫广告投放传参
        /// </summary>
        [JsonProperty("ad_creative")]
        public AdCreative AdCreative { get; set; }

        /// <summary>
        /// 广告主唯一ID；是否唯一(不需要)；用作校验防止跨user操作；天猫接口调用传参
        /// </summary>
        [JsonProperty("ad_user_id")]
        public long AdUserId { get; set; }
    }
}
