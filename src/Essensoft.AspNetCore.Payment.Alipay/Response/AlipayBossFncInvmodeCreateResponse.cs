using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncInvmodeCreateResponse.
    /// </summary>
    public class AlipayBossFncInvmodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 是否调用成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }
    }
}
