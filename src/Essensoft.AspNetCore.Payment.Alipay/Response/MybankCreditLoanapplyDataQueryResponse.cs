using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoanapplyDataQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyDataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询到的对应的数据，大字段。
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 数据采集到的时间
        /// </summary>
        [JsonPropertyName("data_time")]
        public string DataTime { get; set; }
    }
}
