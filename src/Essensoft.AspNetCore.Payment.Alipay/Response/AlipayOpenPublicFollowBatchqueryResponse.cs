using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicFollowBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicFollowBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 本次调用获取的userId个数，最大值为10000
        /// </summary>
        [JsonProperty("count")]
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 查询分组的userid
        /// </summary>
        [JsonProperty("next_user_id")]
        [XmlElement("next_user_id")]
        public string NextUserId { get; set; }

        /// <summary>
        /// 用户的userId列表
        /// </summary>
        [JsonProperty("user_id_list")]
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
