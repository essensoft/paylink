using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenOperationBizfeeActivityApplyResponse.
    /// </summary>
    public class AlipayOpenOperationBizfeeActivityApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果码
        /// </summary>
        [JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回结果描述信息
        /// </summary>
        [JsonProperty("result_message")]
        public string ResultMessage { get; set; }
    }
}
