using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayZdataserviceUnidataQueryResponse.
    /// </summary>
    public class AlipayZdataserviceUnidataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询结果集，统一用string方式返回
        /// </summary>
        [JsonProperty("query_result")]
        [XmlElement("query_result")]
        public string QueryResult { get; set; }

        /// <summary>
        /// 查询是否成功具体描述
        /// </summary>
        [JsonProperty("result_code")]
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 查询是否成功
        /// </summary>
        [JsonProperty("success")]
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
