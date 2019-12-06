using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassTplUpdateResponse.
    /// </summary>
    public class AlipayPassTplUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 业务结果信息：包含模版id、动态参数集合和操作类型
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 操作成功与否标识：T标识成功，F标识失败
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
