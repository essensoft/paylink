using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechApplyResponse.
    /// </summary>
    public class AlipayOpenOperationBizfeeAftechApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonPropertyName("result_message")]
        public string ResultMessage { get; set; }
    }
}
