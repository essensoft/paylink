using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
