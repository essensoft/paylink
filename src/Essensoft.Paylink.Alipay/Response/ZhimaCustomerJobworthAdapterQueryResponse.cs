using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthAdapterQueryResponse.
    /// </summary>
    public class ZhimaCustomerJobworthAdapterQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 匹配度
        /// </summary>
        [JsonPropertyName("adapter_score")]
        public string AdapterScore { get; set; }

        /// <summary>
        /// 业务编码
        /// </summary>
        [JsonPropertyName("sub_code")]
        public new string SubCode { get; set; }

        /// <summary>
        /// 业务中文结果信息
        /// </summary>
        [JsonPropertyName("sub_msg")]
        public new string SubMsg { get; set; }

        /// <summary>
        /// 职得工作证跳转小程序链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
