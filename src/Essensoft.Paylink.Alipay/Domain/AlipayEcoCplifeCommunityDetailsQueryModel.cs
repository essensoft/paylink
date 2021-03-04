using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeCommunityDetailsQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoCplifeCommunityDetailsQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝社区小区统一编号，必须在物业账号名下存在。
        /// </summary>
        [JsonPropertyName("community_id")]
        public string CommunityId { get; set; }
    }
}
