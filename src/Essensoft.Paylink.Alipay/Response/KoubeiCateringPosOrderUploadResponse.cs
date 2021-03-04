using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosOrderUploadResponse.
    /// </summary>
    public class KoubeiCateringPosOrderUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 生成序列号标记每次上传
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }
    }
}
