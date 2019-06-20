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
        public string QueryResult { get; set; }

        /// <summary>
        /// 查询是否成功具体描述
        /// </summary>
        [JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 查询是否成功
        /// </summary>
        [JsonProperty("success")]
        public string Success { get; set; }
    }
}
