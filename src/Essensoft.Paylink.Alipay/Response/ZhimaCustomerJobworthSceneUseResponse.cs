using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthSceneUseResponse.
    /// </summary>
    public class ZhimaCustomerJobworthSceneUseResponse : AlipayResponse
    {
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
    }
}
