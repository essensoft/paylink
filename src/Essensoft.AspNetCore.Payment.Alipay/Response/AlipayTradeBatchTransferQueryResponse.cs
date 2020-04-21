using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeBatchTransferQueryResponse.
    /// </summary>
    public class AlipayTradeBatchTransferQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 批量结算时传入的外部流水号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 批量结算详情
        /// </summary>
        [JsonPropertyName("royalty_detail")]
        public List<BatchRoyaltyDetail> RoyaltyDetail { get; set; }

        /// <summary>
        /// 结算单据号
        /// </summary>
        [JsonPropertyName("settle_no")]
        public string SettleNo { get; set; }
    }
}
