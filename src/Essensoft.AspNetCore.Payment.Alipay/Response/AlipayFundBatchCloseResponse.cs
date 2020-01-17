using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundBatchCloseResponse.
    /// </summary>
    public class AlipayFundBatchCloseResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝内部的批次ID
        /// </summary>
        [JsonPropertyName("batch_trans_id")]
        public string BatchTransId { get; set; }

        /// <summary>
        /// DISUSE：批次废弃
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
