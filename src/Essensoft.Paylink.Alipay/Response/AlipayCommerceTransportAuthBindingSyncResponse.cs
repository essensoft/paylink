using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAuthBindingSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportAuthBindingSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 标志处理结果
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonPropertyName("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 处理是否成功。true：成功；false：失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
