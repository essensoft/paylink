using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceQueryResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回请求小目标实例集合
        /// </summary>
        [JsonPropertyName("instances")]
        public List<QuestInstanceDO> Instances { get; set; }
    }
}
