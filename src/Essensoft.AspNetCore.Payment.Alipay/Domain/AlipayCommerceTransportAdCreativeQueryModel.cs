using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdCreativeQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAdCreativeQueryModel : AlipayObject
    {
        /// <summary>
        /// 广告主唯一ID；是否唯一(不需要)；用作校验防止跨user操作；天猫接口调用传参
        /// </summary>
        [JsonPropertyName("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 广告创意ID；是否唯一(不需要)；用于通过创意ID查询创意详情；天猫广告创意信息查询入参
        /// </summary>
        [JsonPropertyName("creative_id")]
        public long CreativeId { get; set; }
    }
}
