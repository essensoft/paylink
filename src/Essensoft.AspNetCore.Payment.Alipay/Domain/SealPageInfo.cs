using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SealPageInfo Data Structure.
    /// </summary>
    public class SealPageInfo : AlipayObject
    {
        /// <summary>
        /// 当前页码号
        /// </summary>
        [JsonPropertyName("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 当前页码的用印申请信息
        /// </summary>
        [JsonPropertyName("seal_request_info")]
        public SealRequestInfo SealRequestInfo { get; set; }
    }
}
