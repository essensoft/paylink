using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailTopinstanceQueryResponse.
    /// </summary>
    public class KoubeiRetailTopinstanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户维度券或者DM信息列表
        /// </summary>
        [JsonPropertyName("instance_list")]
        public List<InstanceInfo> InstanceList { get; set; }

        /// <summary>
        /// 返回的总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
