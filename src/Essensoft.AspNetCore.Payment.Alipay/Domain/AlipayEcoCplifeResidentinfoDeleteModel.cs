using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeResidentinfoDeleteModel Data Structure.
    /// </summary>
    public class AlipayEcoCplifeResidentinfoDeleteModel : AlipayObject
    {
        /// <summary>
        /// 待删除的住户所在的小区ID(支付宝平台统一小区ID标识)
        /// </summary>
        [JsonPropertyName("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 待删除住户在物业系统中的唯一标示,一次至多传入200条用户ID
        /// </summary>
        [JsonPropertyName("out_resident_id_set")]
        public List<string> OutResidentIdSet { get; set; }
    }
}
