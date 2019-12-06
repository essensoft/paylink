using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcapiprodDrawndnFeerecordQueryResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnFeerecordQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 费用交易流水
        /// </summary>
        [JsonPropertyName("fee_records")]
        public List<FeeRecords> FeeRecords { get; set; }

        /// <summary>
        /// 唯一标识这次请求
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
