using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundBatchTransferResponse.
    /// </summary>
    public class AlipayFundBatchTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 商户请求的批次流水号，同请求中的"batch_no"。
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 支付宝系统内部批次请求id。
        /// </summary>
        [JsonPropertyName("batch_trans_id")]
        public string BatchTransId { get; set; }
    }
}
