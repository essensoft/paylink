using Newtonsoft.Json;

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
        [JsonProperty("batch_trans_id")]
        public string BatchTransId { get; set; }

        /// <summary>
        /// 商户的批次号
        /// </summary>
        [JsonProperty("out_batch_no")]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// INIT：批次落单成功
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
