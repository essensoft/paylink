using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicTopicBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicTopicBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 营销位列表
        /// </summary>
        [JsonProperty("topic_list")]
        public List<Topic> TopicList { get; set; }
    }
}
