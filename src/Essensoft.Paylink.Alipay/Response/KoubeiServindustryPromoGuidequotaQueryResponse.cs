using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryPromoGuidequotaQueryResponse.
    /// </summary>
    public class KoubeiServindustryPromoGuidequotaQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 权限份额
        /// </summary>
        [JsonPropertyName("auth_quota")]
        public List<IgAuthQuota> AuthQuota { get; set; }
    }
}
