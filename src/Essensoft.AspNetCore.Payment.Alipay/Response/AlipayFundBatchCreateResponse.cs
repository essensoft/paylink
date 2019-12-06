using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundBatchCreateResponse.
    /// </summary>
    public class AlipayFundBatchCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝内部的批次ID
        /// </summary>
        [JsonPropertyName("batch_trans_id")]
        public string BatchTransId { get; set; }

        /// <summary>
        /// 商户的批次号
        /// </summary>
        [JsonPropertyName("out_batch_no")]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// INIT：批次落单成功
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
