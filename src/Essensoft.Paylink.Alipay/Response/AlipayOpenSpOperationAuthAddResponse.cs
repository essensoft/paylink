using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenSpOperationAuthAddResponse.
    /// </summary>
    public class AlipayOpenSpOperationAuthAddResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝操作批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }
    }
}
