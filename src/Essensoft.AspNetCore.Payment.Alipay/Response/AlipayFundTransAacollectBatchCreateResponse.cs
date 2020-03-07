using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransAacollectBatchCreateResponse.
    /// </summary>
    public class AlipayFundTransAacollectBatchCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 批次随机batchToken
        /// </summary>
        [JsonPropertyName("batch_token")]
        public string BatchToken { get; set; }
    }
}
