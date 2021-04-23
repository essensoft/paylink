using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotPrintmodelPrintSendResponse.
    /// </summary>
    public class AlipayCommerceIotPrintmodelPrintSendResponse : AlipayResponse
    {
        /// <summary>
        /// 调用任务id
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
