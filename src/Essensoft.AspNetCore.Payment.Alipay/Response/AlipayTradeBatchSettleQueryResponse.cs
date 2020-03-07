using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeBatchSettleQueryResponse.
    /// </summary>
    public class AlipayTradeBatchSettleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 批量结算时传入的外部流水号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 批量结算详情
        /// </summary>
        [JsonPropertyName("settle_detail")]
        public List<BatchSettleDetail> SettleDetail { get; set; }

        /// <summary>
        /// 结算单据号
        /// </summary>
        [JsonPropertyName("settle_no")]
        public string SettleNo { get; set; }
    }
}
