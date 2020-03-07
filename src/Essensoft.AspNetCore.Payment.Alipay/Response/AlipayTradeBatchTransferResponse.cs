using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeBatchTransferResponse.
    /// </summary>
    public class AlipayTradeBatchTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 分账受理时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 分账请求外部流水号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 业务结果码。 ACCEPT_SUCCESS：受理成功； ACCEPT_FAIL：受理失败； SUCCESS：结算处理成功； FAIL：结算处理失败； SYSTEM_EXCEPTION：系统异常
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 分账单据号
        /// </summary>
        [JsonPropertyName("settle_no")]
        public string SettleNo { get; set; }
    }
}
