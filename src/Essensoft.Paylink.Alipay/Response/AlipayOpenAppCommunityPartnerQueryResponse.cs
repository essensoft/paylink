using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppCommunityPartnerQueryResponse.
    /// </summary>
    public class AlipayOpenAppCommunityPartnerQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 关系数
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 关系对象
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<CommunityPartnerRelaData> DataList { get; set; }
    }
}
