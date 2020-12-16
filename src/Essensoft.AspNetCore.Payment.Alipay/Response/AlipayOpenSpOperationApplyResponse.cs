using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenSpOperationApplyResponse.
    /// </summary>
    public class AlipayOpenSpOperationApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝操作批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }
    }
}
