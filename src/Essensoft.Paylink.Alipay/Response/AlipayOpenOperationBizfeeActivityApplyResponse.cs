using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenOperationBizfeeActivityApplyResponse.
    /// </summary>
    public class AlipayOpenOperationBizfeeActivityApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回结果描述信息
        /// </summary>
        [JsonPropertyName("result_message")]
        public string ResultMessage { get; set; }
    }
}
