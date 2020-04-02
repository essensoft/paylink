using System.Text.Json.Serialization;

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
        [JsonPropertyName("query_result")]
        public string QueryResult { get; set; }

        /// <summary>
        /// 查询是否成功具体描述
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 查询是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
